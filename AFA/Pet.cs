using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFA
{
    public class Pet
    {
        List<int> consumption = new List<int>();
        public List<float> TotalConsumption = new List<float>();
        public string name;
        public Pet(string Name, List<int> c, int animal)
        {
            consumption = c;
            name = Name;
            Console.WriteLine("Starting New Pet");
        }

        public void WeeklyAvg()
        {
            float totalFood = 0;
            foreach (int amount in consumption)
            {
                totalFood += amount;
            }
            TotalConsumption.Add(totalFood/7);
            consumption.Clear();
        }
    }

}
