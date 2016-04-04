namespace Prog2
{
    partial class EditAddress
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
            this.cboSelectAddress = new System.Windows.Forms.ComboBox();
            this.txtEditA1 = new System.Windows.Forms.TextBox();
            this.txtEditA2 = new System.Windows.Forms.TextBox();
            this.txtEditZip = new System.Windows.Forms.TextBox();
            this.txtEditCity = new System.Windows.Forms.TextBox();
            this.cboEditState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSelectAddress
            // 
            this.cboSelectAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectAddress.FormattingEnabled = true;
            this.cboSelectAddress.Location = new System.Drawing.Point(100, 12);
            this.cboSelectAddress.Name = "cboSelectAddress";
            this.cboSelectAddress.Size = new System.Drawing.Size(143, 21);
            this.cboSelectAddress.TabIndex = 0;
            this.cboSelectAddress.SelectedIndexChanged += new System.EventHandler(this.cboSelectAddress_SelectedIndexChanged);
            // 
            // txtEditA1
            // 
            this.txtEditA1.Location = new System.Drawing.Point(143, 85);
            this.txtEditA1.Name = "txtEditA1";
            this.txtEditA1.Size = new System.Drawing.Size(100, 20);
            this.txtEditA1.TabIndex = 1;
            this.txtEditA1.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditA1_Validating);
            this.txtEditA1.Validated += new System.EventHandler(this.txtEditA1_Validated);
            // 
            // txtEditA2
            // 
            this.txtEditA2.Location = new System.Drawing.Point(143, 123);
            this.txtEditA2.Name = "txtEditA2";
            this.txtEditA2.Size = new System.Drawing.Size(100, 20);
            this.txtEditA2.TabIndex = 2;
            // 
            // txtEditZip
            // 
            this.txtEditZip.Location = new System.Drawing.Point(143, 248);
            this.txtEditZip.Name = "txtEditZip";
            this.txtEditZip.Size = new System.Drawing.Size(100, 20);
            this.txtEditZip.TabIndex = 3;
            this.txtEditZip.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditZip_Validating);
            this.txtEditZip.Validated += new System.EventHandler(this.txtEditZip_Validated);
            // 
            // txtEditCity
            // 
            this.txtEditCity.Location = new System.Drawing.Point(143, 162);
            this.txtEditCity.Name = "txtEditCity";
            this.txtEditCity.Size = new System.Drawing.Size(100, 20);
            this.txtEditCity.TabIndex = 4;
            this.txtEditCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditCity_Validating);
            this.txtEditCity.Validated += new System.EventHandler(this.txtEditCity_Validated);
            // 
            // cboEditState
            // 
            this.cboEditState.FormattingEnabled = true;
            this.cboEditState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HA",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "ND",
            "NM",
            "NY",
            "NC",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboEditState.Location = new System.Drawing.Point(143, 204);
            this.cboEditState.Name = "cboEditState";
            this.cboEditState.Size = new System.Drawing.Size(100, 21);
            this.cboEditState.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address Line 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address Line 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Zipcode:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(22, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(143, 50);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(100, 20);
            this.txtEditName.TabIndex = 14;
            this.txtEditName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditName_Validating);
            this.txtEditName.Validated += new System.EventHandler(this.txtEditName_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 367);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEditState);
            this.Controls.Add(this.txtEditCity);
            this.Controls.Add(this.txtEditZip);
            this.Controls.Add(this.txtEditA2);
            this.Controls.Add(this.txtEditA1);
            this.Controls.Add(this.cboSelectAddress);
            this.Name = "EditAddress";
            this.Text = "EditAddress";
            this.Load += new System.EventHandler(this.EditAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectAddress;
        private System.Windows.Forms.TextBox txtEditA1;
        private System.Windows.Forms.TextBox txtEditA2;
        private System.Windows.Forms.TextBox txtEditZip;
        private System.Windows.Forms.TextBox txtEditCity;
        private System.Windows.Forms.ComboBox cboEditState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}