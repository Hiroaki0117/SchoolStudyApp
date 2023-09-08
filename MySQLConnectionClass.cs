using MySqlConnector;
using SharedCommonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MySQLConnection
{
    internal class MySQLConnectionClass
    {
        #region PrivateInstance
        private protected MySqlConnection m_MySQLConnection;
        #endregion

        #region MySQL接続
        public bool MySQLConnect()
        {
            // インスタンス作成
            m_MySQLConnection = new MySqlConnection();

            try
            {
                m_MySQLConnection.ConnectionString = SharedClass.connectionString;
                m_MySQLConnection.Open();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion

        #region MySQL接続解除
        public bool MySQLDisconnect()
        {
            if (m_MySQLConnection != null)
            {
                m_MySQLConnection.Close();
                m_MySQLConnection.Dispose();
                m_MySQLConnection = null;
            }
            return true;
        }
        #endregion

        #region データ取得処理
        public MySqlDataReader GetData(string sql)
        {

            try
            {

                if (MySQLConnect())
                {


                    MySqlCommand sqlCommand = new MySqlCommand(sql, m_MySQLConnection);

                    MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                            
                    return sqlDataReader; 
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #region データ登録処理
        public bool InsertData(string sql)
        {

            try
            {
                if (MySQLConnect())
                {
                    MySqlCommand sqlCommand = new MySqlCommand(sql, m_MySQLConnection);

                    int result = sqlCommand.ExecuteNonQuery();

                    if (result != 1)
                    {
                        return false;
                    }

                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                MySQLDisconnect();
            }
        }
        #endregion
    }
}
