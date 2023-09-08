using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using MySQLConnection;

namespace SchoolStudyApp
{

    internal class ScoolInfoClass
    {
        #region PrivateInstance
        private int _intId;
        private int _intYear;
        private string _strSubject;
        private string _strSentence;
        private string _strCreatetime;
        private string _strCreateuser;
        private string _strUpdatetime;
        private string _strUpdateuser;
        #endregion

        #region Property
        public  int Id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        public int Year
        {
            get { return _intYear; }
            set { _intYear = value; }
        }
        public string Subject
        {
            get { return _strSubject; }
            set { _strSubject = value; }
        }

        public string Sentence
        {
            get { return _strSentence; }
            set { _strSentence = value; }
        }

        public string Createtime
        {
            get { return _strCreatetime; }
            set { _strCreatetime = value;}
        }
        public string Createuser
        {
            get { return _strCreateuser; }
            set { _strCreateuser = value; }
        }

        public string Upstring
        {
            get { return _strUpdatetime; }
            set { _strUpdatetime = value; }
        }
        public string Updateuser
        {
            get { return _strUpdateuser; }
            set { _strUpdateuser = value; }
        }


        #endregion

        #region Constructer
        public ScoolInfoClass(int intId, 
                              int intYear,
                              string strSubject,
                              string strSentence,
                              string strCreatetime,
                              string strCreateUser,
                              string strUpdatetime,
                              string strUpdateUser)
        {
            _intId = intId;
            _intYear = intYear;
            _strSubject = strSubject;
            _strSentence = strSentence;
            _strCreatetime = strCreatetime;
            _strCreateuser = strCreateUser;
            _strUpdatetime = strUpdatetime;
            _strUpdateuser = strUpdateUser;
        }
        #endregion


        public static List<ScoolInfoClass> GetAll()
        {


            List<ScoolInfoClass> schoolInfoList = new List<ScoolInfoClass>();
            MySQLConnectionClass clsMySQL = new MySQLConnectionClass();

            try
            {



                // 実行するSQL
                var sql = "SELECT * FROM schoolinfo ";
                var reader = clsMySQL.GetData(sql);


                if (reader != null)
                {

                    // SELECT文を実行し、結果を1行ずつコンソールに表示
                    while (reader.Read())
                    {
                        ScoolInfoClass schoolInfo = new ScoolInfoClass(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToInt32(reader["year"]),
                            reader["subject"].ToString(),
                            reader["sentence"].ToString(),
                            reader["createtime"].ToString(),
                            reader["createuser"].ToString(),
                            reader["updatetime"].ToString(),
                            reader["updateuser"].ToString());

                        schoolInfoList.Add(schoolInfo);
                    }
                }

                return schoolInfoList;
            }
            catch (Exception ex) 
            {
                return null;
            }
            finally 
            {
                clsMySQL.MySQLDisconnect();
            }

        }

        public static void InsertData(List<ScoolInfoClass> scoolInfoData)
        {

        }
    }

}
