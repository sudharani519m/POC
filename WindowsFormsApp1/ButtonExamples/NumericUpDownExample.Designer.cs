namespace ButtonExamples
{
    partial class NumericUpDownExample
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
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.txtMyText = new System.Windows.Forms.TextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.domFont = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(273, 238);
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 20);
            this.numSize.TabIndex = 0;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // txtMyText
            // 
            this.txtMyText.Location = new System.Drawing.Point(237, 119);
            this.txtMyText.Name = "txtMyText";
            this.txtMyText.Size = new System.Drawing.Size(182, 20);
            this.txtMyText.TabIndex = 1;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(199, 187);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(36, 16);
            this.lblFont.TabIndex = 2;
            this.lblFont.Text = "Font:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(186, 238);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 20);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // domFont
            // 
            this.domFont.Items.Add("Times New Roman");
            this.domFont.Items.Add("Tahoma");
            this.domFont.Items.Add("Arial");
            this.domFont.Items.Add("Arial Black");
            this.domFont.Items.Add("Century gothic");
            this.domFont.Items.Add("Trebuchet Ms");
            this.domFont.Items.Add("Palatino Linotype");
            this.domFont.Location = new System.Drawing.Point(273, 183);
            this.domFont.Name = "domFont";
            this.domFont.Size = new System.Drawing.Size(171, 20);
            this.domFont.TabIndex = 4;
            this.domFont.Text = "Tahoma";
            this.domFont.SelectedItemChanged += new System.EventHandler(this.domFont_SelectedItemChanged);
            // 
            // NumericUpDownExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 429);
            this.Controls.Add(this.domFont);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.txtMyText);
            this.Controls.Add(this.numSize);
            this.Name = "NumericUpDownExample";
            this.Text = "NumericUpDownExample";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.TextBox txtMyText;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.DomainUpDown domFont;
    }
}