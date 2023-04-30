
namespace ytDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgWorkerGetVideo = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Downloader_BackProcess = new System.ComponentModel.BackgroundWorker();
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dataprogress = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grbVideoDetails = new System.Windows.Forms.GroupBox();
            this.continueButton = new Guna.UI2.WinForms.Guna2Button();
            this.btnDownload = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblAudio = new System.Windows.Forms.Label();
            this.cmbAudioQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.cmbQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.txtUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.statusStrip1.SuspendLayout();
            this.grbVideoDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgWorkerGetVideo
            // 
            this.bgWorkerGetVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerGetVideo_DoWork);
            // 
            // Downloader_BackProcess
            // 
            this.Downloader_BackProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Downloader_BackProcess_DoWork);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(1, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.miniToolStrip.Size = new System.Drawing.Size(1029, 22);
            this.miniToolStrip.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status,
            this.Dataprogress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 16);
            // 
            // Dataprogress
            // 
            this.Dataprogress.Name = "Dataprogress";
            this.Dataprogress.Size = new System.Drawing.Size(0, 16);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 448);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1024, 50);
            this.progressBar1.TabIndex = 3;
            // 
            // grbVideoDetails
            // 
            this.grbVideoDetails.Controls.Add(this.continueButton);
            this.grbVideoDetails.Controls.Add(this.btnDownload);
            this.grbVideoDetails.Controls.Add(this.btnBrowse);
            this.grbVideoDetails.Controls.Add(this.txtFilePath);
            this.grbVideoDetails.Controls.Add(this.lblPath);
            this.grbVideoDetails.Controls.Add(this.lblAudio);
            this.grbVideoDetails.Controls.Add(this.cmbAudioQuality);
            this.grbVideoDetails.Controls.Add(this.lblVideo);
            this.grbVideoDetails.Controls.Add(this.cmbQuality);
            this.grbVideoDetails.Controls.Add(this.txtTitle);
            this.grbVideoDetails.Controls.Add(this.lblTitle);
            this.grbVideoDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.grbVideoDetails.Location = new System.Drawing.Point(0, 134);
            this.grbVideoDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grbVideoDetails.Name = "grbVideoDetails";
            this.grbVideoDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grbVideoDetails.Size = new System.Drawing.Size(1040, 306);
            this.grbVideoDetails.TabIndex = 2;
            this.grbVideoDetails.TabStop = false;
            this.grbVideoDetails.Text = "Video Details";
            // 
            // continueButton
            // 
            this.continueButton.BorderRadius = 20;
            this.continueButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.continueButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.continueButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.continueButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.continueButton.FillColor = System.Drawing.Color.Red;
            this.continueButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(838, 228);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueButton.Name = "continueButton";
            this.continueButton.PressedColor = System.Drawing.Color.IndianRed;
            this.continueButton.Size = new System.Drawing.Size(184, 55);
            this.continueButton.TabIndex = 11;
            this.continueButton.Text = "Continue";
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BorderRadius = 20;
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.FillColor = System.Drawing.Color.Red;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(439, 228);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.PressedColor = System.Drawing.Color.HotPink;
            this.btnDownload.Size = new System.Drawing.Size(184, 55);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Location = new System.Drawing.Point(937, 158);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(45, 42);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BorderRadius = 15;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.DefaultText = "";
            this.txtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.FillColor = System.Drawing.Color.LightSteelBlue;
            this.txtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.Location = new System.Drawing.Point(102, 156);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.PlaceholderText = "";
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(813, 44);
            this.txtFilePath.TabIndex = 7;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(13, 168);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(72, 20);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Save to";
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudio.Location = new System.Drawing.Point(556, 102);
            this.lblAudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(121, 20);
            this.lblAudio.TabIndex = 5;
            this.lblAudio.Text = "Audio Quality";
            // 
            // cmbAudioQuality
            // 
            this.cmbAudioQuality.BackColor = System.Drawing.Color.Transparent;
            this.cmbAudioQuality.BorderRadius = 15;
            this.cmbAudioQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAudioQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioQuality.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbAudioQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAudioQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAudioQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAudioQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAudioQuality.ItemHeight = 30;
            this.cmbAudioQuality.Location = new System.Drawing.Point(696, 86);
            this.cmbAudioQuality.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAudioQuality.Name = "cmbAudioQuality";
            this.cmbAudioQuality.Size = new System.Drawing.Size(185, 36);
            this.cmbAudioQuality.TabIndex = 4;
            this.cmbAudioQuality.SelectedIndexChanged += new System.EventHandler(this.cmbAudioQuality_SelectedIndexChanged);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(147, 102);
            this.lblVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(121, 20);
            this.lblVideo.TabIndex = 3;
            this.lblVideo.Text = "Video Quality";
            // 
            // cmbQuality
            // 
            this.cmbQuality.BackColor = System.Drawing.Color.Transparent;
            this.cmbQuality.BorderRadius = 15;
            this.cmbQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbQuality.ItemHeight = 30;
            this.cmbQuality.Location = new System.Drawing.Point(289, 86);
            this.cmbQuality.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(185, 36);
            this.cmbQuality.TabIndex = 2;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 15;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FillColor = System.Drawing.Color.LightSteelBlue;
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(81, 25);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(881, 44);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 37);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 20;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.Red;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(439, 71);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.PressedColor = System.Drawing.SystemColors.InfoText;
            this.btnStart.Size = new System.Drawing.Size(184, 55);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BorderRadius = 15;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.DefaultText = "Enter video link";
            this.txtUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.FillColor = System.Drawing.Color.LightBlue;
            this.txtUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.Location = new System.Drawing.Point(14, 17);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.PlaceholderText = "";
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionStart = 16;
            this.txtUrl.Size = new System.Drawing.Size(968, 44);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.txtUrl.Enter += new System.EventHandler(this.txtUrl_Enter);
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1039, 569);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grbVideoDetails);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUrl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Youtube Video Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbVideoDetails.ResumeLayout(false);
            this.grbVideoDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgWorkerGetVideo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker Downloader_BackProcess;
        private System.Windows.Forms.StatusStrip miniToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripStatusLabel Dataprogress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grbVideoDetails;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private System.Windows.Forms.Button btnBrowse;
        private Guna.UI2.WinForms.Guna2TextBox txtFilePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblAudio;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAudioQuality;
        private System.Windows.Forms.Label lblVideo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuality;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2TextBox txtUrl;
        private Guna.UI2.WinForms.Guna2Button continueButton;
    }
}



