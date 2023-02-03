using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.DATA
{
    internal class clPet
    {
        #region attributes N builders
        private int carnet;

		public int carnet_prop
		{
			get { return carnet; }
			set { carnet = value; }
		}
		private string name;

		public string name_prop
		{
			get { return name; }
			set { name = value; }
		}
		private char gender;

		public char gender_prop
        {
			get { return gender; }
			set { gender = value; }
		}
		private double weight;

		public double weight_prop
        {
			get { return weight; }
			set { weight = value; }
		}

		private string allergies;

		public string allergies_prop
        {
			get { return allergies; }
			set { allergies = value; }
		}
		private int owner;

		public int owner_prop
		{
			get { return owner; }
			set { owner = value; }
		}
        #endregion attributes N builders
    }

}
