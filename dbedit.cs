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

namespace Quizcim
{
    public partial class dbedit : Form
    {
        public dbedit()
        {
            InitializeComponent();
        }

        // Connection String
        static string connect = Application.StartupPath;
        static string constr = $"Data source ={connect}\\quizappdb.db;Version=3;";

        // Connection
        SQLiteConnection sql = new SQLiteConnection(constr);






        // seçili olan testi silme
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string soruid = cmb_quiz.SelectedItem.ToString();

            if (MessageBox.Show("Testi Sileceksiniz Onaylıyor musunuz?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection(constr))
                {
                    connection.Open();

                    // soruları siler
                    using (SQLiteCommand command = new SQLiteCommand($"delete from questions where quiz_id = ( select quiz_id from quizs where quiz_name = '{soruid}')", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // testi siler
                    using (SQLiteCommand command = new SQLiteCommand($"delete from quizs where quiz_name = '{soruid}'", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }


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
            else
            {
               MessageBox.Show("Silme İşlemi İptal Edilmiştir.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        // girilen verilere göre soruları güncelleme
        private void btn_edit_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Soruyu güncelleyeceksiniz onaylıyor musunuz?", "Kayıt Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // tanımlamalar
                string
                    soruid = cmb_quiz.SelectedItem.ToString(),
                    soruidsi = list_quest.SelectedItem.ToString(),
                    soru = txtquestion.Text,
                    sık_a = txtasw_a.Text,
                    sık_b = txtasw_b.Text,
                    sık_c = txtasw_c.Text,
                    sık_d = txtasw_d.Text;


                // sql sorgusu
                using (SQLiteConnection connection = new SQLiteConnection(constr))
                {
                    connection.Open();


                    using (SQLiteCommand command = new SQLiteCommand($"UPDATE questions SET question = '{soruidsi + " " + soru}', " +
                    $"answer_A = '{sık_a}'," +
                    $"answer_B = '{sık_b}'," +
                    $"answer_C = '{sık_c}'," +
                    $"answer_D = '{sık_d}'" +
                    $"where question LIKE '{soruidsi}%'", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İptal Edilmiştir.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        // form yüklendiğinde veritabanındaki testlerin başlıklarını combobox'a aktarma
        private void dbedit_Load(object sender, EventArgs e)
        {
            sql.Open();


            SQLiteCommand sqlc = new SQLiteCommand("select quiz_name from quizs", sql);

            SQLiteDataReader dtr = sqlc.ExecuteReader();

            while (dtr.Read())
            {
                cmb_quiz.Items.Add(dtr["quiz_name"].ToString());
            }

            sql.Close();
        }




        // listboxta seçili olan soruyu formda uygun yerlere aktarma
        private void list_quest_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql.Open();

            string soru = list_quest.SelectedItem.ToString();
            string soruid = cmb_quiz.SelectedItem.ToString();




            SQLiteCommand sqlc = new SQLiteCommand($"select* from questions qu, quizs qi where qi.quiz_id = qu.quiz_id AND qi.quiz_name = '{soruid}' AND qu.question LIKE '{soru}%'", sql);

            SQLiteDataReader dtr = sqlc.ExecuteReader();

            while (dtr.Read())
            {
                string sorusu = "";

                string[] sorudz = dtr["question"].ToString().Split(' ');

                for(int i = 2; i < sorudz.Length; i++)
                {
                    sorusu += sorudz[i];
                }


                txtquestion.Text = sorusu;
                txtasw_a.Text = dtr["answer_A"].ToString();
                txtasw_b.Text = dtr["answer_B"].ToString();
                txtasw_c.Text = dtr["answer_C"].ToString();
                txtasw_d.Text = dtr["answer_D"].ToString();



                string truean = dtr["trueanswer"].ToString();




                // Doğru Cevap Şıkkı
                if (truean == "A")
                {
                    checkA.Checked = true;

                    checkB.Checked = false;
                    checkC.Checked = false;
                    checkD.Checked = false;
                }
                else if (truean == "B")
                {
                    checkB.Checked = true;

                    checkA.Checked = false;
                    checkC.Checked = false;
                    checkD.Checked = false;
                }
                else if (truean == "C")
                {
                    checkC.Checked = true;

                    checkB.Checked = false;
                    checkA.Checked = false;
                    checkD.Checked = false;
                }
                else if (truean == "D")
                {
                    checkD.Checked = true;

                    checkB.Checked = false;
                    checkC.Checked = false;
                    checkA.Checked = false;
                }

            }

            

            sql.Close();
        }




        // form close
        private void dbedit_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateQuizPage q1 = new CreateQuizPage();
            q1.Show();
        }





        private void cmb_quiz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
