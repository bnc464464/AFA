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
        public Pet(string name, List<int> c, int animal)
        {
            consumption = c;
        }

        public float WeeklyAvg()
        {
            float totalFood = 0;
            foreach (int amount in consumption)
            {
                totalFood += amount;
            }
            return totalFood / 7;
        }
    }

}
