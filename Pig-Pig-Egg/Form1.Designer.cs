
namespace Pig_Pig_Egg
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbquestion = new System.Windows.Forms.Label();
            this.lbscore = new System.Windows.Forms.Label();
            this.lbans = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbresult = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 274);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbquestion
            // 
            this.lbquestion.AutoSize = true;
            this.lbquestion.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquestion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbquestion.Location = new System.Drawing.Point(101, 66);
            this.lbquestion.Name = "lbquestion";
            this.lbquestion.Size = new System.Drawing.Size(851, 36);
            this.lbquestion.TabIndex = 2;
            this.lbquestion.Text = "Which image was taken by the James Webb Space Telescope?";
            // 
            // lbscore
            // 
            this.lbscore.AutoSize = true;
            this.lbscore.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbscore.ForeColor = System.Drawing.SystemColors.Control;
            this.lbscore.Location = new System.Drawing.Point(916, 19);
            this.lbscore.Name = "lbscore";
            this.lbscore.Size = new System.Drawing.Size(56, 36);
            this.lbscore.TabIndex = 4;
            this.lbscore.Text = "0/4";
            // 
            // lbans
            // 
            this.lbans.AutoSize = true;
            this.lbans.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbans.ForeColor = System.Drawing.SystemColors.Control;
            this.lbans.Location = new System.Drawing.Point(423, 474);
            this.lbans.Name = "lbans";
            this.lbans.Size = new System.Drawing.Size(70, 36);
            this.lbans.TabIndex = 5;
            this.lbans.Text = "N/A";
            this.lbans.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(541, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 274);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.ForeColor = System.Drawing.SystemColors.Control;
            this.lbresult.Location = new System.Drawing.Point(460, 155);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(56, 36);
            this.lbresult.TabIndex = 8;
            this.lbresult.Text = "0/4";
            this.lbresult.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(449, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 42);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbans);
            this.Controls.Add(this.lbscore);
            this.Controls.Add(this.lbquestion);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbquestion;
        private System.Windows.Forms.Label lbscore;
        private System.Windows.Forms.Label lbans;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

