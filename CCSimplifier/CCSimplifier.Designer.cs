namespace CCSimplifier
{
    partial class CCSimplifier
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCSimplifier));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GoSimplifier = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSimplifier)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GoSimplifier
            // 
            this.GoSimplifier.Image = ((System.Drawing.Image)(resources.GetObject("GoSimplifier.Image")));
            this.GoSimplifier.Location = new System.Drawing.Point(22, 71);
            this.GoSimplifier.Margin = new System.Windows.Forms.Padding(0);
            this.GoSimplifier.Name = "GoSimplifier";
            this.GoSimplifier.Size = new System.Drawing.Size(619, 95);
            this.GoSimplifier.TabIndex = 1;
            this.GoSimplifier.TabStop = false;
            this.GoSimplifier.MouseLeave += new System.EventHandler(this.GoSimplifier_MouseLeave);
            this.GoSimplifier.Click += new System.EventHandler(this.GoSimplifier_Click);
            this.GoSimplifier.MouseEnter += new System.EventHandler(this.GoSimplifier_MouseEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CCSimplifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(662, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoSimplifier);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CCSimplifier";
            this.Text = "CCSimplifier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSimplifier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox GoSimplifier;
        private System.Windows.Forms.Button button1;
    }
}

