namespace WindowsFormsApplication1.Forms
{
    partial class FormGoodsInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.货物编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.渠道商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发往区域 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.运费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAreaSlecet = new System.Windows.Forms.Button();
            this.btnVendorSelect = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.textVendor = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "渠道商名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "发往区域";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "重量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "货物编号";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(361, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 20);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 22);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(361, 122);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(86, 24);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.货物编号,
            this.渠道商,
            this.发往区域,
            this.重量,
            this.运费});
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(507, 178);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 货物编号
            // 
            this.货物编号.HeaderText = "货物编号";
            this.货物编号.Name = "货物编号";
            // 
            // 渠道商
            // 
            this.渠道商.HeaderText = "渠道商";
            this.渠道商.Name = "渠道商";
            // 
            // 发往区域
            // 
            this.发往区域.HeaderText = "区域ID";
            this.发往区域.Name = "发往区域";
            // 
            // 重量
            // 
            this.重量.HeaderText = "重量";
            this.重量.Name = "重量";
            // 
            // 运费
            // 
            this.运费.HeaderText = "运费";
            this.运费.Name = "运费";
            // 
            // btnAreaSlecet
            // 
            this.btnAreaSlecet.Location = new System.Drawing.Point(273, 82);
            this.btnAreaSlecet.Name = "btnAreaSlecet";
            this.btnAreaSlecet.Size = new System.Drawing.Size(52, 21);
            this.btnAreaSlecet.TabIndex = 14;
            this.btnAreaSlecet.Text = "...";
            this.btnAreaSlecet.UseVisualStyleBackColor = true;
            this.btnAreaSlecet.Click += new System.EventHandler(this.btnAreaSlecet_Click);
            // 
            // btnVendorSelect
            // 
            this.btnVendorSelect.Location = new System.Drawing.Point(273, 46);
            this.btnVendorSelect.Name = "btnVendorSelect";
            this.btnVendorSelect.Size = new System.Drawing.Size(52, 21);
            this.btnVendorSelect.TabIndex = 15;
            this.btnVendorSelect.Text = "...";
            this.btnVendorSelect.UseVisualStyleBackColor = true;
            this.btnVendorSelect.Click += new System.EventHandler(this.btnVendorSelect_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(175, 83);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(99, 21);
            this.textArea.TabIndex = 16;
            // 
            // textVendor
            // 
            this.textVendor.Location = new System.Drawing.Point(175, 46);
            this.textVendor.Name = "textVendor";
            this.textVendor.Size = new System.Drawing.Size(99, 21);
            this.textVendor.TabIndex = 17;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(175, 116);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(148, 21);
            this.textWeight.TabIndex = 18;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(175, 12);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(148, 21);
            this.textID.TabIndex = 19;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(175, 152);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(148, 21);
            this.textPrice.TabIndex = 20;
            // 
            // FormGoodsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 377);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textVendor);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.btnVendorSelect);
            this.Controls.Add(this.btnAreaSlecet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGoodsInfo";
            this.Text = "货物信息修改";
            this.Load += new System.EventHandler(this.FormGoodsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAreaSlecet;
        private System.Windows.Forms.Button btnVendorSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 渠道商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发往区域;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 运费;
        private System.Windows.Forms.TextBox textWeight;
        public System.Windows.Forms.TextBox textArea;
        public System.Windows.Forms.TextBox textVendor;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPrice;
    }
}