using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCommonClass
{
    internal class SharedClass
    {
        #region PrivateInstance
        private List<string> lstYear = new List<string>();
        private List<string> lstLevel = new List<string>();
        private List<string> lstSubject = new List<string>();
        #endregion

        #region Property
        public List<string> Year
        {
            get { return lstYear; }
        }

        public List<string> Level
        {
            get { return lstLevel; }
        }

        public List<string> Subject
        {
            get { return lstSubject; }
        }

        public static string connectionString
        {
            get
            {
                return "Server=localhost;User ID=hiroaki0117;Password=nahn0117;Database=school";
            }
        }
        #endregion

        #region Constructer
        public SharedClass()
        {

            lstYear.Add("1");
            lstYear.Add("2");
            lstYear.Add("3");
            lstYear.Add("4");
            lstYear.Add("5");
            lstYear.Add("6");


            lstLevel.Add("すごく優しい");
            lstLevel.Add("優しい");
            lstLevel.Add("普通");
            lstLevel.Add("少し難しい");
            lstLevel.Add("難しい");
            lstLevel.Add("すごく難しい");


            lstSubject.Add("国語");
            lstSubject.Add("算数");
            lstSubject.Add("理科");
            lstSubject.Add("社会");
            lstSubject.Add("英語");
        }
        #endregion

    }
}
