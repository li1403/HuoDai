namespace WindowsFormsApplication1.Forms
{
    partial class FormExtraInfo
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVendorSelect = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.渠道商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价目名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textValue = new System.Windows.Forms.TextBox();
            this.textVendor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(291, 122);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(86, 24);
            this.btnChange.TabIndex = 15;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 22);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 20);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "渠道商";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "价目名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "类型";
            // 
            // btnVendorSelect
            // 
            this.btnVendorSelect.Location = new System.Drawing.Point(213, 24);
            this.btnVendorSelect.Name = "btnVendorSelect";
            this.btnVendorSelect.Size = new System.Drawing.Size(52, 21);
            this.btnVendorSelect.TabIndex = 22;
            this.btnVendorSelect.Text = "...";
            this.btnVendorSelect.UseVisualStyleBackColor = true;
            this.btnVendorSelect.Click += new System.EventHandler(this.btnVendorSelect_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(115, 66);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(150, 21);
            this.textName.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "折扣",
            "每单固定费用",
            "每单比例费用"});
            this.comboBox1.Location = new System.Drawing.Point(115, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 20);
            this.comboBox1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.渠道商,
            this.价目名,
            this.类型,
            this.数值});
            this.dataGridView1.Location = new System.Drawing.Point(7, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(443, 161);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 渠道商
            // 
            this.渠道商.HeaderText = "渠道商";
            this.渠道商.Name = "渠道商";
            // 
            // 价目名
            // 
            this.价目名.HeaderText = "价目名";
            this.价目名.Name = "价目名";
            // 
            // 类型
            // 
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            // 
            // 数值
            // 
            this.数值.HeaderText = "数值";
            this.数值.Name = "数值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "数值";
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(115, 144);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(99, 21);
            this.textValue.TabIndex = 27;
            // 
            // textVendor
            // 
            this.textVendor.Location = new System.Drawing.Point(115, 24);
            this.textVendor.Name = "textVendor";
            this.textVendor.Size = new System.Drawing.Size(99, 21);
            this.textVendor.TabIndex = 28;
            // 
            // FormExtraInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 382);
            this.Controls.Add(this.textVendor);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnVendorSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormExtraInfo";
            this.Text = "额外价目信息修改";
            this.Load += new System.EventHandler(this.FormExtraInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVendorSelect;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 渠道商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价目名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数值;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textValue;
        public System.Windows.Forms.TextBox textVendor;
    }
}