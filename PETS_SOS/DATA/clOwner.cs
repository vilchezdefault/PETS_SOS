using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.DATA
{
	public class clOwner
	{
		#region attributes 
		private int privateid_user;

		public int privateid_user_prop
		{
			get { return privateid_user; }
			set { privateid_user = value; }
		}

		private string firstName;

		public string firstName_prop
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string second_name;

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

		private string second_lastname;

		public string second_lastname_prop
		{
			get { return second_lastname; }
			set { second_lastname = value; }
		}

		private int id_owner;

		public int id_owner_prop
		{
			get { return id_owner; }
			set { id_owner = value; }
		}

		private string email;

		public string email_prop
		{
			get { return email; }
			set { email = value; }
		}

		private string phone_number;

		public string phone_number_prop
		{
			get { return phone_number; ; }
			set { phone_number = value; }
		}
		#endregion attributes 

		#region builders
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

        #endregion builders

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
    }
}
