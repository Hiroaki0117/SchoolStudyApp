namespace SchoolStudyApp
{
    partial class MasterForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(278, 20);
            label1.Name = "label1";
            label1.Size = new Size(178, 59);
            label1.TabIndex = 2;
            label1.Text = "学習部屋";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(303, 141);
            button1.Name = "button1";
            button1.Size = new Size(118, 34);
            button1.TabIndex = 3;
            button1.Text = "問題を解く";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Question_Click;
            // 
            // button2
            // 
            button2.Location = new Point(48, 141);
            button2.Name = "button2";
            button2.Size = new Size(118, 34);
            button2.TabIndex = 4;
            button2.Text = "学年の編集";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(48, 275);
            button3.Name = "button3";
            button3.Size = new Size(118, 34);
            button3.TabIndex = 5;
            button3.Text = "分野の追加";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CategoryCreate;
            // 
            // button4
            // 
            button4.Location = new Point(48, 191);
            button4.Name = "button4";
            button4.Size = new Size(118, 34);
            button4.TabIndex = 6;
            button4.Text = "教科の編集";
            button4.UseVisualStyleBackColor = true;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MasterForm";
            Text = "MasterForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}