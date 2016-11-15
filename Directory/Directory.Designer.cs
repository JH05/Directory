namespace Directory
{
    partial class Directory
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directory));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.txtPostalAddress = new System.Windows.Forms.TextBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 443);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(259, 443);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 55);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(444, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1179, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 46);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(984, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 26);
            this.txtSearch.TabIndex = 15;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(444, 509);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(130, 56);
            this.btnQuit.TabIndex = 16;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Name",
            "Telephone Number",
            "Postal Address",
            "Email Address",
            "Birth Date"});
            this.cmbSearch.Location = new System.Drawing.Point(824, 22);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(150, 28);
            this.cmbSearch.TabIndex = 17;
            this.cmbSearch.Text = "Selection";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1166, 509);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(146, 56);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load from File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1005, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 55);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "Contacts Directory ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Postal Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Telephone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 175);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 26);
            this.txtName.TabIndex = 44;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(210, 213);
            this.txtTelephoneNumber.Mask = "000000000000";
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(190, 26);
            this.txtTelephoneNumber.TabIndex = 54;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(210, 296);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(190, 26);
            this.txtEmailAddress.TabIndex = 56;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(210, 336);
            this.txtBirthDate.Mask = "00/00/0000";
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(190, 26);
            this.txtBirthDate.TabIndex = 57;
            this.txtBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtPostalAddress
            // 
            this.txtPostalAddress.Location = new System.Drawing.Point(210, 253);
            this.txtPostalAddress.Name = "txtPostalAddress";
            this.txtPostalAddress.Size = new System.Drawing.Size(190, 26);
            this.txtPostalAddress.TabIndex = 55;
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToOrderColumns = true;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmNumber,
            this.clmEAddress,
            this.clmPAddress,
            this.clmBirthDate});
            this.dgvPerson.Location = new System.Drawing.Point(464, 64);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowTemplate.Height = 28;
            this.dgvPerson.Size = new System.Drawing.Size(845, 432);
            this.dgvPerson.TabIndex = 58;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Telephone Number";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmEAddress
            // 
            this.clmEAddress.HeaderText = "Email Address";
            this.clmEAddress.Name = "clmEAddress";
            this.clmEAddress.ReadOnly = true;
            // 
            // clmPAddress
            // 
            this.clmPAddress.HeaderText = "Postal Address";
            this.clmPAddress.Name = "clmPAddress";
            this.clmPAddress.ReadOnly = true;
            // 
            // clmBirthDate
            // 
            this.clmBirthDate.HeaderText = "Birth Date";
            this.clmBirthDate.Name = "clmBirthDate";
            this.clmBirthDate.ReadOnly = true;
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1321, 577);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtPostalAddress);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Directory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Directory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd; 
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtTelephoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.MaskedTextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtPostalAddress;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBirthDate;
    }
}

