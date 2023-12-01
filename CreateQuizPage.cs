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
    public partial class CreateQuizPage : Form
    {
        public CreateQuizPage()
        {
            InitializeComponent();
        }

        static string connect = Application.StartupPath;
        string constr = $"Data source ={connect}\\quizappdb.db;Version=3;";
       
        
        public int sayac = 0;



        // QUİZ ID FİND METHOD
        public int quizidmethod()
        {
            var con = new SQLiteConnection(constr);


            string qzname = txtqstname.Text;
            string qzid = "";


            con.Open();

            var cmd = new SQLiteCommand($"select quiz_id from quizs where quiz_name = '{qzname}'", con);

            SQLiteDataReader dtr = cmd.ExecuteReader();
            
            if(dtr.Read())
            {
                qzid = dtr["quiz_id"].ToString();
            }

            MessageBox.Show("Quiz id " + qzid);

            dtr.Close();
            con.Close();
            return int.Parse(qzid);
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
            MessageBox.Show("Doğru Cevap: " + trueans);
            return trueans;
        }














        //  CREATE QUESTİON
        private void btnsave_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(constr);
            con.Open();

            string qstname = txtqstname.Text;

            if(qstname != "")
            {
                SQLiteCommand cmd = new SQLiteCommand($"insert into quizs(quiz_name) values('{qstname}')", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Test Eklendi");
                con.Close();

                lbl_sayac.Visible = true;
                btncreate.Visible = true;
            }
        }






        // SAVE QUESTİON ANSWER
        private void button1_Click(object sender, EventArgs e)
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


            var con = new SQLiteConnection(constr);
            con.Open();

            string qstname = txtqstname.Text;

            if (question != "" || answer_A != "" || answer_B != "" || answer_C != "" || answer_D != "")
            {

                SQLiteCommand cmd = new SQLiteCommand($"insert into questions values({questid}, '{question}', '{answer_A}', '{answer_B}', '{answer_C}', '{answer_D}', '{truequest}');", con);
                
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Soru Eklendi");

                con.Close();

            }
            else MessageBox.Show("Soru Yapılamadı");



        //if(sayac <= 20)
        //{
        //    if (question != "" || answer_A != "" || answer_B != "" || answer_C != "" || answer_D != "")
        //    {

        //        using (var baglanti = new SQLiteConnection(constr))
        //        {
        //            using (var kmt = new SQLiteCommand($"insert into questions values({questid}, '{question}', '{answer_A}', '{answer_B}', '{answer_C}', '{answer_D}', '{truequest}');", baglanti))
        //            {
        //                try
        //                {
        //                    kmt.Connection.Open();
        //                    kmt.ExecuteNonQuery();

        //                    MessageBox.Show("Soru Oluşturuldu");



        //                    sayac++;
        //                    lbl_sayac.Text = "Oluşturulan Soru Sayısı: " + sayac + "/20";

        //                    kmt.Connection.Close();
        //                }
        //                catch (Exception)
        //                {
        //                    MessageBox.Show("Soru Kaydı Yapılamadı");
        //                }
        //            }
        //        }
        //    }
        //    else { MessageBox.Show("Doldurulmamış Alan Mevcut"); }
        //}
        //else MessageBox.Show("Test Soruları Başarıyla Kaydedildi");




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


        }

    }
}
