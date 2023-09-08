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
    #region CategoryCreateForm
    public partial class CategoryCreateForm : Form
    {

        #region Constructer
        public CategoryCreateForm()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント処理

        #region フォームロードイベント
        private void CategoryCreateClass_Load(object sender, EventArgs e)
        {

            // 学年コンボボックス値追加
            cmbYear.Items.AddRange(MasterForm._year.Cast<object>().ToArray());

            // 教科コンボボックス値追加
            cmbSubject.Items.AddRange(MasterForm._subject.Cast<object>().ToArray());
        }
        #endregion

        #region 作成ボタンクリックイベント
        private void btnCreateAnswer_Click(object sender, EventArgs e)
        {
            // 入力値検証

            // データインサート処理

            // 各地初期化
        }
        #endregion

        #region 閉じるボタンクリックイベント
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #endregion

        #region メソッド

        #region 入力値検証

        private bool inputValueValidation()
        {
            // 教科が選択されていない場合はエラー
            if (cmbSubject.SelectedIndex != -1)
            {
                MessageBox.Show("教科を正しく選択してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubject.Focus();
            }

            // 学年が選択されていない場合はエラー
            if (cmbYear.SelectedIndex != -1)
            {
                MessageBox.Show("学年を正しく選択してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbYear.Focus();
            }

            // 分野が入力されていない場合はエラー
            if ()


                return true;
        }



        #endregion

        #endregion
    }
    #endregion
}
