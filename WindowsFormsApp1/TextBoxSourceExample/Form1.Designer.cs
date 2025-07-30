namespace TextBoxSourceExample
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
            this.lblSourceText = new System.Windows.Forms.Label();
            this.lblDestinationText = new System.Windows.Forms.Label();
            this.txtSourceText = new System.Windows.Forms.TextBox();
            this.txtDestinationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSourceText
            // 
            this.lblSourceText.AutoSize = true;
            this.lblSourceText.Location = new System.Drawing.Point(191, 96);
            this.lblSourceText.Name = "lblSourceText";
            this.lblSourceText.Size = new System.Drawing.Size(104, 13);
            this.lblSourceText.TabIndex = 0;
            this.lblSourceText.Text = "Enter Your text here:";
            // 
            // lblDestinationText
            // 
            this.lblDestinationText.AutoSize = true;
            this.lblDestinationText.Location = new System.Drawing.Point(191, 188);
            this.lblDestinationText.Name = "lblDestinationText";
            this.lblDestinationText.Size = new System.Drawing.Size(67, 13);
            this.lblDestinationText.TabIndex = 1;
            this.lblDestinationText.Text = "Copied Text:";
            // 
            // txtSourceText
            // 
            this.txtSourceText.Location = new System.Drawing.Point(320, 93);
            this.txtSourceText.Name = "txtSourceText";
            this.txtSourceText.Size = new System.Drawing.Size(100, 20);
            this.txtSourceText.TabIndex = 2;
            this.txtSourceText.TextChanged += new System.EventHandler(this.txtSourceText_TextChanged);
            // 
            // txtDestinationText
            // 
            this.txtDestinationText.Location = new System.Drawing.Point(320, 185);
            this.txtDestinationText.Name = "txtDestinationText";
            this.txtDestinationText.Size = new System.Drawing.Size(100, 20);
            this.txtDestinationText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.txtDestinationText);
            this.Controls.Add(this.txtSourceText);
            this.Controls.Add(this.lblDestinationText);
            this.Controls.Add(this.lblSourceText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceText;
        private System.Windows.Forms.Label lblDestinationText;
        private System.Windows.Forms.TextBox txtSourceText;
        private System.Windows.Forms.TextBox txtDestinationText;
    }
}

