namespace ButtonExamples
{
    partial class TrackBar
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
            this.lblFontSize = new System.Windows.Forms.Label();
            this.trkFontSize = new System.Windows.Forms.TrackBar();
            this.lblMyText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(199, 135);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(77, 20);
            this.lblFontSize.TabIndex = 0;
            this.lblFontSize.Text = "FontSize:";
            // 
            // trkFontSize
            // 
            this.trkFontSize.Location = new System.Drawing.Point(307, 123);
            this.trkFontSize.Maximum = 200;
            this.trkFontSize.Minimum = 1;
            this.trkFontSize.Name = "trkFontSize";
            this.trkFontSize.Size = new System.Drawing.Size(104, 45);
            this.trkFontSize.TabIndex = 1;
            this.trkFontSize.Value = 1;
            this.trkFontSize.Scroll += new System.EventHandler(this.trkFontSize_Scroll);
            // 
            // lblMyText
            // 
            this.lblMyText.AutoSize = true;
            this.lblMyText.Location = new System.Drawing.Point(203, 294);
            this.lblMyText.Name = "lblMyText";
            this.lblMyText.Size = new System.Drawing.Size(66, 20);
            this.lblMyText.TabIndex = 2;
            this.lblMyText.Text = "Asp.Net";
            // 
            // TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 648);
            this.Controls.Add(this.lblMyText);
            this.Controls.Add(this.trkFontSize);
            this.Controls.Add(this.lblFontSize);
            this.Name = "TrackBar";
            this.Text = "TrackBar";
            ((System.ComponentModel.ISupportInitialize)(this.trkFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.TrackBar trkFontSize;
        private System.Windows.Forms.Label lblMyText;
    }
}