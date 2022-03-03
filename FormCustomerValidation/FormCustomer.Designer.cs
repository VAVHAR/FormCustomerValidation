namespace FormCustomerValidation
{
    partial class FormCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1CstmID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhonenumber = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.ListViewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // textBox1CstmID
            // 
            this.textBox1CstmID.Location = new System.Drawing.Point(74, 70);
            this.textBox1CstmID.Name = "textBox1CstmID";
            this.textBox1CstmID.Size = new System.Drawing.Size(128, 22);
            this.textBox1CstmID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(74, 159);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(128, 22);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(74, 254);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(128, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number";
            // 
            // maskedTextBoxPhonenumber
            // 
            this.maskedTextBoxPhonenumber.Location = new System.Drawing.Point(74, 349);
            this.maskedTextBoxPhonenumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhonenumber.Name = "maskedTextBoxPhonenumber";
            this.maskedTextBoxPhonenumber.Size = new System.Drawing.Size(128, 22);
            this.maskedTextBoxPhonenumber.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(267, 70);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 37);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(267, 159);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(131, 38);
            this.buttonList.TabIndex = 9;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(691, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search By";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Customer ID",
            "First Name",
            "Last Name",
            "Phone Number"});
            this.comboBoxSearch.Location = new System.Drawing.Point(694, 83);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSearch.TabIndex = 11;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(694, 174);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(121, 43);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // ListViewData
            // 
            this.ListViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewData.HideSelection = false;
            this.ListViewData.Location = new System.Drawing.Point(74, 411);
            this.ListViewData.Name = "ListViewData";
            this.ListViewData.Size = new System.Drawing.Size(823, 173);
            this.ListViewData.TabIndex = 13;
            this.ListViewData.UseCompatibleStateImageBehavior = false;
            this.ListViewData.View = System.Windows.Forms.View.Details;
            this.ListViewData.SelectedIndexChanged += new System.EventHandler(this.ListViewData_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Customer ID";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone Number";
            this.columnHeader4.Width = 152;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 610);
            this.Controls.Add(this.ListViewData);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.maskedTextBoxPhonenumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1CstmID);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1CstmID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhonenumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListView ListViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

