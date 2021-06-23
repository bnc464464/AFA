using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFA
{
    public class Pet
    {
        public List<float> AverageDailyConsumption = new List<float>();
        public List<float> TotalWeeklyPrices = new List<float>();
        public string name;
        public int animal;
        public Pet(string Name, int type)
        {
            name = Name;
            animal = type;
        }

        public void WeeklyAvg(float c, float p)
        {
            AverageDailyConsumption.Add(c/7);
            TotalWeeklyPrices.Add(p);
        }
    }

}
