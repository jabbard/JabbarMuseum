namespace JabbarMuseum
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
            this.labelMuseumName = new System.Windows.Forms.Label();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.radBtnMale = new System.Windows.Forms.RadioButton();
            this.radBtnFemale = new System.Windows.Forms.RadioButton();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxOccupation = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelOcupation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxData.SuspendLayout();
            this.grpBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMuseumName
            // 
            this.labelMuseumName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMuseumName.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuseumName.Location = new System.Drawing.Point(329, 22);
            this.labelMuseumName.Name = "labelMuseumName";
            this.labelMuseumName.Size = new System.Drawing.Size(350, 50);
            this.labelMuseumName.TabIndex = 0;
            this.labelMuseumName.Text = "JABBAR MUSEUM";
            this.labelMuseumName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxData.Controls.Add(this.labelGender);
            this.groupBoxData.Controls.Add(this.grpBoxGender);
            this.groupBoxData.Controls.Add(this.btnClearAll);
            this.groupBoxData.Controls.Add(this.btnSave);
            this.groupBoxData.Controls.Add(this.comboBoxOccupation);
            this.groupBoxData.Controls.Add(this.txtPhone);
            this.groupBoxData.Controls.Add(this.txtName);
            this.groupBoxData.Controls.Add(this.labelNumber);
            this.groupBoxData.Controls.Add(this.labelOcupation);
            this.groupBoxData.Controls.Add(this.labelName);
            this.groupBoxData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxData.Location = new System.Drawing.Point(123, 82);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(800, 431);
            this.groupBoxData.TabIndex = 14;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Visitor\'s data";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(111, 251);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(82, 23);
            this.labelGender.TabIndex = 28;
            this.labelGender.Text = "Gender:";
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.radBtnMale);
            this.grpBoxGender.Controls.Add(this.radBtnFemale);
            this.grpBoxGender.Location = new System.Drawing.Point(339, 227);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(280, 59);
            this.grpBoxGender.TabIndex = 27;
            this.grpBoxGender.TabStop = false;
            // 
            // radBtnMale
            // 
            this.radBtnMale.AutoSize = true;
            this.radBtnMale.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnMale.Location = new System.Drawing.Point(6, 21);
            this.radBtnMale.Name = "radBtnMale";
            this.radBtnMale.Size = new System.Drawing.Size(64, 26);
            this.radBtnMale.TabIndex = 23;
            this.radBtnMale.TabStop = true;
            this.radBtnMale.Text = "Male";
            this.radBtnMale.UseVisualStyleBackColor = true;
            // 
            // radBtnFemale
            // 
            this.radBtnFemale.AutoSize = true;
            this.radBtnFemale.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnFemale.Location = new System.Drawing.Point(170, 21);
            this.radBtnFemale.Name = "radBtnFemale";
            this.radBtnFemale.Size = new System.Drawing.Size(80, 26);
            this.radBtnFemale.TabIndex = 24;
            this.radBtnFemale.TabStop = true;
            this.radBtnFemale.Text = "Female";
            this.radBtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(413, 348);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(176, 49);
            this.btnClearAll.TabIndex = 26;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 49);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxOccupation
            // 
            this.comboBoxOccupation.FormattingEnabled = true;
            this.comboBoxOccupation.Items.AddRange(new object[] {
            "Doctor",
            "Pilot",
            "Engineer",
            "Teacher",
            "IT Professional ",
            "Accountant",
            "Athlete",
            "Politician"});
            this.comboBoxOccupation.Location = new System.Drawing.Point(339, 178);
            this.comboBoxOccupation.Name = "comboBoxOccupation";
            this.comboBoxOccupation.Size = new System.Drawing.Size(280, 31);
            this.comboBoxOccupation.TabIndex = 21;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(339, 113);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(280, 32);
            this.txtPhone.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(339, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 32);
            this.txtName.TabIndex = 18;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(111, 116);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(107, 23);
            this.labelNumber.TabIndex = 17;
            this.labelNumber.Text = "Phone No.:";
            // 
            // labelOcupation
            // 
            this.labelOcupation.AutoSize = true;
            this.labelOcupation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOcupation.Location = new System.Drawing.Point(111, 181);
            this.labelOcupation.Name = "labelOcupation";
            this.labelOcupation.Size = new System.Drawing.Size(115, 23);
            this.labelOcupation.TabIndex = 15;
            this.labelOcupation.Text = "Occupation:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(111, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 23);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 582);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.labelMuseumName);
            this.Name = "Form1";
            this.Text = "Museum";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMuseumName;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radBtnFemale;
        private System.Windows.Forms.RadioButton radBtnMale;
        private System.Windows.Forms.ComboBox comboBoxOccupation;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelOcupation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.Label labelGender;
    }
}

