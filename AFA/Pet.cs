using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFA
{
    public class Pet
    {
        // store vars
        public List<int> TotalWeeklyConsumption = new List<int>();
        public List<float> TotalWeeklyPrices = new List<float>();
        public string name;
        public int animal;
        public int weekIntercept;
        public Pet(string Name, int type, int week)
        {
            // save these
            name = Name;
            animal = type;
            weekIntercept = week;
        }

        public void WeeklySaving(int c, float p)
        {
            // add new week of info
            TotalWeeklyConsumption.Add(c);
            TotalWeeklyPrices.Add(p);
        }
    }

}
