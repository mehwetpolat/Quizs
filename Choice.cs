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

namespace Quizcim
{


    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }



        // Connection String
        static string connect = Application.StartupPath;
        static string constr = $"Data source ={connect}\\quizappdb.db;Version=3;";

        // Connection
        SQLiteConnection sql = new SQLiteConnection(constr);

        static public string name = "";




        // soru oluşturma formuna geçis
        private void button1_Click(object sender, EventArgs e)
        {
            CreateQuizPage cq1 = new CreateQuizPage();
            this.Close();
            cq1.Show();
        }


        // test çözme formuna geçiş
        private void button2_Click(object sender, EventArgs e)
        {
            name = cmb_selectquiz.SelectedItem.ToString();

            QuizForm q2 = new QuizForm();
            q2.Show();


            this.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Choice_Load(object sender, EventArgs e)
        {
            sql.Open();

            cmb_selectquiz.Items.Clear();


            SQLiteCommand sqlc = new SQLiteCommand("select quiz_name from quizs", sql);

            SQLiteDataReader dtr = sqlc.ExecuteReader();

            while (dtr.Read())
            {
                cmb_selectquiz.Items.Add(dtr["quiz_name"].ToString());
            }

            sql.Close();
        }
    }
}
