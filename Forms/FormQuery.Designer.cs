namespace WindowsFormsApplication1.Forms
{
    partial class FormQuery
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
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.btnAreaSlecet = new System.Windows.Forms.Button();
            this.bntSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.渠道商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.运费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textShowPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "货物重量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "发往区域名称";
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(161, 22);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(130, 21);
            this.textWeight.TabIndex = 2;
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(161, 59);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(92, 21);
            this.textArea.TabIndex = 3;
            // 
            // btnAreaSlecet
            // 
            this.btnAreaSlecet.Location = new System.Drawing.Point(251, 58);
            this.btnAreaSlecet.Name = "btnAreaSlecet";
            this.btnAreaSlecet.Size = new System.Drawing.Size(44, 21);
            this.btnAreaSlecet.TabIndex = 4;
            this.btnAreaSlecet.Text = "...";
            this.btnAreaSlecet.UseVisualStyleBackColor = true;
            this.btnAreaSlecet.Click += new System.EventHandler(this.btnAreaSlecet_Click);
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(360, 25);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(72, 43);
            this.bntSearch.TabIndex = 5;
            this.bntSearch.Text = "查询";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.渠道商,
            this.运费});
            this.dataGridView1.Location = new System.Drawing.Point(46, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(245, 164);
            this.dataGridView1.TabIndex = 6;
            // 
            // 渠道商
            // 
            this.渠道商.HeaderText = "渠道商";
            this.渠道商.Name = "渠道商";
            // 
            // 运费
            // 
            this.运费.HeaderText = "运费";
            this.运费.Name = "运费";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "运费最少的渠道商";
            // 
            // textShowPrice
            // 
            this.textShowPrice.Location = new System.Drawing.Point(320, 185);
            this.textShowPrice.Name = "textShowPrice";
            this.textShowPrice.ReadOnly = true;
            this.textShowPrice.Size = new System.Drawing.Size(98, 21);
            this.textShowPrice.TabIndex = 8;
            // 
            // FormQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 297);
            this.Controls.Add(this.textShowPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.btnAreaSlecet);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQuery";
            this.Text = "货物运费查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.Button btnAreaSlecet;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 渠道商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 运费;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textShowPrice;
        public System.Windows.Forms.TextBox textArea;
    }
}