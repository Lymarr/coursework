using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Speech.V1;
using Google.Cloud.Translation.V2;
using System.Linq;
using Vlc.DotNet.Forms;
using LibVLCSharp.Shared;
using System.Reflection;
using System.Collections.Generic;
using NAudio.Wave;

namespace ytDownloader
{
    public partial class Form2 : Form
    {
        private VlcControl _vlcControl;

        private string _videoPath;
        private string _audioPath;
        private List<Tuple<string, double>> timedTranscripts;
        private string _lastDisplayedTranscript = "";

        public Form2()
        {
            InitializeComponent();


            Core.Initialize();

            _vlcControl = new VlcControl();
            videoPanel.Controls.Add(_vlcControl);
            _vlcControl.Dock = DockStyle.Fill;

            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            var libDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

            _vlcControl.BeginInit();
            _vlcControl.VlcLibDirectory = libDirectory;
            _vlcControl.EndInit();

            startButton.Enabled = false;
            SubtitleUpdateTimer.Interval = 1500;
        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mp4, *.avi, *.wmv)|*.mp4;*.avi;*.wmv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _videoPath = openFileDialog.FileName;
            }
            else
            {
                this.Close();
            }

            _audioPath = Path.ChangeExtension(_videoPath, ".wav");

            string chunksDirectory = Path.Combine(Path.GetTempPath(), "C:\\Users\\User\\Videos\\audio_chunks");
            Directory.CreateDirectory(chunksDirectory);
            TimeSpan chunkDuration = TimeSpan.FromSeconds(10);
            SplitWavFile(_audioPath, chunksDirectory, chunkDuration);

            var chunkFilePaths = Directory.GetFiles(chunksDirectory).ToList();
            timedTranscripts = await RecognizeSpeechWithGoogleAsync(chunkFilePaths, "en-US", "AIzaSyDaNtymMf5TS4dBPL9t2sWxOfHVBXoi14s");

            startButton.Enabled = true; // Enable the 'Start' button after recognition and translation is complete
        }


        private async void startButton_Click(object sender, EventArgs e)
        {
            _vlcControl.SetMedia(new Uri(_videoPath));
            _vlcControl.Play();
            SubtitleUpdateTimer.Start();
            //  await UpdateTextboxesAsync();
        }

        private async Task<List<Tuple<string, double>>> RecognizeSpeechWithGoogleAsync(List<string> audioFilePaths, string languageCode, string apiKey)
        {
            var builder = new SpeechClientBuilder
            {
                CredentialsPath = "C:\\Users\\User\\Downloads\\videotospeech-381821-1e876455b613.json"
            };
            var speechClient = builder.Build();
            var config = new RecognitionConfig
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                SampleRateHertz = 44100,
                LanguageCode = "en",
                AudioChannelCount = 2,
                EnableSeparateRecognitionPerChannel = true,
                EnableWordTimeOffsets = true
            };
            double minConfidence = 0.7; // Set the minimum confidence threshold
            var timedTranscripts = new List<Tuple<string, double>>();
            double chunkStartTime = 0;

            foreach (var audioFilePath in audioFilePaths)
            {
                var audioBytes = File.ReadAllBytes(audioFilePath);
                var audio = RecognitionAudio.FromBytes(audioBytes);

                var response = await speechClient.RecognizeAsync(config, audio);

                foreach (var result in response.Results)
                {
                    var bestAlternative = result.Alternatives.FirstOrDefault();
                    if (bestAlternative != null && bestAlternative.Confidence >= minConfidence) // Check if the confidence is above the threshold
                    {
                        var startTime = bestAlternative.Words[0].StartTime.ToTimeSpan().TotalSeconds;
                        timedTranscripts.Add(Tuple.Create(bestAlternative.Transcript, startTime + chunkStartTime));
                    }
                }

                chunkStartTime += 10;

            }
            return timedTranscripts;
        }

        private string TranslateTextWithGoogle(string text, string targetLanguage, string apiKey)
        {
            TranslationClient client = TranslationClient.CreateFromApiKey(apiKey);
            var response = client.TranslateText(text, targetLanguage, "en");
            return response.TranslatedText;
        }

        private void SplitWavFile(string inputFilePath, string outputDirectory, TimeSpan chunkDuration)
        {
            using (WaveFileReader reader = new WaveFileReader(inputFilePath))
            {
                int bytesPerChunk = (int)(reader.WaveFormat.AverageBytesPerSecond * chunkDuration.TotalSeconds);
                byte[] buffer = new byte[bytesPerChunk];

                int bytesRead;
                int chunkIndex = 0;
                while ((bytesRead = reader.Read(buffer, 0, bytesPerChunk)) > 0)
                {
                    string outputFilePath = Path.Combine(outputDirectory, $"chunk_{chunkIndex}.wav");
                    using (WaveFileWriter writer = new WaveFileWriter(outputFilePath, reader.WaveFormat))
                    {
                        writer.Write(buffer, 0, bytesRead);
                    }
                    chunkIndex++;
                }
            }
        }

        private async void SubtitleUpdateTimer_Tick(object sender, EventArgs e)
        {
            double videoPosition = _vlcControl.Time / 1000.0; 

            foreach (var timedTranscript in timedTranscripts)
            {
                var transcript = timedTranscript.Item1;
                var startTime = timedTranscript.Item2;

                if (Math.Abs(videoPosition - startTime) < 1.0) 
                {
                    if (transcript != _lastDisplayedTranscript) 
                    {
                        originalTextBox.AppendText(transcript + Environment.NewLine);

                        var translatedText = TranslateTextWithGoogle(transcript, "uk", "AIzaSyDaNtymMf5TS4dBPL9t2sWxOfHVBXoi14s");
                        translateTextBox.AppendText(translatedText + Environment.NewLine);
                        _lastDisplayedTranscript = transcript; 
                    }

                    timedTranscripts.Remove(timedTranscript);
                    break;
                }
            }
        }
       
    }
        
}