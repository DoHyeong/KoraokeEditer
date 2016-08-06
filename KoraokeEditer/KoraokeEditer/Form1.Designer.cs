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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnOpen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.songTitle = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnPlay = new MaterialSkin.Controls.MaterialRaisedButton();
            this.progressMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressNow = new System.Windows.Forms.Label();
            this.nowSongPosition = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nowGasa = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnOpen);
            this.groupBox1.Controls.Add(this.songTitle);
            this.groupBox1.Location = new System.Drawing.Point(32, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1393, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Depth = 0;
            this.BtnOpen.Location = new System.Drawing.Point(1149, 34);
            this.BtnOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Primary = true;
            this.BtnOpen.Size = new System.Drawing.Size(201, 100);
            this.BtnOpen.TabIndex = 6;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // songTitle
            // 
            this.songTitle.AutoSize = true;
            this.songTitle.Depth = 0;
            this.songTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.songTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.songTitle.Location = new System.Drawing.Point(31, 67);
            this.songTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(250, 37);
            this.songTitle.TabIndex = 6;
            this.songTitle.Text = "Plz Open mp3 file";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnPlay);
            this.groupBox2.Controls.Add(this.progressMax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressNow);
            this.groupBox2.Controls.Add(this.nowSongPosition);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(32, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1393, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Depth = 0;
            this.BtnPlay.Location = new System.Drawing.Point(1149, 34);
            this.BtnPlay.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Primary = true;
            this.BtnPlay.Size = new System.Drawing.Size(201, 100);
            this.BtnPlay.TabIndex = 7;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // progressMax
            // 
            this.progressMax.AutoSize = true;
            this.progressMax.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.progressMax.Location = new System.Drawing.Point(1042, 126);
            this.progressMax.Name = "progressMax";
            this.progressMax.Size = new System.Drawing.Size(30, 29);
            this.progressMax.TabIndex = 6;
            this.progressMax.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(949, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "/";
            // 
            // progressNow
            // 
            this.progressNow.AutoSize = true;
            this.progressNow.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.progressNow.Location = new System.Drawing.Point(864, 126);
            this.progressNow.Name = "progressNow";
            this.progressNow.Size = new System.Drawing.Size(30, 29);
            this.progressNow.TabIndex = 4;
            this.progressNow.Text = "0";
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1096, 51);
            this.progressBar1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(521, 548);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 213);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NowText";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(59, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 128);
            this.label3.TabIndex = 0;
            this.label3.Text = "가";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(68, 548);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 213);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NowIndex";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(86, 4);
            // 
            // nowGasa
            // 
            this.nowGasa.AutoSize = true;
            this.nowGasa.Depth = 0;
            this.nowGasa.Font = new System.Drawing.Font("Roboto", 11F);
            this.nowGasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nowGasa.Location = new System.Drawing.Point(472, 805);
            this.nowGasa.MouseState = MaterialSkin.MouseState.HOVER;
            this.nowGasa.Name = "nowGasa";
            this.nowGasa.Size = new System.Drawing.Size(214, 37);
            this.nowGasa.TabIndex = 6;
            this.nowGasa.Text = "materialLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 920);
            this.Controls.Add(this.nowGasa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nowSongPosition;
        private System.Windows.Forms.Label progressMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label progressNow;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel songTitle;
        private MaterialSkin.Controls.MaterialRaisedButton BtnOpen;
        private MaterialSkin.Controls.MaterialRaisedButton BtnPlay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialLabel nowGasa;
    }
}

