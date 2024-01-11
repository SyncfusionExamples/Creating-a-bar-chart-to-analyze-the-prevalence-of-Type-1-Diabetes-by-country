using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesDetails
{
    public class DiabetesModel
    {
        public string Country { get; set; }
        public double Value { get; set; }
        public string AgeCategory {  get; set; }
        public double Count {  get; set; }

        public DiabetesModel(string country, double value)
        {
            Country = country;
            Value = value;
        }

        //It is used to store the age-wise distribution of type 1 diabetes in the US
        public DiabetesModel(double count, string ageCategory)
        {
            Count = count;
            AgeCategory = ageCategory;
        }
    }
}
