namespace SchoolStudyApp
{
    partial class CategoryCreateForm
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
            cmbYear = new ComboBox();
            cmbSubject = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txt = new TextBox();
            label1 = new Label();
            btnCreateAnswer = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(259, 128);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(121, 23);
            cmbYear.TabIndex = 1;
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(92, 128);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(259, 91);
            label3.Name = "label3";
            label3.Size = new Size(126, 24);
            label3.TabIndex = 7;
            label3.Text = "学年";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(92, 91);
            label2.Name = "label2";
            label2.Size = new Size(126, 24);
            label2.TabIndex = 6;
            label2.Text = "教科";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt
            // 
            txt.Location = new Point(92, 230);
            txt.Name = "txt";
            txt.Size = new Size(497, 23);
            txt.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(92, 198);
            label1.Name = "label1";
            label1.Size = new Size(126, 24);
            label1.TabIndex = 9;
            label1.Text = "分野";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreateAnswer
            // 
            btnCreateAnswer.Location = new Point(326, 317);
            btnCreateAnswer.Name = "btnCreateAnswer";
            btnCreateAnswer.Size = new Size(150, 23);
            btnCreateAnswer.TabIndex = 3;
            btnCreateAnswer.Text = "作成";
            btnCreateAnswer.UseVisualStyleBackColor = true;
            btnCreateAnswer.Click += btnCreateAnswer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(665, 394);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 15;
            btnExit.TabStop = false;
            btnExit.Text = "閉じる";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // CategoryCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCreateAnswer);
            Controls.Add(label1);
            Controls.Add(txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbYear);
            Controls.Add(cmbSubject);
            Name = "CategoryCreateForm";
            Text = "CategoryCreateClass";
            Load += CategoryCreateClass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbYear;
        private ComboBox cmbSubject;
        private Label label3;
        private Label label2;
        private TextBox txt;
        private Label label1;
        private Button btnCreateAnswer;
        private Button btnExit;
    }
}