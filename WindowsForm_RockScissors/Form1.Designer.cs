namespace RockScissors
{
    partial class myForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.computerPic = new System.Windows.Forms.PictureBox();
            this.stonePic = new System.Windows.Forms.PictureBox();
            this.scissorsPic = new System.Windows.Forms.PictureBox();
            this.paperPic = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.rockLabel = new System.Windows.Forms.Label();
            this.rivalLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gameLabel = new System.Windows.Forms.Label();
            this.rockrtPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stonePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockrtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // computerPic
            // 
            this.computerPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.computerPic.Image = global::RockScissors.Properties.Resources.question;
            this.computerPic.Location = new System.Drawing.Point(1058, 352);
            this.computerPic.Name = "computerPic";
            this.computerPic.Size = new System.Drawing.Size(230, 215);
            this.computerPic.TabIndex = 3;
            this.computerPic.TabStop = false;
            // 
            // stonePic
            // 
            this.stonePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stonePic.Image = global::RockScissors.Properties.Resources.stone;
            this.stonePic.Location = new System.Drawing.Point(220, 589);
            this.stonePic.Name = "stonePic";
            this.stonePic.Size = new System.Drawing.Size(230, 215);
            this.stonePic.TabIndex = 2;
            this.stonePic.TabStop = false;
            this.stonePic.Click += new System.EventHandler(this.buttonClick);
            // 
            // scissorsPic
            // 
            this.scissorsPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scissorsPic.Image = global::RockScissors.Properties.Resources.scissors;
            this.scissorsPic.Location = new System.Drawing.Point(220, 352);
            this.scissorsPic.Name = "scissorsPic";
            this.scissorsPic.Size = new System.Drawing.Size(230, 215);
            this.scissorsPic.TabIndex = 1;
            this.scissorsPic.TabStop = false;
            this.scissorsPic.Click += new System.EventHandler(this.buttonClick);
            // 
            // paperPic
            // 
            this.paperPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paperPic.Image = global::RockScissors.Properties.Resources.paper;
            this.paperPic.Location = new System.Drawing.Point(220, 118);
            this.paperPic.Name = "paperPic";
            this.paperPic.Size = new System.Drawing.Size(230, 215);
            this.paperPic.TabIndex = 0;
            this.paperPic.TabStop = false;
            this.paperPic.Tag = "";
            this.paperPic.Click += new System.EventHandler(this.buttonClick);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.startBtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startBtn.Location = new System.Drawing.Point(29, 118);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(150, 80);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.Yellow;
            this.pauseBtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pauseBtn.Location = new System.Drawing.Point(29, 258);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(150, 80);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopBtn.Location = new System.Drawing.Point(29, 403);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(150, 80);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Gray;
            this.quitBtn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.quitBtn.Location = new System.Drawing.Point(29, 691);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(150, 80);
            this.quitBtn.TabIndex = 7;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.timeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.timeLabel.Location = new System.Drawing.Point(774, 229);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(283, 61);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Time 30 sec";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rockLabel
            // 
            this.rockLabel.AutoSize = true;
            this.rockLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rockLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rockLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rockLabel.ForeColor = System.Drawing.Color.Black;
            this.rockLabel.Location = new System.Drawing.Point(522, 212);
            this.rockLabel.Name = "rockLabel";
            this.rockLabel.Size = new System.Drawing.Size(217, 78);
            this.rockLabel.TabIndex = 9;
            this.rockLabel.Text = "Rockrt";
            this.rockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rivalLabel
            // 
            this.rivalLabel.AutoSize = true;
            this.rivalLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rivalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rivalLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rivalLabel.ForeColor = System.Drawing.Color.Black;
            this.rivalLabel.Location = new System.Drawing.Point(1097, 212);
            this.rivalLabel.Name = "rivalLabel";
            this.rivalLabel.Size = new System.Drawing.Size(169, 78);
            this.rivalLabel.TabIndex = 10;
            this.rivalLabel.Text = "Rival";
            this.rivalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.Location = new System.Drawing.Point(821, 438);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(158, 35);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "resultLabel";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel.Location = new System.Drawing.Point(338, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(293, 76);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "titleLabel";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gameLabel.Location = new System.Drawing.Point(768, 630);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(160, 35);
            this.gameLabel.TabIndex = 13;
            this.gameLabel.Text = "gameLabel";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rockrtPic
            // 
            this.rockrtPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rockrtPic.Image = global::RockScissors.Properties.Resources.question;
            this.rockrtPic.Location = new System.Drawing.Point(522, 352);
            this.rockrtPic.Name = "rockrtPic";
            this.rockrtPic.Size = new System.Drawing.Size(230, 215);
            this.rockrtPic.TabIndex = 14;
            this.rockrtPic.TabStop = false;
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1350, 900);
            this.Controls.Add(this.rockrtPic);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.rivalLabel);
            this.Controls.Add(this.rockLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.computerPic);
            this.Controls.Add(this.stonePic);
            this.Controls.Add(this.scissorsPic);
            this.Controls.Add(this.paperPic);
            this.Name = "myForm";
            this.Text = "RockScissors";
            this.Load += new System.EventHandler(this.myForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stonePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockrtPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paperPic;
        private System.Windows.Forms.PictureBox scissorsPic;
        private System.Windows.Forms.PictureBox stonePic;
        private System.Windows.Forms.PictureBox computerPic;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label rockLabel;
        private System.Windows.Forms.Label rivalLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.PictureBox rockrtPic;
    }
}

