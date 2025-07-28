namespace MazdaTrivia
{
    public partial class Form_Trivia : Form
    {
        public Form_Trivia()
        {
            InitializeComponent();
            txt_answer.KeyPress += new KeyPressEventHandler(answer_text_KeyPress);
        }

        public string UpdatedLabelText { get; private set; }
        List<string> CurrentQuesAns = new List<string>(2); // storing the current question and answer
        int score;
        int CurrentQuestion = 1;

        public bool lastq()
        {
            return CurrentQuestion == DatabaseHelper.GetRowCount();
        }

        public void resetq()
        {
            lbl_correct.Text = "";
            DatabaseHelper.EnsureDatabaseExists();
            var (question, answer) = DatabaseHelper.GetRandomQuestion();
            lbl_question.Text = question;
            CurrentQuesAns = [question, answer]; // storing in global variable
            lbl_qcount.Text = $"Question: {CurrentQuestion} / {DatabaseHelper.GetRowCount()}";

            btn_nextquestion.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameState.played = true;
            lbl_score.Text = $"Score: {score}/{DatabaseHelper.GetRowCount()}";
            resetq();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool keyPressEnabled = true;

        private void answer_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyPressEnabled)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    if (txt_answer.Text == CurrentQuesAns[1])
                    {
                        lbl_correct.Text = "Correct!";
                        score += 1;
                        keyPressEnabled = false;
                    }
                    else
                    {
                        lbl_correct.Text = "Wrong! Click here to reveal answer.";
                    }
                    if (lastq())
                    {
                        GameState.played = true;
                        GameState.score = score;
                        UpdatedLabelText = GameState.score.ToString();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        btn_nextquestion.Enabled = true;
                    }
                        
                }
                lbl_score.Text = $"Score: {score}/{DatabaseHelper.GetRowCount()}";

            }
            else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void answer_Click(object sender, EventArgs e)
        {
            txt_answer.Text = CurrentQuesAns[1];
        }

        private void btn_nextquestion_Click(object sender, EventArgs e)
        {
            CurrentQuestion += 1;
            resetq();
            keyPressEnabled = true;
            txt_answer.Text = "";
        }
    }
}
