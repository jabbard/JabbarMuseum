namespace JabbarMuseum
{
    partial class DataGrid
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
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.ColnCardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnPhNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnOccupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTable
            // 
            this.dataGridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTable.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColnCardNum,
            this.ColnFullName,
            this.ColnAddress,
            this.ColnPhNum,
            this.ColnOccupation,
            this.ColnGender,
            this.ColnInTime,
            this.ColnOutTime});
            this.dataGridTable.Location = new System.Drawing.Point(12, 12);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.RowTemplate.Height = 24;
            this.dataGridTable.Size = new System.Drawing.Size(1068, 505);
            this.dataGridTable.TabIndex = 0;
            // 
            // ColnCardNum
            // 
            this.ColnCardNum.HeaderText = "Card No.";
            this.ColnCardNum.Name = "ColnCardNum";
            // 
            // ColnFullName
            // 
            this.ColnFullName.HeaderText = "Full Name";
            this.ColnFullName.Name = "ColnFullName";
            // 
            // ColnAddress
            // 
            this.ColnAddress.HeaderText = "Address";
            this.ColnAddress.Name = "ColnAddress";
            // 
            // ColnPhNum
            // 
            this.ColnPhNum.HeaderText = "Phone No.";
            this.ColnPhNum.Name = "ColnPhNum";
            // 
            // ColnOccupation
            // 
            this.ColnOccupation.HeaderText = "Occupation";
            this.ColnOccupation.Name = "ColnOccupation";
            // 
            // ColnGender
            // 
            this.ColnGender.HeaderText = "Gender";
            this.ColnGender.Name = "ColnGender";
            // 
            // ColnInTime
            // 
            this.ColnInTime.HeaderText = "InTime";
            this.ColnInTime.Name = "ColnInTime";
            // 
            // ColnOutTime
            // 
            this.ColnOutTime.HeaderText = "Out Time";
            this.ColnOutTime.Name = "ColnOutTime";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExport.Location = new System.Drawing.Point(918, 538);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(162, 34);
            this.btnExport.TabIndex = 27;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnImport.Location = new System.Drawing.Point(712, 538);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(151, 34);
            this.btnImport.TabIndex = 28;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegister.Location = new System.Drawing.Point(503, 538);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(151, 34);
            this.btnRegister.TabIndex = 29;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 588);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridTable);
            this.Name = "DataGrid";
            this.Text = "DataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnCardNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnPhNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnOccupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnOutTime;
        private System.Windows.Forms.Button btnRegister;
    }
}