namespace MazdaTrivia
{
    partial class InitialWindow
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
            label1 = new Label();
            btn_Start = new Button();
            btn_dev = new Button();
            lbl_result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 216);
            label1.Name = "label1";
            label1.Size = new Size(654, 96);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Mazda Trivia, created by Kazuaki Shirakata! \r\nPress the button below to start the quiz.\r\nGood luck!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(531, 360);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(257, 128);
            btn_Start.TabIndex = 1;
            btn_Start.Text = "Start!";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_dev
            // 
            btn_dev.Location = new Point(1233, 745);
            btn_dev.Name = "btn_dev";
            btn_dev.Size = new Size(150, 46);
            btn_dev.TabIndex = 2;
            btn_dev.Text = "Developer";
            btn_dev.UseVisualStyleBackColor = true;
            btn_dev.Click += btn_dev_Click;
            // 
            // lbl_result
            // 
            lbl_result.Location = new Point(258, 554);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(838, 32);
            lbl_result.TabIndex = 3;
            lbl_result.Text = "label2";
            lbl_result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InitialWindow
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(1395, 803);
            Controls.Add(lbl_result);
            Controls.Add(btn_dev);
            Controls.Add(btn_Start);
            Controls.Add(label1);
            Name = "InitialWindow";
            Text = "Welcome!";
            Load += InitialWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Start;
        private Button btn_dev;
        private Label lbl_result;
    }
}