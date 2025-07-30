namespace SelectionListBoxExample
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
            this.grpCities = new System.Windows.Forms.GroupBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.txtNewCity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnShowCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpCities
            // 
            this.grpCities.Location = new System.Drawing.Point(48, 27);
            this.grpCities.Name = "grpCities";
            this.grpCities.Size = new System.Drawing.Size(99, 17);
            this.grpCities.TabIndex = 0;
            this.grpCities.TabStop = false;
            this.grpCities.Text = "Cities:";
            // 
            // grpOptions
            // 
            this.grpOptions.Location = new System.Drawing.Point(265, 27);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(198, 17);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options:";
            // 
            // lstCities
            // 
            this.lstCities.FormattingEnabled = true;
            this.lstCities.Items.AddRange(new object[] {
            "Vijayawada",
            "Hyderabad",
            "Pune",
            "Delhi",
            "Bangole"});
            this.lstCities.Location = new System.Drawing.Point(59, 69);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(120, 95);
            this.lstCities.TabIndex = 2;
            // 
            // lblNewCity
            // 
            this.lblNewCity.AutoSize = true;
            this.lblNewCity.Location = new System.Drawing.Point(265, 86);
            this.lblNewCity.Name = "lblNewCity";
            this.lblNewCity.Size = new System.Drawing.Size(81, 13);
            this.lblNewCity.TabIndex = 3;
            this.lblNewCity.Text = "New City name:";
            // 
            // txtNewCity
            // 
            this.txtNewCity.Location = new System.Drawing.Point(363, 79);
            this.txtNewCity.Name = "txtNewCity";
            this.txtNewCity.Size = new System.Drawing.Size(100, 20);
            this.txtNewCity.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(435, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.Location = new System.Drawing.Point(360, 186);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(161, 23);
            this.btnRemoveCity.TabIndex = 6;
            this.btnRemoveCity.Text = "Remove Selected City";
            this.btnRemoveCity.UseVisualStyleBackColor = true;
            this.btnRemoveCity.Click += new System.EventHandler(this.btnRemoveCity_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(363, 242);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(150, 23);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnShowCount
            // 
            this.btnShowCount.Location = new System.Drawing.Point(360, 294);
            this.btnShowCount.Name = "btnShowCount";
            this.btnShowCount.Size = new System.Drawing.Size(150, 23);
            this.btnShowCount.TabIndex = 8;
            this.btnShowCount.Text = "Show Count";
            this.btnShowCount.UseVisualStyleBackColor = true;
            this.btnShowCount.Click += new System.EventHandler(this.btnShowCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowCount);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveCity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewCity);
            this.Controls.Add(this.lblNewCity);
            this.Controls.Add(this.lstCities);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCities;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Label lblNewCity;
        private System.Windows.Forms.TextBox txtNewCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveCity;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnShowCount;
    }
}

