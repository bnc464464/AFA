using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace AFA
{
    public class PetManager
    {

        public List<Pet> totalPets = new List<Pet>();
        public PetManager()
        {

        }

        public List<DataPoint> AvgPetWeeklys (int animalType)
        {
            List<DataPoint> AvgWeeklyValues = new List<DataPoint>(); //The final data point values
            List<float> AvgWeeklySums = new List<float>(); //The sums of all the pets in 1 animal category
            List<float> HowManyAnimals = new List<float>(); //Checks for the average how many animals were entered in a certain week

            for (int i = 0; i < totalPets.Count;) //For each of the pets
            {
                if (totalPets[i].animal == animalType) //If the pet is of the type selected
                {
                    for (int n = 0; n < totalPets[i].TotalConsumption.Count;) //For each week
                    {
                        if (AvgWeeklySums.Count < totalPets[i].TotalConsumption.Count) //If the weekly sums didn't have the new weeks
                        {
                            AvgWeeklySums.Add(totalPets[i].TotalConsumption[n]);
                            HowManyAnimals.Add(1);
                        }
                        AvgWeeklySums[n] += totalPets[i].TotalConsumption[n];
                        HowManyAnimals[n]++;
                        n++;
                    }
                }
                i++;
            }

            for (int i = 0; i < AvgWeeklySums.Count;)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueY(AvgWeeklySums[i]/HowManyAnimals[i]);
                AvgWeeklyValues.Add(Dp);
                i++;
            }

            return AvgWeeklyValues;
        }
    }
}
