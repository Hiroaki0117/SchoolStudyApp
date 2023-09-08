namespace SchoolStudyApp
{
    partial class QuestionForm
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
            cmbSubject = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbYear = new ComboBox();
            label3 = new Label();
            lblQuestion = new Label();
            lblAnswer = new Label();
            btnSelect = new Button();
            cmbSentence = new ComboBox();
            btnCreateQuestion = new Button();
            label6 = new Label();
            btnCreateAnswer = new Button();
            label4 = new Label();
            cmbLevel = new ComboBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(44, 106);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(279, 20);
            label1.Name = "label1";
            label1.Size = new Size(178, 59);
            label1.TabIndex = 1;
            label1.Text = "学習部屋";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(44, 79);
            label2.Name = "label2";
            label2.Size = new Size(126, 24);
            label2.TabIndex = 2;
            label2.Text = "教科";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(203, 106);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(121, 23);
            cmbYear.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(198, 79);
            label3.Name = "label3";
            label3.Size = new Size(126, 24);
            label3.TabIndex = 4;
            label3.Text = "学年";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            lblQuestion.BorderStyle = BorderStyle.Fixed3D;
            lblQuestion.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.ForeColor = Color.CornflowerBlue;
            lblQuestion.Location = new Point(72, 263);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(646, 98);
            lblQuestion.TabIndex = 5;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            lblAnswer.BorderStyle = BorderStyle.Fixed3D;
            lblAnswer.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer.ForeColor = Color.CornflowerBlue;
            lblAnswer.Location = new Point(72, 409);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(646, 98);
            lblAnswer.TabIndex = 6;
            lblAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(358, 106);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "絞り込み";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // cmbSentence
            // 
            cmbSentence.FormattingEnabled = true;
            cmbSentence.Location = new Point(458, 107);
            cmbSentence.Name = "cmbSentence";
            cmbSentence.Size = new Size(260, 23);
            cmbSentence.TabIndex = 8;
            // 
            // btnCreateQuestion
            // 
            btnCreateQuestion.Location = new Point(319, 227);
            btnCreateQuestion.Name = "btnCreateQuestion";
            btnCreateQuestion.Size = new Size(150, 23);
            btnCreateQuestion.TabIndex = 9;
            btnCreateQuestion.Text = "問題作成";
            btnCreateQuestion.UseVisualStyleBackColor = true;
            btnCreateQuestion.Click += btnCreateQuestion_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(458, 79);
            label6.Name = "label6";
            label6.Size = new Size(126, 24);
            label6.TabIndex = 10;
            label6.Text = "分野";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreateAnswer
            // 
            btnCreateAnswer.Location = new Point(319, 373);
            btnCreateAnswer.Name = "btnCreateAnswer";
            btnCreateAnswer.Size = new Size(150, 23);
            btnCreateAnswer.TabIndex = 11;
            btnCreateAnswer.Text = "回答表示";
            btnCreateAnswer.UseVisualStyleBackColor = true;
            btnCreateAnswer.Click += btnCreateAnswer_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(730, 79);
            label4.Name = "label4";
            label4.Size = new Size(126, 24);
            label4.TabIndex = 12;
            label4.Text = "難易度";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbLevel
            // 
            cmbLevel.FormattingEnabled = true;
            cmbLevel.Location = new Point(764, 107);
            cmbLevel.Name = "cmbLevel";
            cmbLevel.Size = new Size(57, 23);
            cmbLevel.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(792, 514);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.TabStop = false;
            btnExit.Text = "閉じる";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 570);
            Controls.Add(btnExit);
            Controls.Add(cmbLevel);
            Controls.Add(label4);
            Controls.Add(btnCreateAnswer);
            Controls.Add(label6);
            Controls.Add(btnCreateQuestion);
            Controls.Add(cmbSentence);
            Controls.Add(btnSelect);
            Controls.Add(lblAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(label3);
            Controls.Add(cmbYear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbSubject);
            Name = "QuestionForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSubject;
        private Label label1;
        private Label label2;
        private ComboBox cmbYear;
        private Label label3;
        private Label lblQuestion;
        private Label lblAnswer;
        private Button btnSelect;
        private ComboBox cmbSentence;
        private Button btnCreateQuestion;
        private Label label6;
        private Button btnCreateAnswer;
        private Label label4;
        private ComboBox cmbLevel;
        private Button btnExit;
    }
}