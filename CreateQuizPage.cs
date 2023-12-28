using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Quizcim
{
    public partial class CreateQuizPage : Form
    {
        public CreateQuizPage()
        {
            InitializeComponent();
        }

        static string connect = Application.StartupPath;
        string constr = $"Data source ={connect}\\quizappdb.db;Version=3;";
       
        


        private void quizsname()
        {
            var sql = new SQLiteConnection(constr);
            sql.Open();

            cmb_quiz.Items.Clear();


            SQLiteCommand sqlc = new SQLiteCommand("select quiz_name from quizs", sql);

            SQLiteDataReader dtr = sqlc.ExecuteReader();

            while (dtr.Read())
            {
                cmb_quiz.Items.Add(dtr["quiz_name"].ToString());
            }

            sql.Close();
        }




        // QUİZ ID FİND METHOD
        public int quizidmethod()
        {
            var con = new SQLiteConnection(constr);


            string qzname = cmb_quiz.Text.ToString();
            string qzid = "";

            if (!string.IsNullOrEmpty(cmb_quiz.Text))
            {
                con.Open();

                var cmd = new SQLiteCommand($"select quiz_id from quizs where quiz_name = '{qzname}'", con);

                SQLiteDataReader dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    qzid = dtr["quiz_id"].ToString();
                }

                dtr.Close();
                con.Close();

                return int.Parse(qzid);
            }
            else MessageBox.Show("Test Seçiniz"); return 1;


        }




        // TRUE ANSWER METHOD
        public string truemethod()
        {

            string trueans = "";
            if (checkA.Checked)
            {
                trueans = "A";
            }
            else if (checkB.Checked)
            {
                trueans = "B";
            }
            else if (checkC.Checked)
            {
                trueans = "C";
            }
            else if (checkD.Checked)
            {
                trueans = "D";
            }
            else
            {
                MessageBox.Show("Lütfen Doğru Şıkkı Seçiniz");
            }
            return trueans;
        }




        // QUİZ QUESTİON SAVE
        public void questionsave()
        {
            // question and answers
            string
              question = txtquestion.Text,
              answer_A = txtasw_a.Text,
              answer_B = txtasw_b.Text,
              answer_C = txtasw_c.Text,
              answer_D = txtasw_d.Text,
              truequest = truemethod();

            int questid = quizidmethod();





            // connection
            var con = new SQLiteConnection(constr);
            con.Open();



            if (!string.IsNullOrEmpty(cmb_quiz.Text))
            {

                // question count
                string quiznames = cmb_quiz.Text.ToString();
                SQLiteCommand cmdsayi = new SQLiteCommand($"select count(question) from questions where quiz_id = (select quiz_id from quizs where quiz_name = '{quiznames}')", con);

                int kayitSayisi = Convert.ToInt32(cmdsayi.ExecuteScalar());




                string qstname = cmb_quiz.Text.ToString();

                if (question != "" || answer_A != "" || answer_B != "" || answer_C != "" || answer_D != "" || truequest != "")
                {
                    kayitSayisi++;

                    SQLiteCommand cmd = new SQLiteCommand($"insert into questions values({questid}, '{kayitSayisi}', '{question}', '{answer_A}', '{answer_B}', '{answer_C}', '{answer_D}', '{truequest}');", con);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Soru Eklendi");

                    con.Close();


                    lbl_sayac.Text = "Oluşturulan Soru Sayısı: " + kayitSayisi;




                    // clear
                    txtquestion.Text = "";
                    txtasw_a.Text = "";
                    txtasw_b.Text = "";
                    txtasw_c.Text = "";
                    txtasw_d.Text = "";


                    checkA.Checked = false;
                    checkB.Checked = false;
                    checkC.Checked = false;
                    checkD.Checked = false;
                }
                else MessageBox.Show("Soru Eklenemedi");
            }
                



            
        }







        //  CREATE QUESTİON
        private void btnsave_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(constr);
            con.Open();



            lbl_sayac.Text = "Oluşturulan Soru Sayısı : 0";

            string qstname = cmb_quiz.Text.Trim();
            bool namecheck = false;

            // Var olan bir test mi kontrolü
            foreach (string item in cmb_quiz.Items)
            {
                if (item.Trim() == qstname)
                {
                    namecheck = true;
                    break;
                }
            }

            // quiz create sql
            if (!string.IsNullOrEmpty(qstname) && !namecheck)
            {
                using (SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO quizs (quiz_name) VALUES ('{qstname}')", con))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Test Oluşturuldu");
                con.Close();

                lbl_sayac.Visible = true;
                btncreate.Visible = true;

                quizsname();
            }
            else MessageBox.Show("Test İsmi Girilmedi veya Var Olan Bir Test Girildi");
        }






        // SAVE QUESTİON ANSWER
        private void btnquestsave_Click(object sender, EventArgs e)
        {

            questionsave();
        }



        private void btndevam_Click(object sender, EventArgs e)
        {
            var sql = new SQLiteConnection(constr);
            sql.Open();


            string quiznames = cmb_quiz.Text.ToString();
            SQLiteCommand cmdquount = new SQLiteCommand($"select count(question) from questions where quiz_id = (select quiz_id from quizs where quiz_name = '{quiznames}')", sql);

            int kayitSayisi = Convert.ToInt32(cmdquount.ExecuteScalar());

            lbl_sayac.Text = "Oluşturulan Soru Sayısı : " + kayitSayisi.ToString();

            lbl_sayac.Visible = true;
            btncreate.Visible = true;

            sql.Close();

        }






        private void btn_editt_Click(object sender, EventArgs e)
        {
            this.Hide();
            dbedit frm = new dbedit();
            frm.Show();
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CreateQuizPage_FormClosing(object sender, FormClosingEventArgs e)
        {
        Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void CreateQuizPage_Load(object sender, EventArgs e)
        {
            quizsname();

        }

    }
}
