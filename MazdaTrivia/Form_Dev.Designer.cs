namespace MazdaTrivia
{
    partial class Form_Dev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txt_question_disp = new TextBox();
            txt_answer_disp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_verify = new Label();
            btn_add = new Button();
            btn_deleteall = new Button();
            btn_edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 58);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1419, 627);
            dataGridView1.TabIndex = 0;
            // 
            // txt_question_disp
            // 
            txt_question_disp.Location = new Point(159, 802);
            txt_question_disp.Name = "txt_question_disp";
            txt_question_disp.Size = new Size(1247, 39);
            txt_question_disp.TabIndex = 1;
            // 
            // txt_answer_disp
            // 
            txt_answer_disp.Location = new Point(159, 874);
            txt_answer_disp.Name = "txt_answer_disp";
            txt_answer_disp.Size = new Size(1247, 39);
            txt_answer_disp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 767);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 3;
            label1.Text = "Question?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 839);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 4;
            label2.Text = "Answer?";
            // 
            // lbl_verify
            // 
            lbl_verify.AutoSize = true;
            lbl_verify.Location = new Point(159, 920);
            lbl_verify.Name = "lbl_verify";
            lbl_verify.Size = new Size(78, 32);
            lbl_verify.TabIndex = 5;
            lbl_verify.Text = "label3";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(1438, 798);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(150, 46);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_deleteall
            // 
            btn_deleteall.Location = new Point(1438, 961);
            btn_deleteall.Name = "btn_deleteall";
            btn_deleteall.Size = new Size(150, 46);
            btn_deleteall.TabIndex = 7;
            btn_deleteall.Text = "Delete All";
            btn_deleteall.UseVisualStyleBackColor = true;
            btn_deleteall.Click += btn_deleteall_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(1438, 870);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(150, 46);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // Form_Dev
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 1052);
            Controls.Add(btn_edit);
            Controls.Add(btn_deleteall);
            Controls.Add(btn_add);
            Controls.Add(lbl_verify);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_answer_disp);
            Controls.Add(txt_question_disp);
            Controls.Add(dataGridView1);
            Name = "Form_Dev";
            Text = "Form_Dev";
            Load += Form_Dev_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txt_question_disp;
        private TextBox txt_answer_disp;
        private Label label1;
        private Label label2;
        private Label lbl_verify;
        private Button btn_add;
        private Button btn_deleteall;
        private Button btn_edit;
    }
}