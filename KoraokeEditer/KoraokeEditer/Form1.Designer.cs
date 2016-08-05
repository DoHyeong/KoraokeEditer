namespace KoraokeEditer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.songTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nowSongPosition = new System.Windows.Forms.Label();
            this.progressNow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressMax = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.songTitle);
            this.groupBox1.Location = new System.Drawing.Point(29, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1393, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1166, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // songTitle
            // 
            this.songTitle.AutoSize = true;
            this.songTitle.Font = new System.Drawing.Font("굴림", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.songTitle.Location = new System.Drawing.Point(21, 60);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(388, 43);
            this.songTitle.TabIndex = 0;
            this.songTitle.Text = "Open .mp3 file plz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressMax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressNow);
            this.groupBox2.Controls.Add(this.nowSongPosition);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(29, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1393, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1096, 51);
            this.progressBar1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1149, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "PLAY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(585, 755);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(517, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 213);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(59, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 128);
            this.label3.TabIndex = 0;
            this.label3.Text = "rk";
            // 
            // nowSongPosition
            // 
            this.nowSongPosition.AutoSize = true;
            this.nowSongPosition.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowSongPosition.Location = new System.Drawing.Point(31, 126);
            this.nowSongPosition.Name = "nowSongPosition";
            this.nowSongPosition.Size = new System.Drawing.Size(30, 29);
            this.nowSongPosition.TabIndex = 3;
            this.nowSongPosition.Text = "0";
            // 
            // progressNow
            // 
            this.progressNow.AutoSize = true;
            this.progressNow.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.progressNow.Location = new System.Drawing.Point(864, 148);
            this.progressNow.Name = "progressNow";
            this.progressNow.Size = new System.Drawing.Size(30, 29);
            this.progressNow.TabIndex = 4;
            this.progressNow.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(974, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "/";
            // 
            // progressMax
            // 
            this.progressMax.AutoSize = true;
            this.progressMax.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.progressMax.Location = new System.Drawing.Point(1042, 148);
            this.progressMax.Name = "progressMax";
            this.progressMax.Size = new System.Drawing.Size(30, 29);
            this.progressMax.TabIndex = 6;
            this.progressMax.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(39, 464);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 213);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 920);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "KoRaOKe Editer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label songTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nowSongPosition;
        private System.Windows.Forms.Label progressMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label progressNow;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

