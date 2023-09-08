using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SharedCommonClass;

namespace SchoolStudyApp
{
    # region QuestionForm   
    public partial class QuestionForm : Form
    {
        #region Private Instance
        private CreateQuestionClass m_createQuestion;

        private List<ScoolInfoClass> m_scoolInfoClasses;

        private SharedClass m_sharedClass;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);
        #endregion

        #region Constructer
        public QuestionForm()
        {
            InitializeComponent();

        }
        #endregion

        #region �~�{�^��������
        public void closeButtonBan()
        {
            const uint MF_BYPOSITION = 0x400;
            const uint MF_BYCOMMAND = 0x0;
            const uint SC_CLOSE = 0xF060;


            IntPtr systemMenu = GetSystemMenu(this.Handle, false);
            RemoveMenu(systemMenu, 5, MF_BYPOSITION);
            RemoveMenu(systemMenu, SC_CLOSE, MF_BYCOMMAND);

        }
        #endregion

        #region �C�x���g����

        #region �t�H�[�����[�h�C�x���g
        private void Form1_Load(object sender, EventArgs e)
        {
            // �~�{�^��������
            closeButtonBan();

            // SharedClass�̃C���X�^���X�쐬
            m_sharedClass = new SharedClass();

            // �S�w�N���擾
            m_scoolInfoClasses = ScoolInfoClass.GetAll();

            // �w�N�̏d���폜
            ////List<int> lsteYear = m_scoolInfoClasses.Select(school => school.Year).Distinct().ToList();

            // ���Ȃ̏d���폜
            //List<string> lstSubject = m_scoolInfoClasses.Select(school => school.Subject).Distinct().ToList();

            // �w�N�R���{�{�b�N�X�l�ǉ�
            //cmbYear.Items.AddRange(m_sharedClass.Year.Cast<object>().ToArray());
            cmbYear.Items.AddRange(MasterForm._year.Cast<object>().ToArray());

            // ���ȃR���{�{�b�N�X�l�ǉ�
            //cmbSubject.Items.AddRange(m_sharedClass.Subject.Cast<object>().ToArray());
            cmbSubject.Items.AddRange(MasterForm._subject.Cast<object>().ToArray());

            // ���x���R���{�{�b�N�X�l�ǉ�
            //cmbLevel.Items.AddRange(m_sharedClass.Level.Cast<object>().ToArray());
            cmbLevel.Items.AddRange(MasterForm._level.Cast<object>().ToArray());

            // �{�^���g�p�s�ݒ�
            //btnSelect.Enabled = false;
            btnCreateQuestion.Enabled = false;
            btnCreateAnswer.Enabled = false;

        }
        #endregion

        #region �i�荞�݃{�^���N���b�N�C�x���g
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1 && cmbSubject.SelectedIndex != -1)
            {
                List<string> lstSentence = m_scoolInfoClasses
                                           .Where(n => n.Year.Equals(Convert.ToInt32(cmbYear.SelectedItem)) && n.Subject.Equals(cmbSubject.SelectedItem))
                                           .Select(n => n.Sentence).ToList();


                cmbSentence.Items.AddRange(lstSentence.Cast<object>().ToArray());

                btnCreateQuestion.Enabled = true;
            }
            else
            {
                MessageBox.Show("���ȁE�w�N�E����𐳂����I�����Ă��������B", "�x��", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region ���쐬�{�^���N���b�N�C�x���g
        private async void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            // ���ȁE�w�N�E���삪�I������Ă��邩�m�F
            if (cmbYear.SelectedIndex != -1 && cmbSubject.SelectedIndex != -1 && cmbSentence.SelectedIndex != -1)
            {
                // �C���X�^���X�쐬
                m_createQuestion = new CreateQuestionClass(Convert.ToInt32(cmbYear.SelectedItem),
                                                                       cmbSubject.SelectedItem.ToString(),
                                                                       cmbSentence.SelectedItem.ToString(),
                                                                       cmbLevel.SelectedItem != null ? cmbLevel.SelectedItem.ToString() : "",
                                                                       "",
                                                                       true);

                // ��蕶�쐬
                m_createQuestion.QuestionResponse = await OpenAIClass.getOpenAIResponse(m_createQuestion.Request);

                // �񓚃��x���̕��͂��폜
                lblAnswer.Text = "";

                // �񓚍쐬�{�^���g�p�\
                btnCreateAnswer.Enabled = true;

                // ���쐬�{�^���g�p�s��
                btnCreateQuestion.Enabled = false;

                // ��蕶�����x���ɔ��f
                lblQuestion.Text = m_createQuestion.QuestionResponse;

            }
            else
            {
                MessageBox.Show("���ȁE�w�N�E����𐳂����I�����Ă��������B", "�x��", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        #endregion

        #region �񓚍쐬�{�^���N���b�N�C�x���g
        private async void btnCreateAnswer_Click(object sender, EventArgs e)
        {

            // �񓚕��쐬
            m_createQuestion.AnswerResponse = await OpenAIClass.getOpenAIResponse(m_createQuestion.createAnser());

            // �񓚕��𗅂ׂ���ɔ��f
            lblAnswer.Text = m_createQuestion.AnswerResponse;

            // ���쐬�{�^���g�p�\
            btnCreateQuestion.Enabled = true;

            // �񓚍쐬�{�^���g�p�s��
            btnCreateAnswer.Enabled = false;
        }
        #endregion

        #region ����{�^���N���b�N�C�x���g
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #endregion
    }
    #endregion

}