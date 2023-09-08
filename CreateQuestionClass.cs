# region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace SchoolStudyApp
{
    #region WordPressFormatClass
    internal class CreateQuestionClass
    {
        #region PrivateInstance
        private int m_year;
        private string m_subject;
        private string m_sentence;
        private string m_level;
        private string m_request;
        private string m_QuestionResponse;
        private string m_AnswerResponse;
        private bool m_reqFlg;
        #endregion

        #region Constractor
        //public CreateQuestionClass(string request,
        //                           string response)
        //{
        //    m_request = request;
        //    m_QuestionResponse = response;
        //}

        public CreateQuestionClass(int year, string subject, string sentence, string level, string response, bool reqFlg)
        {
            m_year = year;
            m_subject = subject;
            m_sentence = sentence;

            if (level != "")
            {

                m_level = level;
            }
            else
            {
                m_level = "普通";
            }

            m_request = createQuestion();
            m_QuestionResponse = "";
            m_reqFlg = reqFlg;
        }


        #endregion

        #region Property

        public String Request
        {
            get { return m_request; }
            set { m_request = value; }
        }

        public String QuestionResponse
        {
            get { return m_QuestionResponse; }
            set { m_QuestionResponse = value; }
        }

        public String AnswerResponse
        {
            get { return m_AnswerResponse; }
            set { m_AnswerResponse = value; }
        }
        #endregion

        #region Method
        public string getFormatContent()
        {
            return m_QuestionResponse;
        }

        public string createQuestion()
        {
            string prompt = "あなたは小学校" + m_year.ToString() + "年生の先生です。";
            prompt += "教科は" + m_subject + "、分野は" + m_sentence + "、難易度は" + m_level + "\r\n";
            prompt += "この問題を一問出題してください。以下に制約を書きます\r\n";
            prompt += "1.「問題：」を最初につけてください。\r\n";
            prompt += "2.出来るだけ簡潔に問題を作成してください\r\n";
            prompt += "3.文字数は30文字以内でお願いします。\r\n";
            prompt += "4.行数は3行まででお願いします。\r\n";
            prompt += "5.回答例が必ず一通りになるようにお願いします。\r\n";

            m_request = prompt;
            return prompt;
        }

        public string createAnser()
        {
            string propt = "先ほど作成してくれた[" + m_QuestionResponse + "]の回答を作成してください(説明は不要です。簡潔にお願いします。回答だけ作成して下さい。)";
            return propt;

        }
        #endregion

    }
    #endregion
}
