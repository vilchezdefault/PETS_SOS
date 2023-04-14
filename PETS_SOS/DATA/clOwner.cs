using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.DATA
{
	public class clOwner
	{
		#region attributtes 
		
        private int privateid_user;
        private string second_name;
        private int id_owner;
        private string email;
        private string phone_number;
        private string firstName;
        private string second_lastname;
        private string addby;
        private string updateby;
        private string status;
        private DateTime addDate, updateDate;
        #endregion attributes 

        #region constructors
        public clOwner()
		{
			this.privateid_user_prop = 0;
			this.firstName_prop = "";
			this.second_name_prop = "";
			this.last_name_prop = "";
			this.second_lastname_prop = "";
			this.id_owner_prop = 0;
			this.email_prop = "";
			this.phone_number_prop = "";
		}

		public clOwner(int private_user, string firstName, string second_name,
					   string last_name, string second_lastanme_prop, int id_owner,
					   string email, string phone_number)
		{
			this.privateid_user_prop = private_user;
			this.firstName_prop = firstName;
			this.second_lastname_prop = second_name;
			this.id_owner_prop= id_owner;
			this.email_prop = email;
			this.phone_number_prop = phone_number;
		}
        //save
        public clOwner( int id_owner, string firstName, string second_name,
       string last_name, string second_lastanme_prop,
       string email, string phone_number, string addby, DateTime addDate, string status)
        {
            this.id_owner_prop = id_owner;
            this.firstName_prop = firstName;
            this.second_name = second_name;
            this.last_name_prop = last_name;
            this.second_lastname_prop = second_lastanme_prop;
            this.phone_number_prop = phone_number;
            this.email_prop = email;        
            this.addby = addby;
            this.addDate = addDate;
            this.status = status;
        }
        //update
        public clOwner(int id,int id_owner, string firstName, string second_name,
       string last_name, string second_lastanme_prop,
       string email, string phone_number, string updaby, DateTime updatedate,string status)
        {
            this.id_owner_prop = id_owner;
            this.firstName_prop = firstName;
            this.second_name = second_name;
            this.last_name_prop = last_name;
            this.second_lastname_prop = second_lastanme_prop;
            this.phone_number_prop = phone_number;
            this.email_prop = email;
            this.updateby = updaby;
            this.updateDate = updatedate;
            this.status = status;
        }

        #endregion constructors

        #region Functions
        public string printData()
		{
			string data = "";
			data = "Name" + this.firstName_prop + "" + this.second_name_prop + "\n" +
							this.last_name_prop + "" + this.second_lastname_prop + "\n" +
							"ID" + this.id_owner_prop + "\n" +
							"Email" + this.email_prop + "\n" +
							"Phone Number" + this.phone_number_prop + "\n";
			return data;
		}
        #endregion Functions

        #region Gets Sets
        public int privateid_user_prop
        {
            get { return privateid_user; }
            set { privateid_user = value; }
        }

        public string firstName_prop
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string second_name_prop
        {
            get { return second_name; }
            set { second_name = value; }
        }

        private string last_name;

        public string last_name_prop
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string second_lastname_prop
        {
            get { return second_lastname; }
            set { second_lastname = value; }
        }

        public int id_owner_prop
        {
            get { return id_owner; }
            set { id_owner = value; }
        }

        public string email_prop
        {
            get { return email; }
            set { email = value; }
        }

        public string phone_number_prop
        {
            get { return phone_number; ; }
            set { phone_number = value; }
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
