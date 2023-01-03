namespace CCSimplifier
{
    partial class Simplifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simplifier));
            this.Cancel = new System.Windows.Forms.Button();
            this.Simplified = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.OpenExecute = new System.Windows.Forms.OpenFileDialog();
            this.AppName = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.ProgressText = new System.Windows.Forms.Label();
            this.ProgressPercent = new System.Windows.Forms.Label();
            this.Deleted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MoreInfo = new System.Windows.Forms.ListBox();
            this.ShowHideInfo = new System.Windows.Forms.Button();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(553, 396);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 33);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "完成";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Simplified
            // 
            this.Simplified.Location = new System.Drawing.Point(450, 396);
            this.Simplified.Name = "Simplified";
            this.Simplified.Size = new System.Drawing.Size(97, 33);
            this.Simplified.TabIndex = 5;
            this.Simplified.Text = "精简";
            this.Simplified.UseVisualStyleBackColor = true;
            this.Simplified.Click += new System.EventHandler(this.Simplified_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "路径：";
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(87, 95);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(504, 30);
            this.PathBox.TabIndex = 8;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(597, 95);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(53, 31);
            this.Browse.TabIndex = 9;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // OpenExecute
            // 
            this.OpenExecute.Filter = "Adobe应用程序(*.exe)|*.exe";
            this.OpenExecute.ShowReadOnly = true;
            this.OpenExecute.Title = "选择可执行文件";
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Location = new System.Drawing.Point(48, 63);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(0, 20);
            this.AppName.TabIndex = 11;
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(19, 176);
            this.Progress.Maximum = 2048;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(579, 23);
            this.Progress.TabIndex = 12;
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Location = new System.Drawing.Point(15, 153);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(89, 20);
            this.ProgressText.TabIndex = 13;
            this.ProgressText.Text = "准备精简";
            // 
            // ProgressPercent
            // 
            this.ProgressPercent.AutoSize = true;
            this.ProgressPercent.Location = new System.Drawing.Point(604, 176);
            this.ProgressPercent.Name = "ProgressPercent";
            this.ProgressPercent.Size = new System.Drawing.Size(29, 20);
            this.ProgressPercent.TabIndex = 14;
            this.ProgressPercent.Text = "0%";
            // 
            // Deleted
            // 
            this.Deleted.AutoSize = true;
            this.Deleted.Location = new System.Drawing.Point(441, 153);
            this.Deleted.Name = "Deleted";
            this.Deleted.Size = new System.Drawing.Size(99, 20);
            this.Deleted.TabIndex = 15;
            this.Deleted.Text = "已精简0MB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "详细信息：";
            // 
            // MoreInfo
            // 
            this.MoreInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreInfo.FormattingEnabled = true;
            this.MoreInfo.HorizontalScrollbar = true;
            this.MoreInfo.ItemHeight = 18;
            this.MoreInfo.Location = new System.Drawing.Point(17, 242);
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MoreInfo.Size = new System.Drawing.Size(633, 148);
            this.MoreInfo.TabIndex = 17;
            // 
            // ShowHideInfo
            // 
            this.ShowHideInfo.Location = new System.Drawing.Point(117, 205);
            this.ShowHideInfo.Name = "ShowHideInfo";
            this.ShowHideInfo.Size = new System.Drawing.Size(110, 31);
            this.ShowHideInfo.TabIndex = 18;
            this.ShowHideInfo.Text = "显示/隐藏 ";
            this.ShowHideInfo.UseVisualStyleBackColor = true;
            this.ShowHideInfo.Click += new System.EventHandler(this.ShowHideInfo_Click);
            // 
            // AppIcon
            // 
            this.AppIcon.Location = new System.Drawing.Point(12, 56);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(32, 32);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppIcon.TabIndex = 10;
            this.AppIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Simplifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(662, 441);
            this.Controls.Add(this.ShowHideInfo);
            this.Controls.Add(this.MoreInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Deleted);
            this.Controls.Add(this.ProgressPercent);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.AppIcon);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Simplified);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Simplifier";
            this.Text = "CCSimplifier";
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Simplified;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.OpenFileDialog OpenExecute;
        private System.Windows.Forms.PictureBox AppIcon;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.Label ProgressPercent;
        private System.Windows.Forms.Label Deleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox MoreInfo;
        private System.Windows.Forms.Button ShowHideInfo;

    }
}