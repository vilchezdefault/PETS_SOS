using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.DATA
{
    public class clsUser
    {
        #region Attributtes
        private string UserName;
        private string password;
        private string addby;
        private string updateby;
        private string status;
        private DateTime addDate, updateDate;
        #endregion Attibutes
        #region constructors

        public clsUser()
        {
            this.UserName = "";
            this.password = "";
            
            
        }

        public clsUser(string UserName, string Password)
        {
            this.UserName = UserName;
            this.password = Password;
            

        }

        public clsUser(string UserName, string Password,string status,string addby,DateTime addDate)
        {
            this.UserName = UserName;
            this.password = Password;
            this.status = status;
            this.addby = addby;
            this.addDate = addDate;

        }

        #endregion constructors
        #region Functioons or procedures
        public string printData()
        {
            string data = "";
            data = "Username" + this.UserName + "\n" +
                   "Password" + this.password + "\n";
            return data;
        }
        #endregion  Function or procedures
        #region Gets & Set
        public string UserName_prop
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public string Password_prop
        {
            get { return password; }
            set { password = value; }
        }

        public string Addby
        {
            set { addby = value; }
            get { return addby; }
        }
        public string Updateby
        {
            set { updateby = value; }
            get { return updateby; }
        }
        public DateTime AddDate
        {
            set { addDate = value; }
            get { return addDate; }
        }
        public DateTime UpdateDate
        {
            set { updateDate = value; }
            get { return updateDate; }
        }
        public string Status
        {
            set { status = value; }
            get { return status; }
        }
        #endregion
    }
}

