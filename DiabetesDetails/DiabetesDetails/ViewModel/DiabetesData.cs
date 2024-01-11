using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabetesDetails
{
    public class DiabetesData
    {
        public ObservableCollection<DiabetesModel> Data { get; set; }
        public ObservableCollection<DiabetesModel> USDetails { get; set; }
        public ObservableCollection<Brush> CustomBrushes { get; set; }

        public DiabetesData()
        {
            Data = new ObservableCollection<DiabetesModel>()
            {
                  new DiabetesModel("U.S", 1447298),
                  new DiabetesModel("India", 860423),
                  new DiabetesModel("Brazil", 588800),
                  new DiabetesModel("China", 448480),
                  new DiabetesModel("Germany", 431313),
                  new DiabetesModel("UK", 413042),
                  new DiabetesModel("Russia", 336901),
                  new DiabetesModel("Canada", 285324),
            };

            USDetails = new ObservableCollection<DiabetesModel>()
            {
                  new DiabetesModel(170408,"<20 years"),
                  new DiabetesModel(880937,"20 - 59 years"),
                  new DiabetesModel(397447,">= 60 years"),
            };

            CustomBrushes = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#086ec5")),
                new SolidColorBrush(Color.FromArgb("#0d5e9b")),
                new SolidColorBrush(Color.FromArgb("#0e385d")),
            };

            CalculatePercentage(USDetails);
        }

        static void CalculatePercentage(ObservableCollection<DiabetesModel> data)
        {
            // Calculate the total sum of all values
            double total = data.Sum(item => item.Count);

            // Calculate the percentage for each item and store it in the Count property
            foreach (var item in data)
            {
                item.Count = (item.Count / total) * 100;
            }
        }
    }
}