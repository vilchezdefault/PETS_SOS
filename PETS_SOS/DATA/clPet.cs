﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.DATA
{
    public class clPet
    {
        #region attributes 
        private int carnet;
        private string name;
        private char gender;
        private double weight;
        private string allergies;
        private int owner;
        #endregion attributes 

        #region constructors
        public clPet()
		{
			this.carnet = 0;
			this.name_prop = "";
			this.gender_prop = '*';
			this.weight_prop = 0;
			this.allergies_prop = "";
			this.owner_prop = 0;
		}

		public clPet(int carnet_prop, string name_prop,
					char gender_prop,  double weight_prop,
					string allergies_prop,  int owner_prop)
        {
            this.carnet_prop = carnet_prop;
            this.name_prop = name_prop;
            this.gender_prop = gender_prop;
            this.weight_prop = weight_prop;
            this.allergies_prop = allergies_prop;
            this.owner_prop = owner_prop;
        }


        #endregion constructors

        #region Functions
        public string printData()
		{
			string data = "";
			data = "Name" + this.name_prop +
				"Gender" + this.gender_prop +
				"Weight" + this.weight_prop +
				"Allergies" + this.allergies_prop + "\n" +
				"Owner ID" + this.owner_prop;
			return data;


        }

        #endregion Functions

        #region Gets N Sets
        public int carnet_prop
        {
            get { return carnet; }
            set { carnet = value; }
        }

        public string name_prop
        {
            get { return name; }
            set { name = value; }
        }

        public char gender_prop
        {
            get { return gender; }
            set { gender = value; }
        }

        public double weight_prop
        {
            get { return weight; }
            set { weight = value; }
        }

        public string allergies_prop
        {
            get { return allergies; }
            set { allergies = value; }
        }
        public int owner_prop
        {
            get { return owner; }
            set { owner = value; }
        }
        #endregion
    }

}
