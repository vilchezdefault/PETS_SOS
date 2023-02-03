using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.DATA
{
    public class clUser
    {
        #region attributes N builders
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

		private int id_worker;

		public int id_worker_prop
		{
			get { return id_worker; }
			set { id_worker = value; }
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
			get { return phone_number;; }
			set { phone_number = value; }
		}
        #endregion attributes N builders
    }
}
