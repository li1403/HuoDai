namespace WindowsFormsApplication1.Forms
{
    partial class FormAnalyse
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
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabAllInfo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.他方渠道商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.区域 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.他方运费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.我方渠道商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.我方运费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCan = new System.Windows.Forms.TabPage();
            this.textInterest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.我方渠道商2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.我方运费2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.我方折扣 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最大利润 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.利润率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCannot = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.我方渠道商3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.我方折扣3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.我方需要折扣 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAnalyse = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.渠道商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所占百分比 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPercent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.区域4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所占百分比1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabInfo.SuspendLayout();
            this.tabAllInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabCan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabCannot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabAnalyse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabAllInfo);
            this.tabInfo.Controls.Add(this.tabCan);
            this.tabInfo.Controls.Add(this.tabCannot);
            this.tabInfo.Controls.Add(this.tabAnalyse);
            this.tabInfo.Location = new System.Drawing.Point(38, 65);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(643, 300);
            this.tabInfo.TabIndex = 0;
            // 
            // tabAllInfo
            // 
            this.tabAllInfo.AccessibleName = "";
            this.tabAllInfo.Controls.Add(this.dataGridView1);
            this.tabAllInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAllInfo.Name = "tabAllInfo";
            this.tabAllInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllInfo.Size = new System.Drawing.Size(635, 274);
            this.tabAllInfo.TabIndex = 0;
            this.tabAllInfo.Text = "全部信息";
            this.tabAllInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.他方渠道商,
            this.区域,
            this.重量,
            this.他方运费,
            this.我方渠道商,
            this.我方运费});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(633, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // 他方渠道商
            // 
            this.他方渠道商.HeaderText = "他方渠道商";
            this.他方渠道商.Name = "他方渠道商";
            // 
            // 区域
            // 
            this.区域.HeaderText = "区域";
            this.区域.Name = "区域";
            // 
            // 重量
            // 
            this.重量.HeaderText = "重量";
            this.重量.Name = "重量";
            // 
            // 他方运费
            // 
            this.他方运费.HeaderText = "他方运费";
            this.他方运费.Name = "他方运费";
            // 
            // 我方渠道商
            // 
            this.我方渠道商.HeaderText = "我方渠道商";
            this.我方渠道商.Name = "我方渠道商";
            // 
            // 我方运费
            // 
            this.我方运费.HeaderText = "我方运费";
            this.我方运费.Name = "我方运费";
            // 
            // tabCan
            // 
            this.tabCan.Controls.Add(this.textInterest);
            this.tabCan.Controls.Add(this.label3);
            this.tabCan.Controls.Add(this.dataGridView2);
            this.tabCan.Location = new System.Drawing.Point(4, 22);
            this.tabCan.Name = "tabCan";
            this.tabCan.Padding = new System.Windows.Forms.Padding(3);
            this.tabCan.Size = new System.Drawing.Size(635, 274);
            this.tabCan.TabIndex = 1;
            this.tabCan.Text = "可抢占货物";
            this.tabCan.UseVisualStyleBackColor = true;
            // 
            // textInterest
            // 
            this.textInterest.Location = new System.Drawing.Point(305, 246);
            this.textInterest.Name = "textInterest";
            this.textInterest.ReadOnly = true;
            this.textInterest.Size = new System.Drawing.Size(88, 21);
            this.textInterest.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "总利润";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.我方渠道商2,
            this.我方运费2,
            this.我方折扣,
            this.最大利润,
            this.利润率});
            this.dataGridView2.Location = new System.Drawing.Point(62, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(517, 234);
            this.dataGridView2.TabIndex = 0;
            // 
            // 我方渠道商2
            // 
            this.我方渠道商2.HeaderText = "我方渠道商";
            this.我方渠道商2.Name = "我方渠道商2";
            // 
            // 我方运费2
            // 
            this.我方运费2.HeaderText = "我方运费";
            this.我方运费2.Name = "我方运费2";
            // 
            // 我方折扣
            // 
            this.我方折扣.HeaderText = "我方折扣";
            this.我方折扣.Name = "我方折扣";
            // 
            // 最大利润
            // 
            this.最大利润.HeaderText = "最大利润";
            this.最大利润.Name = "最大利润";
            // 
            // 利润率
            // 
            this.利润率.HeaderText = "利润率";
            this.利润率.Name = "利润率";
            // 
            // tabCannot
            // 
            this.tabCannot.Controls.Add(this.dataGridView3);
            this.tabCannot.Location = new System.Drawing.Point(4, 22);
            this.tabCannot.Name = "tabCannot";
            this.tabCannot.Padding = new System.Windows.Forms.Padding(3);
            this.tabCannot.Size = new System.Drawing.Size(635, 274);
            this.tabCannot.TabIndex = 2;
            this.tabCannot.Text = "不可抢占货物";
            this.tabCannot.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.我方渠道商3,
            this.我方折扣3,
            this.我方需要折扣});
            this.dataGridView3.Location = new System.Drawing.Point(85, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(484, 234);
            this.dataGridView3.TabIndex = 0;
            // 
            // 我方渠道商3
            // 
            this.我方渠道商3.HeaderText = "我方渠道商";
            this.我方渠道商3.Name = "我方渠道商3";
            // 
            // 我方折扣3
            // 
            this.我方折扣3.HeaderText = "我方折扣";
            this.我方折扣3.Name = "我方折扣3";
            // 
            // 我方需要折扣
            // 
            this.我方需要折扣.HeaderText = "我方需要折扣";
            this.我方需要折扣.Name = "我方需要折扣";
            // 
            // tabAnalyse
            // 
            this.tabAnalyse.BackColor = System.Drawing.Color.White;
            this.tabAnalyse.Controls.Add(this.textPercent);
            this.tabAnalyse.Controls.Add(this.dataGridView5);
            this.tabAnalyse.Controls.Add(this.pictureBox3);
            this.tabAnalyse.Controls.Add(this.label2);
            this.tabAnalyse.Controls.Add(this.label1);
            this.tabAnalyse.Controls.Add(this.dataGridView4);
            this.tabAnalyse.Controls.Add(this.pictureBox4);
            this.tabAnalyse.Controls.Add(this.pictureBox5);
            this.tabAnalyse.Location = new System.Drawing.Point(4, 22);
            this.tabAnalyse.Name = "tabAnalyse";
            this.tabAnalyse.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalyse.Size = new System.Drawing.Size(635, 274);
            this.tabAnalyse.TabIndex = 3;
            this.tabAnalyse.Text = "分析";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.渠道商,
            this.所占百分比});
            this.dataGridView5.Location = new System.Drawing.Point(333, 82);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(211, 160);
            this.dataGridView5.TabIndex = 4;
            // 
            // 渠道商
            // 
            this.渠道商.HeaderText = "渠道商";
            this.渠道商.Name = "渠道商";
            // 
            // 所占百分比
            // 
            this.所占百分比.HeaderText = "所占百分比";
            this.所占百分比.Name = "所占百分比";
            // 
            // textPercent
            // 
            this.textPercent.Location = new System.Drawing.Point(320, 20);
            this.textPercent.Name = "textPercent";
            this.textPercent.ReadOnly = true;
            this.textPercent.Size = new System.Drawing.Size(114, 21);
            this.textPercent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "可抢占货物分析表";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "可抢占货物所占百分比";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.区域4,
            this.所占百分比1});
            this.dataGridView4.Location = new System.Drawing.Point(105, 82);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(214, 160);
            this.dataGridView4.TabIndex = 0;
            // 
            // 区域4
            // 
            this.区域4.HeaderText = "区域";
            this.区域4.Name = "区域4";
            // 
            // 所占百分比1
            // 
            this.所占百分比1.HeaderText = "所占百分比";
            this.所占百分比1.Name = "所占百分比1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加货物信息";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApplication1.Properties.Resources.white;
            this.pictureBox5.Location = new System.Drawing.Point(197, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(272, 279);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.D;
            this.pictureBox3.Location = new System.Drawing.Point(383, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 294);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.H;
            this.pictureBox4.Location = new System.Drawing.Point(-142, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(399, 308);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // FormAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 400);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tabInfo);
            this.Name = "FormAnalyse";
            this.Text = "价格分析";
            this.Load += new System.EventHandler(this.FormAnalyse_Load);
            this.tabInfo.ResumeLayout(false);
            this.tabAllInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabCan.ResumeLayout(false);
            this.tabCan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabCannot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabAnalyse.ResumeLayout(false);
            this.tabAnalyse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabAllInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabCan;
        private System.Windows.Forms.TabPage tabCannot;
        private System.Windows.Forms.TabPage tabAnalyse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn 他方渠道商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 区域;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 他方运费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 我方渠道商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 我方运费;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 我方渠道商3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 我方折扣3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 我方需要折扣;
        private System.Windows.Forms.TextBox textPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 渠道商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所占百分比;
        private System.Windows.Forms.DataGridViewTextBoxColumn 区域4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所占百分比1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 我方渠道商2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 我方运费2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 我方折扣;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最大利润;
        private System.Windows.Forms.DataGridViewTextBoxColumn 利润率;
        private System.Windows.Forms.TextBox textInterest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}