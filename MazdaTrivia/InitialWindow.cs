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
using System.IO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;




namespace MazdaTrivia
{
    public partial class InitialWindow : Form
    {
        public InitialWindow()
        {
            InitializeComponent();
        }

        public void updatescore()
        {
            lbl_result.Text = $"Your score is {GameState.score.ToString()} out of {DatabaseHelper.GetRowCount()}. Nice work!";
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Form_Trivia f2 = new Form_Trivia();

            var result = f2.ShowDialog(); // This freezes Form1 until Form2 closes

            this.Show();
            updatescore();
        }

        private void InitialWindow_Load(object sender, EventArgs e)
        {
            //if (GameState.played)
            //{
            //    lbl_result.Text = $"You got {GameState.score} out of {DatabaseHelper.GetRowCount()}! Nice work!";
            //}
            //else
            //{
            //    lbl_result.Text = "Your result will show up here once you're done playing the trivia. Good luck!";
            //    lbl_result.Enabled = false;
            //}
            DatabaseHelper.EnsureDatabaseExists();
        }

        private void btn_dev_Click(object sender, EventArgs e)
        {
            // create new form and hide the current one
            Form_Dev form_dev = new Form_Dev();
            form_dev.FormClosed += (s, args) => this.Hide();
            form_dev.Show();
            this.Close();
        }
    }
    public static class GameState
    {
        public static bool played = false;
        public static int score = 0;
    }
}
