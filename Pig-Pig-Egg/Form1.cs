using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pig_Pig_Egg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] Pic_Codes;
        public int[] Ans;
        public int count;
        public int score;
        private delegate void UpdateUI();
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Load("pic/icon.png");
            Init();
        }
        
        public void Init()
        {
            count = 0;
            score = 0;
            Pic_Codes = NoRepeatRandomArray(4, 1, 5);
            Ans = RandomArray(4, 0, 2);
            string Hubble_path = "pic/Hubble_" + Pic_Codes[0] + ".png";
            string Webb_path = "pic/Webb_" + Pic_Codes[0] + ".png";
            if (Ans[0] == 0)
            {
                pictureBox1.Load(Webb_path);
                pictureBox2.Load(Hubble_path);
            }
            else
            {
                pictureBox1.Load(Hubble_path);
                pictureBox2.Load(Webb_path);
            }
        }

        #region "Generate non-repeating random array"
        public int[] NoRepeatRandomArray(int length, int min, int max)
        {
            int[] randomArray = new int[length];
            Random crandom = new Random();
            for (int i = 0; i < length; i++)
            {
                randomArray[i] = crandom.Next(min, max);

                for(int j = 0; j < i; j++)
                {
                    while(randomArray[j] == randomArray[i])
                    {
                        j = 0;
                        randomArray[i] = crandom.Next(min, max);
                    }
                }
            }                     
            return randomArray;
        }
        #endregion

        #region "Generate random array"
        public int[] RandomArray(int length, int min, int max)
        {
            int[] randomArray = new int[length];
            Random crandom = new Random();
            for (int i = 0; i < length; i++)
            {
                randomArray[i] = crandom.Next(min, max);
            }
            return randomArray;
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(LeftJudge);
            th1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread th2 = new Thread(RightJudge);
            th2.Start();
        }

        private void LeftJudge()
        {
            if (Ans[count] == 0)
            {
                Bingo();
                Thread.Sleep(1000);
                if (count != 3)
                {
                    NextQuestion();
                }
                else
                {
                    Result();
                }
            }
            else
            {
                Wrong();
                Thread.Sleep(1000);
                if (count != 3)
                {
                    NextQuestion();
                }
                else
                {
                    Result();
                }
            }
        }
        private void RightJudge()
        {
            if (Ans[count] == 1)
            {
                Bingo();
                Thread.Sleep(1000);
                if (count != 3)
                {
                    NextQuestion();
                }
                else
                {
                    Result();
                }
            }
            else
            {
                Wrong();
                Thread.Sleep(1000);
                if (count != 3)
                {
                    NextQuestion();
                }
                else
                {
                    Result();
                }
            }
        }
        private void Bingo()
        {
            if (this.InvokeRequired)
            {
                UpdateUI del = new UpdateUI(Bingo);
                this.Invoke(del);
            }
            else
            {
                lbans.Visible = true;
                score++;
                lbans.Text = "Bingo!!!";
                lbscore.Text = score + "/4";
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;

            }
        }

        private void Wrong()
        {
            if (this.InvokeRequired)
            {
                UpdateUI del = new UpdateUI(Wrong);
                this.Invoke(del);
            }
            else
            {
                lbans.Visible = true;
                lbans.Text = "Wrong!!!";
                lbscore.Text = score + "/4";
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
            }
        }

        private void NextQuestion()
        {
            if (this.InvokeRequired)
            {
                UpdateUI del = new UpdateUI(NextQuestion);
                this.Invoke(del);
            }
            else
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                lbans.Visible = false;
                count++;
                string Hubble_path = "pic/Hubble_" + Pic_Codes[count] + ".png";
                string Webb_path = "pic/Webb_" + Pic_Codes[count] + ".png";
                if (Ans[count] == 0)
                {
                    pictureBox1.Load(Webb_path);
                    pictureBox2.Load(Hubble_path);
                }
                else
                {
                    pictureBox1.Load(Hubble_path);
                    pictureBox2.Load(Webb_path);
                }
            }
        }

        private void Result()
        {
            if (this.InvokeRequired)
            {
                UpdateUI del = new UpdateUI(Result);
                this.Invoke(del);
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                lbans.Visible = false;
                lbquestion.Visible = false;
                lbscore.Visible = false;
                lbresult.Visible = true;
                lbresult.Text = score + "/4";
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Load("pic/restart.png");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox4.Visible = false;
            lbans.Visible = false;
            lbquestion.Visible = true;
            lbscore.Visible = true;
            lbresult.Visible = false;
            Init();
            lbscore.Text = score + "/4";
            lbans.Text = "";
        }
    }
}
