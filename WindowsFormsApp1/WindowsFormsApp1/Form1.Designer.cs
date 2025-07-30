namespace TextBoxExample
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
            this.lblGenerateNumbers = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGenerateNumbers
            // 
            this.lblGenerateNumbers.AutoSize = true;
            this.lblGenerateNumbers.BackColor = System.Drawing.SystemColors.Control;
            this.lblGenerateNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateNumbers.Location = new System.Drawing.Point(508, 116);
            this.lblGenerateNumbers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenerateNumbers.Name = "lblGenerateNumbers";
            this.lblGenerateNumbers.Size = new System.Drawing.Size(209, 25);
            this.lblGenerateNumbers.TabIndex = 0;
            this.lblGenerateNumbers.Text = "Generate Numbers";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(231, 183);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 16);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From:";
            this.lblFrom.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(602, 182);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(569, 183);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 15);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(277, 183);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 4;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(770, 182);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(47, 24);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(234, 252);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.ReadOnly = true;
            this.txtNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumbers.Size = new System.Drawing.Size(715, 269);
            this.txtNumbers.TabIndex = 6;
            this.txtNumbers.TextChanged += new System.EventHandler(this.txtNumbers_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblGenerateNumbers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenerateNumbers;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button button1;
    }
}

