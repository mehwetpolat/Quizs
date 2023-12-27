using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quizcim
{
    


    public partial class QuizForm : Form
    {

        // Connection String
        static string connect = Application.StartupPath;
        static string constr = $"Data source ={connect}\\quizappdb.db;Version=3;";

        // Connection
        SQLiteConnection sql = new SQLiteConnection(constr);



        public QuizForm()
        {
            InitializeComponent();
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


        public string trueansw;
        public int soru = 1;




        // form yüklendiğinde seçilen testin ilk sorusunu ekrana getirme
        private void QuizForm_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constr))
            {
                connection.Open();

                MessageBox.Show("Bağlandı");
                string quiznames = Choice.name;


                using (SQLiteCommand command = new SQLiteCommand($"select* from questions qu, quizs qi where qi.quiz_id = qu.quiz_id AND qi.quiz_name = '{quiznames}' AND qu.question_id = '{soru}'", connection))
                {

                    MessageBox.Show("Komut içine girdi, test: " + quiznames + " soru : " + soru);

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

        private void btn_A_Click(object sender, EventArgs e)
        {
            if(trueansw == "A")
            {
                btn_A.BackColor = Color.Green;
                btn_A.ForeColor = Color.Black;
            }
            else
            {
                btn_A.BackColor = Color.Red;
                btn_A.ForeColor = Color.White;
            }
            btn_next.Visible = true;
            lbl_tpl.Visible = true;
            lbl_puan.Visible = true;
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            if (trueansw == "B")
            {
                btn_B.BackColor = Color.Green;
                btn_B.ForeColor = Color.Black;
            }
            else
            {
                btn_B.BackColor = Color.Red;
                btn_B.ForeColor = Color.White;
            }

            btn_next.Visible = true;
            lbl_tpl.Visible = true;
            lbl_puan.Visible = true;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            if (trueansw == "C")
            {
                btn_C.BackColor = Color.Green;
                btn_C.ForeColor = Color.Black;
            }
            else
            {
                btn_C.BackColor = Color.Red;
                btn_C.ForeColor = Color.White;
            }

            btn_next.Visible = true;
            lbl_tpl.Visible = true;
            lbl_puan.Visible = true;
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            if (trueansw == "D")
            {
                btn_D.BackColor = Color.Green;
                btn_D.ForeColor = Color.Black;
            }
            else
            {
                btn_D.BackColor = Color.Red;
                btn_D.ForeColor = Color.White;
            }

            btn_next.Visible = true;
            lbl_tpl.Visible = true;
            lbl_puan.Visible = true;
        }

        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }




        private void btn_next_Click(object sender, EventArgs e)
        {
            soru++;

            using (SQLiteConnection connection = new SQLiteConnection(constr))
            {
                connection.Open();

                MessageBox.Show("Bağlandı");
                string quiznames = Choice.name;


                using (SQLiteCommand command = new SQLiteCommand($"select* from questions qu, quizs qi where qi.quiz_id = qu.quiz_id AND qi.quiz_name = '{quiznames}' AND qu.question_id = '{soru}'", connection))
                {

                    MessageBox.Show("Komut içine girdi, test: " + quiznames + " soru : " + soru);

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



            // color code
            var bluecol = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(62)))), ((int)(((byte)(149)))));
            var orangcol = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


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

        }
    }
}
