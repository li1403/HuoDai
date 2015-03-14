namespace WindowsFormsApplication1.Forms
{
    partial class FormMain
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnGoodModify = new System.Windows.Forms.Button();
            this.btnExtraModify = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.Location = new System.Drawing.Point(104, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "运费查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Visible = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(104, 77);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyse.TabIndex = 1;
            this.btnAnalyse.Text = "价格分析";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Visible = false;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnGoodModify
            // 
            this.btnGoodModify.Location = new System.Drawing.Point(104, 127);
            this.btnGoodModify.Name = "btnGoodModify";
            this.btnGoodModify.Size = new System.Drawing.Size(75, 23);
            this.btnGoodModify.TabIndex = 2;
            this.btnGoodModify.Text = "货物表修改";
            this.btnGoodModify.UseVisualStyleBackColor = true;
            this.btnGoodModify.Visible = false;
            this.btnGoodModify.Click += new System.EventHandler(this.btnGoodModify_Click);
            // 
            // btnExtraModify
            // 
            this.btnExtraModify.Location = new System.Drawing.Point(92, 181);
            this.btnExtraModify.Name = "btnExtraModify";
            this.btnExtraModify.Size = new System.Drawing.Size(98, 23);
            this.btnExtraModify.TabIndex = 3;
            this.btnExtraModify.Text = "额外价目表修改";
            this.btnExtraModify.UseVisualStyleBackColor = true;
            this.btnExtraModify.Visible = false;
            this.btnExtraModify.Click += new System.EventHandler(this.btnExtraModify_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.btnGood2;
            this.pictureBox4.Location = new System.Drawing.Point(157, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.btnExtra;
            this.pictureBox3.Location = new System.Drawing.Point(26, 137);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.btnAnalyse;
            this.pictureBox2.Location = new System.Drawing.Point(157, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.btnQuery1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 99);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "运费查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "货物表修改";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "额外价目表修改";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "价格分析";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExtraModify);
            this.Controls.Add(this.btnGoodModify);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.btnQuery);
            this.Name = "FormMain";
            this.Text = "邮政货代查询系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnGoodModify;
        private System.Windows.Forms.Button btnExtraModify;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}