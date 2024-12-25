using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RockScissors
{
    public partial class myForm : Form
    {
        int winTurn;
        int loseTurn;
        int drawTurn;
        int time = 30;


        public myForm()
        {
            InitializeComponent();
        }

        private void myForm_Load(object sender, EventArgs e)
        {
            //Label字串設定
            timeLabel.Text = $"Time {time} sec";
            titleLabel.Text = "Hi! Rockrt. Press Start";
            resultLabel.Text = "";
            gameLabel.Text = "";

            //Btn Enable
            startBtn.Enabled = true;
            quitBtn.Enabled = true;

            //Btn Disable
            pauseBtn.Enabled = false;
            stopBtn.Enabled = false;
            paperPic.Enabled = false;
            scissorsPic.Enabled = false;
            stonePic.Enabled = false;

        }

        //點圖片出拳, paper:0 sci:1 stone:2
        private void buttonClick(object sender, EventArgs e)
        {
            //使用者數字與電腦數字
            int userNum = 0;
            int comNum = 0;

            //判斷是誰觸發buttonClick(),然後做判斷,放上使用者的圖片,呼叫電腦隨機亂數方法
            if (((PictureBox)sender).Name == paperPic.Name)
            {
                userNum = 0;
                rockrtPic.Image = Properties.Resources.paper;
                comNum = comTrun();
            }

            else if(((PictureBox)sender).Name == scissorsPic.Name)
            {
                userNum = 1;
                rockrtPic.Image = Properties.Resources.scissors;
                comNum = comTrun();
            }

            else if (((PictureBox)sender).Name == stonePic.Name)
            {
                userNum = 2;
                rockrtPic.Image = Properties.Resources.stone;
                comNum = comTrun();
            }

            //判斷勝負, 平手Draw 勝Rockrt Win 負Rockrt Lose
            if (userNum - comNum == 0)
            { 
                resultLabel.Text = "Draw";
                drawTurn++;
            }
            else if(userNum - comNum == 1 || userNum - comNum == -2)
            {
                resultLabel.Text = "Rockrt Win";
                winTurn++;
            }
            else
            {
                resultLabel.Text = "Rockrt Lose";
                loseTurn++;
            }

        }

        //電腦隨機亂數出拳並設定圖片, paper:0 sci:1 stone:2
        private int comTrun()
        {
            int temp;
            Random random = new Random();
            temp = random.Next(0, 3);
            if (temp == 0)
            {
                computerPic.Image = Properties.Resources.paper;
            }
            else if (temp == 1)
            {
                computerPic.Image = Properties.Resources.scissors;
            }
            else if (temp == 2)
            {
                computerPic.Image = Properties.Resources.stone;
            }
            return temp;
        }

        //Start按鈕, 清空數值與字串紀錄, 按鈕權限調整與計時器啟動
        private void startBtn_Click(object sender, EventArgs e)
        {
            //前一次紀錄清空, 將title補上
            winTurn = 0;
            loseTurn = 0;
            drawTurn = 0;
            gameLabel.Text = "";
            titleLabel.Text = "Are You Rockrt? Good for You.";

            //startBtn Disable
            startBtn.Enabled = false;

            //Btn Enable
            pauseBtn.Enabled = true;
            stopBtn.Enabled = true;
            paperPic.Enabled = true;
            scissorsPic.Enabled = true;
            stonePic.Enabled = true;

            //timer start
            time = 30;
            timeLabel.Text = $"Time {time}sec";
            timer.Start();
        }

        //計時器的計時方法
        private void timer_Tick(object sender, EventArgs e)
        {
            //計時方法為倒數
            time--;
            timeLabel.Text = $"Time {time} sec";
            if(time == 0)
            { 
                timer.Stop();

                //倒數秒數為零時將出拳圖片拿掉並初始化
                computerPic.Image = Properties.Resources.question;
                rockrtPic.Image = Properties.Resources.question;

                //Btn Disable
                pauseBtn.Enabled = false;
                stopBtn.Enabled = false;
                paperPic.Enabled = false;
                scissorsPic.Enabled = false;
                stonePic.Enabled = false;

                //Btn Enable
                startBtn.Enabled = true;
                quitBtn.Enabled = true;

                //show titleLabel, 放上titleLabel字串
                if (winTurn > loseTurn)
                {
                    titleLabel.Text = "Rock Rockrt";
                }
                else if(winTurn < loseTurn)
                {
                    titleLabel.Text = "Poor Rockrt";
                }
                else 
                {
                    titleLabel.Text = "Draw Rockrt";
                }

                //設定resultLabel, gameLabel, 跳出MessageBox
                string messageBox = $"Time's Up!";
                string result = $"Draw {drawTurn} Times\nRockrt Win {winTurn} Times!\n Rockrt Lose {loseTurn} Times!";
                resultLabel.Text = "";
                gameLabel.Text = result;
                MessageBox.Show(messageBox,"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        //Pause按鈕, pause之後調整顯示的文字, 與一些按鈕的權限
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (pauseBtn.Text == "Pause")
            {
                pauseBtn.Text = "Cont.";
                timer.Stop();
                titleLabel.Text = "Pausing. Press Cont.";

                //Btn Disable
                paperPic.Enabled = false;
                scissorsPic.Enabled = false;
                stonePic.Enabled = false;
                
            }
            else
            {
                pauseBtn.Text = "Pause";
                titleLabel.Text = "Keep Going Rockrt!";
                timer.Start();
                //Btn Enable
                paperPic.Enabled = true;
                scissorsPic.Enabled = true;
                stonePic.Enabled = true;
            }
        }

        //Stop按鈕
        private void stopBtn_Click(object sender, EventArgs e)
        {
            //Stop後將數值與圖片初始化, 等待下一次Start
            timer.Stop();
            winTurn = 0;
            loseTurn = 0;
            drawTurn = 0;
            time = 30;
            computerPic.Image = Properties.Resources.question;
            rockrtPic.Image = Properties.Resources.question;
            timeLabel.Text = $"Time {time}sec";
            pauseBtn.Text = "Pause";
            resultLabel.Text = "";
            titleLabel.Text = "Hi! Rockrt. Press Start";

            //Btn Enable
            startBtn.Enabled = true;

            //Btn Disable
            pauseBtn.Enabled = false;
            paperPic.Enabled = false;
            scissorsPic.Enabled = false;
            stonePic.Enabled = false;
        }

        //Quit按鈕
        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
