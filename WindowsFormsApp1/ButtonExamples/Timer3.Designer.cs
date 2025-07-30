namespace ButtonExamples
{
    partial class Timer3
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
            this.tmrBackColor = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrBackColor
            // 
            this.tmrBackColor.Enabled = true;
            this.tmrBackColor.Interval = 500;
            this.tmrBackColor.Tick += new System.EventHandler(this.tmrBackColor_Tick);
            // 
            // Timer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Timer3";
            this.Text = "Timer3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrBackColor;
    }
}