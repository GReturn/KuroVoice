
namespace KuroVoice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(259, 61);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(68, 55);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(259, 122);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(68, 55);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(13, 12);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxInput.Size = new System.Drawing.Size(240, 164);
            this.richTextBoxInput.TabIndex = 6;
            this.richTextBoxInput.Text = "Input Log";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(333, 13);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxOutput.Size = new System.Drawing.Size(240, 164);
            this.richTextBoxOutput.TabIndex = 7;
            this.richTextBoxOutput.Text = "Output Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 226);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Birthday";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
    }
}

