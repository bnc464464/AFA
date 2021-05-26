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
        public int animal;
        public Pet(string Name, int type)
        {
            name = Name;
            animal = type;
        }

        public void WeeklyAvg(List<int> c)
        {
            consumption = c;
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
