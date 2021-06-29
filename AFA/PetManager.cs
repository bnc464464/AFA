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
        public PetManager()
        {
        }

        public void LoadFoodSettings()
        {
            string[] lines = System.IO.File.ReadAllLines("FoodDetails.txt"); //get an array of lines from the text file

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

        public List<float> AvgPetWeeklys (int animalType)
        {
            int n = 0;
            List<float> AvgWeeklyValues = new List<float>(); //The final data point values
            List<float> AvgWeeklySums = new List<float>(); //The sums of all the pets in an animal category
            List<float> HowManyAnimals = new List<float>(); //Checks for the average how many animals were entered in a certain week

            for (int i = 0; i < totalPets.Count;) //For each of the pets
            {
                if (totalPets[i].animal == animalType) //If the pet is of the type selected
                {
                    while (n < totalPets[i].AverageDailyConsumption.Count) //For each week
                    {
                        if (AvgWeeklySums.Count < totalPets[i].AverageDailyConsumption.Count) //If the amount of weeks in weekly sums is less than the amount of amount of weeks in an animals food consumption records
                        {
                            AvgWeeklySums.Add(0);
                            HowManyAnimals.Add(0);
                        }
                        AvgWeeklySums[n] += totalPets[i].AverageDailyConsumption[n];
                        HowManyAnimals[n]++;
                        n++;
                    }
                }
                i++;
            }

            for (int i = 0; i < AvgWeeklySums.Count;)
            {
                AvgWeeklyValues.Add(AvgWeeklySums[i] / HowManyAnimals[i]);
                i++;
            }

            return AvgWeeklyValues;
        }
    }
}
