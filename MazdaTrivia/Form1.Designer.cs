namespace MazdaTrivia
{
    partial class Form_Trivia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_answer = new TextBox();
            lbl_question = new Label();
            lbl_correct = new Label();
            label1 = new Label();
            lbl_score = new Label();
            btn_nextquestion = new Button();
            lbl_qcount = new Label();
            SuspendLayout();
            // 
            // txt_answer
            // 
            txt_answer.Location = new Point(201, 203);
            txt_answer.Name = "txt_answer";
            txt_answer.Size = new Size(1155, 39);
            txt_answer.TabIndex = 0;
            // 
            // lbl_question
            // 
            lbl_question.AutoEllipsis = true;
            lbl_question.Location = new Point(201, 114);
            lbl_question.Name = "lbl_question";
            lbl_question.Size = new Size(1193, 64);
            lbl_question.TabIndex = 1;
            lbl_question.Text = "Who founded Mazda (formerly Toyo Cork Kogyo Co.) and was assumed the second president of the company?\r\n(Answer in [first name] [last name])";
            lbl_question.TextAlign = ContentAlignment.MiddleCenter;
            lbl_question.Click += label1_Click;
            // 
            // lbl_correct
            // 
            lbl_correct.AutoSize = true;
            lbl_correct.Location = new Point(188, 305);
            lbl_correct.Name = "lbl_correct";
            lbl_correct.Size = new Size(78, 32);
            lbl_correct.TabIndex = 2;
            lbl_correct.Text = "label2";
            lbl_correct.Click += answer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 262);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 3;
            label1.Text = "Press Enter to confirm";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Location = new Point(1414, 9);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(85, 32);
            lbl_score.TabIndex = 4;
            lbl_score.Text = "Score: ";
            // 
            // btn_nextquestion
            // 
            btn_nextquestion.Location = new Point(1402, 845);
            btn_nextquestion.Name = "btn_nextquestion";
            btn_nextquestion.Size = new Size(177, 46);
            btn_nextquestion.TabIndex = 5;
            btn_nextquestion.Text = "Next question";
            btn_nextquestion.UseVisualStyleBackColor = true;
            btn_nextquestion.Click += btn_nextquestion_Click;
            // 
            // lbl_qcount
            // 
            lbl_qcount.AutoSize = true;
            lbl_qcount.Location = new Point(35, 20);
            lbl_qcount.Name = "lbl_qcount";
            lbl_qcount.Size = new Size(78, 32);
            lbl_qcount.TabIndex = 6;
            lbl_qcount.Text = "label2";
            // 
            // Form_Trivia
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 903);
            Controls.Add(lbl_qcount);
            Controls.Add(btn_nextquestion);
            Controls.Add(lbl_score);
            Controls.Add(label1);
            Controls.Add(lbl_correct);
            Controls.Add(lbl_question);
            Controls.Add(txt_answer);
            Name = "Form_Trivia";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_answer;
        private Label lbl_question;
        private Label lbl_correct;
        private Label label1;
        private Label lbl_score;
        private Button btn_nextquestion;
        private Label lbl_qcount;
    }
}
