using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech.AudioFormat;
using System.Threading;

namespace MyCourseWork
{
    public partial class SpeechToText : Form
    {

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        PromptBuilder promptBuilder = new PromptBuilder();
        SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
        Choices choices = new Choices();

        public SpeechToText()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            choices.Add(new string[] { "Hallo", "Hello", "Привіт", "Привет", "Hi" });
            Grammar grammar = new Grammar(new GrammarBuilder(choices));
            try
            {
                speechRecognitionEngine.RequestRecognizerUpdate();
                speechRecognitionEngine.LoadGrammar(grammar);
                speechRecognitionEngine.SpeechRecognized += speechRecognitionEngine_SpeechRecognized;
                speechRecognitionEngine.SetInputToDefaultAudioDevice();
                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void speechRecognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            TranslateText.Text = TranslateText.Text + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            speechRecognitionEngine.RecognizeAsyncStop();
            StartButton.Enabled = true;
             StopButton.Enabled= false;
        }
    }
}
