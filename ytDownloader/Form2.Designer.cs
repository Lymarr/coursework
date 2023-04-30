namespace ytDownloader
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.originalTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.translateTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.videoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.startButton = new Guna.UI2.WinForms.Guna2Button();
            this.loadButton = new Guna.UI2.WinForms.Guna2Button();
            this.SubtitleUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // originalTextBox
            // 
            this.originalTextBox.AutoScroll = true;
            this.originalTextBox.BorderRadius = 20;
            this.originalTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.originalTextBox.DefaultText = "";
            this.originalTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.originalTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.originalTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.originalTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.originalTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.originalTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalTextBox.ForeColor = System.Drawing.Color.Black;
            this.originalTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.originalTextBox.Location = new System.Drawing.Point(12, 30);
            this.originalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.PasswordChar = '\0';
            this.originalTextBox.PlaceholderText = "";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.SelectedText = "";
            this.originalTextBox.Size = new System.Drawing.Size(375, 563);
            this.originalTextBox.TabIndex = 3;
            // 
            // translateTextBox
            // 
            this.translateTextBox.BorderRadius = 20;
            this.translateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.translateTextBox.DefaultText = "";
            this.translateTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.translateTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.translateTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.translateTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.translateTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.translateTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translateTextBox.ForeColor = System.Drawing.Color.Black;
            this.translateTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.translateTextBox.Location = new System.Drawing.Point(1435, 30);
            this.translateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.translateTextBox.Multiline = true;
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.PasswordChar = '\0';
            this.translateTextBox.PlaceholderText = "";
            this.translateTextBox.ReadOnly = true;
            this.translateTextBox.SelectedText = "";
            this.translateTextBox.Size = new System.Drawing.Size(375, 563);
            this.translateTextBox.TabIndex = 8;
            // 
            // videoPanel
            // 
            this.videoPanel.BorderColor = System.Drawing.Color.Black;
            this.videoPanel.Location = new System.Drawing.Point(423, 30);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(974, 563);
            this.videoPanel.TabIndex = 10;
            // 
            // startButton
            // 
            this.startButton.BorderRadius = 20;
            this.startButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startButton.FillColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(995, 721);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 65);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BorderRadius = 15;
            this.loadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loadButton.FillColor = System.Drawing.Color.Blue;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(661, 733);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(200, 53);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Load";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // SubtitleUpdateTimer
            // 
            this.SubtitleUpdateTimer.Tick += new System.EventHandler(this.SubtitleUpdateTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1822, 810);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.translateTextBox);
            this.Controls.Add(this.originalTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox originalTextBox;
        private Guna.UI2.WinForms.Guna2TextBox translateTextBox;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2Panel videoPanel;
        private Guna.UI2.WinForms.Guna2Button startButton;
        private Guna.UI2.WinForms.Guna2Button loadButton;
        private System.Windows.Forms.Timer SubtitleUpdateTimer;
    }
}