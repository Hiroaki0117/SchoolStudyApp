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

        #region ×ボタン無効化
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

        #region イベント処理

        #region フォームロードイベント
        private void Form1_Load(object sender, EventArgs e)
        {
            // ×ボタン無効化
            closeButtonBan();

            // SharedClassのインスタンス作成
            m_sharedClass = new SharedClass();

            // 全学年情報取得
            m_scoolInfoClasses = ScoolInfoClass.GetAll();

            // 学年の重複削除
            ////List<int> lsteYear = m_scoolInfoClasses.Select(school => school.Year).Distinct().ToList();

            // 教科の重複削除
            //List<string> lstSubject = m_scoolInfoClasses.Select(school => school.Subject).Distinct().ToList();

            // 学年コンボボックス値追加
            //cmbYear.Items.AddRange(m_sharedClass.Year.Cast<object>().ToArray());
            cmbYear.Items.AddRange(MasterForm._year.Cast<object>().ToArray());

            // 教科コンボボックス値追加
            //cmbSubject.Items.AddRange(m_sharedClass.Subject.Cast<object>().ToArray());
            cmbSubject.Items.AddRange(MasterForm._subject.Cast<object>().ToArray());

            // レベルコンボボックス値追加
            //cmbLevel.Items.AddRange(m_sharedClass.Level.Cast<object>().ToArray());
            cmbLevel.Items.AddRange(MasterForm._level.Cast<object>().ToArray());

            // ボタン使用不可設定
            //btnSelect.Enabled = false;
            btnCreateQuestion.Enabled = false;
            btnCreateAnswer.Enabled = false;

        }
        #endregion

        #region 絞り込みボタンクリックイベント
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
                MessageBox.Show("教科・学年・分野を正しく選択してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region 問題作成ボタンクリックイベント
        private async void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            // 教科・学年・分野が選択されているか確認
            if (cmbYear.SelectedIndex != -1 && cmbSubject.SelectedIndex != -1 && cmbSentence.SelectedIndex != -1)
            {
                // インスタンス作成
                m_createQuestion = new CreateQuestionClass(Convert.ToInt32(cmbYear.SelectedItem),
                                                                       cmbSubject.SelectedItem.ToString(),
                                                                       cmbSentence.SelectedItem.ToString(),
                                                                       cmbLevel.SelectedItem != null ? cmbLevel.SelectedItem.ToString() : "",
                                                                       "",
                                                                       true);

                // 問題文作成
                m_createQuestion.QuestionResponse = await OpenAIClass.getOpenAIResponse(m_createQuestion.Request);

                // 回答ラベルの文章を削除
                lblAnswer.Text = "";

                // 回答作成ボタン使用可能
                btnCreateAnswer.Enabled = true;

                // 問題作成ボタン使用不可
                btnCreateQuestion.Enabled = false;

                // 問題文をラベルに反映
                lblQuestion.Text = m_createQuestion.QuestionResponse;

            }
            else
            {
                MessageBox.Show("教科・学年・分野を正しく選択してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        #endregion

        #region 回答作成ボタンクリックイベント
        private async void btnCreateAnswer_Click(object sender, EventArgs e)
        {

            // 回答文作成
            m_createQuestion.AnswerResponse = await OpenAIClass.getOpenAIResponse(m_createQuestion.createAnser());

            // 回答文を羅べえるに反映
            lblAnswer.Text = m_createQuestion.AnswerResponse;

            // 問題作成ボタン使用可能
            btnCreateQuestion.Enabled = true;

            // 回答作成ボタン使用不可
            btnCreateAnswer.Enabled = false;
        }
        #endregion

        #region 閉じるボタンクリックイベント
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #endregion
    }
    #endregion

}