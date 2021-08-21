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
        public List<float> TotalWeeklyConsumption = new List<float>();
        public List<float> TotalWeeklyPrices = new List<float>();
        public string name;
        public int animal;
        public int weekIntercept;
        public Pet(string copyOfName, int type, int week)
        {
            // save these
            name = copyOfName;
            animal = type;
            weekIntercept = week;
        }

        public void WeeklySaving(float c, float p)
        {
            // add new week of info
            TotalWeeklyConsumption.Add(c);
            TotalWeeklyPrices.Add(p);
        }
    }

}
