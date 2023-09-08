using SharedCommonClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolStudyApp
{
    public partial class MasterForm : Form
    {
        public static readonly List<string> _level = new SharedClass().Level;
        public static readonly List<string> _year = new SharedClass().Year;
        public static readonly List<string> _subject = new SharedClass().Subject;
        public MasterForm()
        {
            InitializeComponent();
        }

        private void Question_Click(object sender, EventArgs e)
        {

            QuestionForm frmQuestionForm = new QuestionForm();
            frmQuestionForm.Show();
        }

        private void CategoryCreate(object sender, EventArgs e)
        {
            CategoryCreateForm frmCategoryCreateForm = new CategoryCreateForm();
            frmCategoryCreateForm.Show();
        }
    }
}
