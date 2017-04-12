namespace TTS_Demo
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
            this.languagesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listenTTSButton = new System.Windows.Forms.Button();
            this.stopTTSButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languagesList
            // 
            this.languagesList.FormattingEnabled = true;
            this.languagesList.Location = new System.Drawing.Point(63, 49);
            this.languagesList.Name = "languagesList";
            this.languagesList.Size = new System.Drawing.Size(709, 121);
            this.languagesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Languages and Voices";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(63, 206);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(709, 113);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type text for doing TTS";
            // 
            // listenTTSButton
            // 
            this.listenTTSButton.Location = new System.Drawing.Point(63, 325);
            this.listenTTSButton.Name = "listenTTSButton";
            this.listenTTSButton.Size = new System.Drawing.Size(75, 23);
            this.listenTTSButton.TabIndex = 4;
            this.listenTTSButton.Text = "Listen TTS";
            this.listenTTSButton.UseVisualStyleBackColor = true;
            this.listenTTSButton.Click += new System.EventHandler(this.listenTTSButton_Click);
            // 
            // stopTTSButton
            // 
            this.stopTTSButton.Location = new System.Drawing.Point(147, 325);
            this.stopTTSButton.Name = "stopTTSButton";
            this.stopTTSButton.Size = new System.Drawing.Size(75, 23);
            this.stopTTSButton.TabIndex = 5;
            this.stopTTSButton.Text = "Stop";
            this.stopTTSButton.UseVisualStyleBackColor = true;
            this.stopTTSButton.Click += new System.EventHandler(this.stopTTSButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.stopTTSButton);
            this.Controls.Add(this.listenTTSButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languagesList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox languagesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button listenTTSButton;
        private System.Windows.Forms.Button stopTTSButton;
    }
}

