using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quizcim
{
    


    public partial class QuizForm : Form
    {

        public QuizForm()
        {
            InitializeComponent();

        }




        // Connection String
        static string connect = Application.StartupPath;
        static string constr = $"Data source ={connect}\\quizappdb.db;Version=3;";

        // Connection
        SQLiteConnection sql = new SQLiteConnection(constr);
        
        
        
        
        
        // color
        Color bluecol = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
        Color orangcol = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

        

        

        public string trueansw;
        public int soru = 1;
        int puan;



        // SOUND PLAYER
        public void soundplays(string whatsounds)
        {

            SoundPlayer sounds = new SoundPlayer();
            string soundizin = Application.StartupPath;

            if (whatsounds == "start")
            {
                soundizin += "\\start_sound.wav";
                sounds.SoundLocation = soundizin;
                sounds.Play();
            }

            else if(whatsounds == "lose")
            {
                soundizin += "\\lose_sound.wav";
                sounds.SoundLocation = soundizin;
                sounds.Play();
            }

            else if (whatsounds == "win")
            {
                soundizin += "\\win_sound.wav";
                sounds.SoundLocation = soundizin;
                sounds.Play();
            }

            else if (whatsounds == "new")
            {
                soundizin += "\\newquestion_sound.wav";
                sounds.SoundLocation = soundizin;
                sounds.Play();
            }
        }


        

        // choice button unenabled
        public void unenabledbtn()
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
        }

        // choice button enabled
        public void enabledbtn()
        {
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
        }




        // form yüklendiğinde seçilen testin ilk sorusunu ekrana getirme
        private void QuizForm_Load(object sender, EventArgs e)
        {

            soundplays("start");

            using (SQLiteConnection connection = new SQLiteConnection(constr))
            {
                connection.Open();

                string quiznames = Choice.name;


                using (SQLiteCommand command = new SQLiteCommand($"select* from questions qu, quizs qi where qi.quiz_id = qu.quiz_id AND qi.quiz_name = '{quiznames}' AND qu.question_id = '{soru}'", connection))
                {
                    SQLiteDataReader dtr = command.ExecuteReader();

                    if(dtr.Read())
                    {
                        txt_question.Text = dtr["question"].ToString(); // question
                        btn_A.Text = dtr["answer_A"].ToString();        // answer
                        btn_B.Text = dtr["answer_B"].ToString();        // answer
                        btn_C.Text = dtr["answer_C"].ToString();        // answer
                        btn_D.Text = dtr["answer_D"].ToString();        // answer
                        trueansw = dtr["trueanswer"].ToString();        // true answer
                    }
                    
                }
            }

            
        }




        // BUTTON TRUE FALSE
        private void btn_A_Click(object sender, EventArgs e)
        {
            if(trueansw == "A")
            {
                btn_A.BackColor = Color.Green;
                btn_A.ForeColor = Color.Black;

                btnElipsA.BackColor = Color.Green;
                btnElipsA1.BackColor = Color.Green;

                puan += 5;

                soundplays("win"); // win sound play
                
            }
            else
            {
                btn_A.BackColor = Color.Red;
                btn_A.ForeColor = Color.White;

                btnElipsA.BackColor = Color.Red;
                btnElipsA1.BackColor = Color.Red;

                puan -= 5;

                soundplays("lose"); // lose sound play
            }
            
            btn_next.Visible = true;
            lbl_tpl.Visible = true;
            lbl_puan.Visible = true;

            lbl_puan.Text = puan.ToString();

            unenabledbtn(); // all choice button unenabled

        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            if (trueansw == "B")
            {
                btn_B.BackColor = Color.Green;
                btn_B.ForeColor = Color.Black;
                
                btnElipsB.BackColor = Color.Green;
                btnElipsB1.BackColor = Color.Green;

                puan += 5;

                soundplays("win"); // win sound play
            }
            else
            {
                btn_B.BackColor = Color.Red;
                btn_B.ForeColor = Color.White;

                btnElipsB.BackColor = Color.Red;
                btnElipsB1.BackColor = Color.Red;

                puan -= 5;

                soundplays("lose"); // lose sound play
            }

            btn_next.Visible = true;
            lbl_tpl.Visible = true;
            lbl_puan.Visible = true;

            lbl_puan.Text = puan.ToString();

            unenabledbtn(); // all choice button unenabled
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            if (trueansw == "C")
            {
                btn_C.BackColor = Color.Green;
                btn_C.ForeColor = Color.Black;

                btnElipsC.BackColor = Color.Green;
                btnElipsC1.BackColor = Color.Green;

                puan += 5;

                soundplays("win"); // win sound play
            }
            else
            {
                btn_C.BackColor = Color.Red;
                btn_C.ForeColor = Color.White;

                btnElipsC.BackColor = Color.Red;
                btnElipsC1.BackColor = Color.Red;

                puan -= 5;

                soundplays("lose"); // lose sound play
            }

            btn_next.Visible = true;
            lbl_tpl.Visible = true;
            lbl_puan.Visible = true;

            lbl_puan.Text = puan.ToString();

            unenabledbtn(); // all choice button unenabled
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            if (trueansw == "D")
            {
                btn_D.BackColor = Color.Green;
                btn_D.ForeColor = Color.Black;

                btnElipsD.BackColor = Color.Green;
                btnElipsD1.BackColor = Color.Green;

                puan += 5;

                soundplays("win"); // win sound play
            }
            else
            {
                btn_D.BackColor = Color.Red;
                btn_D.ForeColor = Color.White;

                btnElipsD.BackColor = Color.Red;
                btnElipsD1.BackColor = Color.Red;

                puan -= 5;

                soundplays("lose"); // lose sound play
            }

            btn_next.Visible = true;
            lbl_tpl.Visible = true;
            lbl_puan.Visible = true;

            lbl_puan.Text = puan.ToString();

            unenabledbtn(); // all choice button unenabled
        }






        // BUTTON NEXT QUESTİON
        private void btn_next_Click(object sender, EventArgs e)
        {
            soru++;

            using (SQLiteConnection connection = new SQLiteConnection(constr))
            {
                connection.Open();

                string quiznames = Choice.name;

                using (SQLiteCommand command = new SQLiteCommand($"select* from questions qu, quizs qi where qi.quiz_id = qu.quiz_id AND qi.quiz_name = '{quiznames}' AND qu.question_id = '{soru}'", connection))
                {

                    SQLiteDataReader dtr = command.ExecuteReader();

                    if (dtr.Read())
                    {
                        txt_question.Text = dtr["question"].ToString(); // question
                        btn_A.Text = dtr["answer_A"].ToString();        // answer
                        btn_B.Text = dtr["answer_B"].ToString();        // answer
                        btn_C.Text = dtr["answer_C"].ToString();        // answer
                        btn_D.Text = dtr["answer_D"].ToString();        // answer
                        trueansw = dtr["trueanswer"].ToString();        // true answer
                    }

                }
            }

            enabledbtn();

            soundplays("new");


            // color default form changed
            btn_next.Visible = false;
            btn_A.BackColor = bluecol;
            btn_A.ForeColor = orangcol;
            btn_B.BackColor = bluecol;
            btn_B.ForeColor = orangcol;
            btn_C.BackColor = bluecol;
            btn_C.ForeColor = orangcol;
            btn_D.BackColor = bluecol;
            btn_D.ForeColor = orangcol;


            btnElipsA.BackColor = bluecol;
            btnElipsA1.BackColor = bluecol;
            btnElipsB.BackColor = bluecol;
            btnElipsB1.BackColor = bluecol;
            btnElipsC.BackColor = bluecol;
            btnElipsC1.BackColor = bluecol;
            btnElipsD.BackColor = bluecol;
            btnElipsD1.BackColor = bluecol;
        }







        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btn_B_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
