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
        public static int[,] petFood = new int[4, 2];
        public List<Pet> totalPets = new List<Pet>();
        public int weeksSinceStartup = 0;

        public void LoadFoodSettings()
        {
            string[] lines = System.IO.File.ReadAllLines("FoodDetails.txt"); // get an array of lines from the text file

            for (int n = 0; n < 4;)
            {
                string[] stringPetData = lines[n].Split(',');

                for (int i = 0; i <= 1;)
                {
                    petFood[n, i] = Convert.ToInt32(stringPetData[i]);
                    i++;
                }
                n++;
            }
        }

        // these need to be here to be referenced in different pages, but will be different for each animal type
        public List<float> WeeklyFoodTotals = new List<float>(); // the sums of all the pets in an animal category
        public List<float> totalWeekCost = new List<float>();
        public void AvgPetWeeklys(int animalType)
        {
            WeeklyFoodTotals.Clear(); // clear for each different animal type, cant have old data infecting other data sources
            totalWeekCost.Clear();

            for (int i = 0; i < totalPets.Count; i++) // for each of the pets
            {
                int n = 0;
                if (totalPets[i].animal == animalType) // if the pet is of the type selected
                {
                    while (n < totalPets[i].TotalWeeklyConsumption.Count) // for each week
                    {
                        while (WeeklyFoodTotals.Count < totalPets[i].TotalWeeklyConsumption.Count + totalPets[i].weekIntercept) // if the amount of weeks in weekly sums is less than the amount of weeks in an animals food consumption records plus the time intercept
                        {                                                                         // in other words if the list is too short
                            WeeklyFoodTotals.Add(0);
                            totalWeekCost.Add(0);
                        }
                        WeeklyFoodTotals[n+totalPets[i].weekIntercept] += totalPets[i].TotalWeeklyConsumption[n]; // values being added to the lists[weeknum plus time intercept]
                        totalWeekCost[n+totalPets[i].weekIntercept] += totalPets[i].TotalWeeklyPrices[n];
                        n++;
                    }
                }
            }

            for (int i = 0; i < WeeklyFoodTotals.Count; i++) // fix up any missing values
                if (!(WeeklyFoodTotals[i] > 0))
                    WeeklyFoodTotals[i] = 0;
        }
    }
}
