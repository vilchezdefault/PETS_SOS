using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS_SOS.DATA
{ 
	public class clReport
    {
        #region attributes
        private int id_report;

		public int id_report_prop
		{
			get { return id_report; }
			set { id_report = value; }
		}
		private string preview_symptoms;

		public string preview_symptoms_prop
		{
			get { return preview_symptoms; }
			set { preview_symptoms = value; }
		}

		private string diagnostic;

		public string diagnostic_prop
        {
			get { return  diagnostic; }
			set {  diagnostic = value; }
		}

		private string treatment;

		public string treatment_prop
        {
			get { return treatment; }
			set { treatment = value; }
		}

		private int carnet_pet;

		public int carnet_pet_prop
		{
			get { return carnet_pet; }
			set { carnet_pet = value; }
		}


        #endregion attributes 
    }

}
