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
using System.IO;

namespace MazdaTrivia
{
    public partial class Form_Dev : Form
    {
        public Form_Dev()
        {
            InitializeComponent();
        }

        public string dbPath = "TriviaDB.db";

        private void Form_Dev_Load(object sender, EventArgs e)
        {
            lbl_verify.Text = "";
            using var con = new SQLiteConnection($"Data Source={"TriviaDB.db"};Version=3;");
            con.Open();

            string sql = "SELECT * FROM TriviaDB";
            using var cmd = new SQLiteCommand(sql, con);
            using var adapter = new SQLiteDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt); // Fill the DataTable with the results of the query

            dataGridView1.DataSource = dt; // Show it in the grid

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string question = selectedRow.Cells["Question"].Value.ToString();
                string answer = selectedRow.Cells["Answer"].Value.ToString();
                txt_question_disp.Text = question;
                txt_answer_disp.Text = answer;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_answer_disp.Text == "" | txt_question_disp.Text == "")
            {
                lbl_verify.Text = "Both the question and answer cannot be empty";
                return;
            }

            DatabaseHelper.InsertRow(txt_question_disp.Text, txt_answer_disp.Text);
            updatedgv();
            emptytxt();
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            File.Delete("TriviaDB.db");
            updatedgv();
            emptytxt();
        }

        public void emptytxt()
        {
            txt_answer_disp.Text = "";
            txt_question_disp.Text = "";
        }

        public void updatedgv()
        {
            DatabaseHelper.EnsureDatabaseExists();
            using var con = new SQLiteConnection($"Data Source={"TriviaDB.db"};Version=3;");
            con.Open();

            string sql = "SELECT * FROM TriviaDB";
            using var cmd = new SQLiteCommand(sql, con);
            using var adapter = new SQLiteDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt); // Fill the DataTable with the results of the query

            dataGridView1.DataSource = dt; // Show it in the grid
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            DatabaseHelper.UpdateRow(id, txt_question_disp.Text, txt_answer_disp.Text);
            updatedgv();
            emptytxt();
        }
    }
}
