namespace Library1._1.PAL.User_Control
{
    partial class UserControlStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudent));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageReturn = new System.Windows.Forms.TabPage();
            this.comboBoxReturn = new System.Windows.Forms.ComboBox();
            this.labelReturn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.ColumnREG_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBOOK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLOAN_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRET_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageLoan = new System.Windows.Forms.TabPage();
            this.comboBoxLoan = new System.Windows.Forms.ComboBox();
            this.labelLoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewLoan = new System.Windows.Forms.DataGridView();
            this.Column1L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxLoan = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControlAddStudent = new System.Windows.Forms.TabControl();
            this.tabPageReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            this.tabPageLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoan)).BeginInit();
            this.tabControlAddStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageReturn
            // 
            this.tabPageReturn.BackColor = System.Drawing.Color.White;
            this.tabPageReturn.Controls.Add(this.comboBoxReturn);
            this.tabPageReturn.Controls.Add(this.labelReturn);
            this.tabPageReturn.Controls.Add(this.label3);
            this.tabPageReturn.Controls.Add(this.dataGridViewReturn);
            this.tabPageReturn.Controls.Add(this.panel1);
            this.tabPageReturn.Controls.Add(this.label4);
            this.tabPageReturn.Controls.Add(this.pictureBoxReturn);
            this.tabPageReturn.Controls.Add(this.label5);
            this.tabPageReturn.Location = new System.Drawing.Point(4, 4);
            this.tabPageReturn.Name = "tabPageReturn";
            this.tabPageReturn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReturn.Size = new System.Drawing.Size(934, 472);
            this.tabPageReturn.TabIndex = 4;
            this.tabPageReturn.Text = "Return Book";
            // 
            // comboBoxReturn
            // 
            this.comboBoxReturn.FormattingEnabled = true;
            this.comboBoxReturn.Location = new System.Drawing.Point(34, 72);
            this.comboBoxReturn.Name = "comboBoxReturn";
            this.comboBoxReturn.Size = new System.Drawing.Size(121, 24);
            this.comboBoxReturn.TabIndex = 22;
            this.comboBoxReturn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxReturn_SelectedIndexChanged);
            // 
            // labelReturn
            // 
            this.labelReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelReturn.Location = new System.Drawing.Point(911, 453);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(22, 16);
            this.labelReturn.TabIndex = 20;
            this.labelReturn.Text = "{?}";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(813, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Students:";
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.AllowUserToAddRows = false;
            this.dataGridViewReturn.AllowUserToDeleteRows = false;
            this.dataGridViewReturn.AllowUserToResizeColumns = false;
            this.dataGridViewReturn.AllowUserToResizeRows = false;
            this.dataGridViewReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReturn.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnREG_NUM,
            this.ColumnCLASS,
            this.ColumnLNAME,
            this.ColumnFNAME,
            this.ColumnBOOK_ID,
            this.ColumnLOAN_DATE,
            this.ColumnRET_DATE,
            this.returnButtonColumn,
            this.ColumnID});
            this.dataGridViewReturn.Location = new System.Drawing.Point(34, 131);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewReturn.ShowCellErrors = false;
            this.dataGridViewReturn.ShowEditingIcon = false;
            this.dataGridViewReturn.ShowRowErrors = false;
            this.dataGridViewReturn.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewReturn.TabIndex = 14;
            this.dataGridViewReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewReturn_CellContentClick);
            // 
            // ColumnREG_NUM
            // 
            this.ColumnREG_NUM.DataPropertyName = "REG_NUM";
            this.ColumnREG_NUM.HeaderText = "REG_NUM";
            this.ColumnREG_NUM.Name = "ColumnREG_NUM";
            this.ColumnREG_NUM.ReadOnly = true;
            // 
            // ColumnCLASS
            // 
            this.ColumnCLASS.DataPropertyName = "CLASS";
            this.ColumnCLASS.HeaderText = "CLASS";
            this.ColumnCLASS.Name = "ColumnCLASS";
            // 
            // ColumnLNAME
            // 
            this.ColumnLNAME.DataPropertyName = "LNAME";
            this.ColumnLNAME.HeaderText = "LNAME";
            this.ColumnLNAME.Name = "ColumnLNAME";
            this.ColumnLNAME.ReadOnly = true;
            // 
            // ColumnFNAME
            // 
            this.ColumnFNAME.DataPropertyName = "FNAME";
            this.ColumnFNAME.HeaderText = "FNAME";
            this.ColumnFNAME.Name = "ColumnFNAME";
            this.ColumnFNAME.ReadOnly = true;
            // 
            // ColumnBOOK_ID
            // 
            this.ColumnBOOK_ID.DataPropertyName = "BOOK_ID";
            this.ColumnBOOK_ID.HeaderText = "BOOK_ID";
            this.ColumnBOOK_ID.Name = "ColumnBOOK_ID";
            // 
            // ColumnLOAN_DATE
            // 
            this.ColumnLOAN_DATE.DataPropertyName = "LOAN_DATE";
            this.ColumnLOAN_DATE.HeaderText = "LOAN_DATE";
            this.ColumnLOAN_DATE.Name = "ColumnLOAN_DATE";
            // 
            // ColumnRET_DATE
            // 
            this.ColumnRET_DATE.DataPropertyName = "RET_DATE";
            this.ColumnRET_DATE.HeaderText = "RET_DATE";
            this.ColumnRET_DATE.Name = "ColumnRET_DATE";
            // 
            // returnButtonColumn
            // 
            this.returnButtonColumn.DataPropertyName = "RETURN";
            this.returnButtonColumn.HeaderText = "";
            this.returnButtonColumn.Name = "returnButtonColumn";
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(34, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 2);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(31, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Class:";
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReturn.Image")));
            this.pictureBoxReturn.Location = new System.Drawing.Point(161, 72);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(19, 26);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReturn.TabIndex = 19;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.MouseHover += new System.EventHandler(this.PictureBoxReturn_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Return Book:";
            // 
            // tabPageLoan
            // 
            this.tabPageLoan.BackColor = System.Drawing.Color.White;
            this.tabPageLoan.Controls.Add(this.comboBoxLoan);
            this.tabPageLoan.Controls.Add(this.labelLoan);
            this.tabPageLoan.Controls.Add(this.label2);
            this.tabPageLoan.Controls.Add(this.dataGridViewLoan);
            this.tabPageLoan.Controls.Add(this.panel10);
            this.tabPageLoan.Controls.Add(this.label9);
            this.tabPageLoan.Controls.Add(this.pictureBoxLoan);
            this.tabPageLoan.Controls.Add(this.label15);
            this.tabPageLoan.Location = new System.Drawing.Point(4, 4);
            this.tabPageLoan.Name = "tabPageLoan";
            this.tabPageLoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoan.Size = new System.Drawing.Size(934, 472);
            this.tabPageLoan.TabIndex = 3;
            this.tabPageLoan.Text = "Loan Book";
            // 
            // comboBoxLoan
            // 
            this.comboBoxLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLoan.Location = new System.Drawing.Point(34, 72);
            this.comboBoxLoan.MaximumSize = new System.Drawing.Size(121, 0);
            this.comboBoxLoan.Name = "comboBoxLoan";
            this.comboBoxLoan.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLoan.TabIndex = 23;
            this.comboBoxLoan.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLoan_SelectedIndexChanged);
            // 
            // labelLoan
            // 
            this.labelLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoan.AutoSize = true;
            this.labelLoan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelLoan.Location = new System.Drawing.Point(911, 453);
            this.labelLoan.Name = "labelLoan";
            this.labelLoan.Size = new System.Drawing.Size(22, 16);
            this.labelLoan.TabIndex = 12;
            this.labelLoan.Text = "{?}";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(813, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Students:";
            // 
            // dataGridViewLoan
            // 
            this.dataGridViewLoan.AllowUserToAddRows = false;
            this.dataGridViewLoan.AllowUserToDeleteRows = false;
            this.dataGridViewLoan.AllowUserToResizeColumns = false;
            this.dataGridViewLoan.AllowUserToResizeRows = false;
            this.dataGridViewLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1L,
            this.Column2L,
            this.Column3L,
            this.Column4L,
            this.Column5L,
            this.Column6L,
            this.LoanButtonColumn});
            this.dataGridViewLoan.Location = new System.Drawing.Point(34, 131);
            this.dataGridViewLoan.Name = "dataGridViewLoan";
            this.dataGridViewLoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLoan.ShowCellErrors = false;
            this.dataGridViewLoan.ShowEditingIcon = false;
            this.dataGridViewLoan.ShowRowErrors = false;
            this.dataGridViewLoan.Size = new System.Drawing.Size(872, 318);
            this.dataGridViewLoan.TabIndex = 6;
            this.dataGridViewLoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLoan_CellContentClick);
            // 
            // Column1L
            // 
            this.Column1L.DataPropertyName = "REG_NUM";
            this.Column1L.HeaderText = "REG_NUM";
            this.Column1L.Name = "Column1L";
            this.Column1L.ReadOnly = true;
            // 
            // Column2L
            // 
            this.Column2L.DataPropertyName = "CLASS";
            this.Column2L.HeaderText = "CLASS";
            this.Column2L.Name = "Column2L";
            // 
            // Column3L
            // 
            this.Column3L.DataPropertyName = "LNAME";
            this.Column3L.HeaderText = "LNAME";
            this.Column3L.Name = "Column3L";
            this.Column3L.ReadOnly = true;
            // 
            // Column4L
            // 
            this.Column4L.DataPropertyName = "FNAME";
            this.Column4L.HeaderText = "FNAME";
            this.Column4L.Name = "Column4L";
            this.Column4L.ReadOnly = true;
            // 
            // Column5L
            // 
            this.Column5L.DataPropertyName = "BOOK_ID";
            this.Column5L.HeaderText = "BOOK_ID";
            this.Column5L.Name = "Column5L";
            // 
            // Column6L
            // 
            this.Column6L.DataPropertyName = "LOAN_DATE";
            this.Column6L.HeaderText = "LOAN_DATE";
            this.Column6L.Name = "Column6L";
            // 
            // LoanButtonColumn
            // 
            this.LoanButtonColumn.DataPropertyName = "LOAN";
            this.LoanButtonColumn.HeaderText = "";
            this.LoanButtonColumn.Name = "LoanButtonColumn";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Location = new System.Drawing.Point(34, 99);
            this.panel10.MaximumSize = new System.Drawing.Size(145, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(145, 2);
            this.panel10.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(31, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Class:";
            // 
            // pictureBoxLoan
            // 
            this.pictureBoxLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLoan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoan.Image")));
            this.pictureBoxLoan.Location = new System.Drawing.Point(161, 72);
            this.pictureBoxLoan.Name = "pictureBoxLoan";
            this.pictureBoxLoan.Size = new System.Drawing.Size(19, 26);
            this.pictureBoxLoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoan.TabIndex = 11;
            this.pictureBoxLoan.TabStop = false;
            this.pictureBoxLoan.MouseHover += new System.EventHandler(this.PictureBoxLoan_MouseHover);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 19);
            this.label15.TabIndex = 9;
            this.label15.Text = "Loan Book:";
            // 
            // tabControlAddStudent
            // 
            this.tabControlAddStudent.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAddStudent.Controls.Add(this.tabPageLoan);
            this.tabControlAddStudent.Controls.Add(this.tabPageReturn);
            this.tabControlAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddStudent.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddStudent.Multiline = true;
            this.tabControlAddStudent.Name = "tabControlAddStudent";
            this.tabControlAddStudent.SelectedIndex = 0;
            this.tabControlAddStudent.Size = new System.Drawing.Size(942, 501);
            this.tabControlAddStudent.TabIndex = 0;
            this.tabControlAddStudent.Leave += new System.EventHandler(this.TabControlAddStudent_Leave);
            // 
            // UserControlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAddStudent);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlStudent";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabPageReturn.ResumeLayout(false);
            this.tabPageReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            this.tabPageLoan.ResumeLayout(false);
            this.tabPageLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoan)).EndInit();
            this.tabControlAddStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabPageReturn;
        private System.Windows.Forms.TabPage tabPageLoan;
        private System.Windows.Forms.DataGridView dataGridViewLoan;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxLoan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControlAddStudent;
        private System.Windows.Forms.Label labelLoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxReturn;
        private System.Windows.Forms.ComboBox comboBoxLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnREG_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBOOK_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLOAN_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRET_DATE;
        private System.Windows.Forms.DataGridViewButtonColumn returnButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6L;
        private System.Windows.Forms.DataGridViewButtonColumn LoanButtonColumn;
    }
}
