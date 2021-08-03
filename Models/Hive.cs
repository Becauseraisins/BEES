using System.Collections.Generic;
using Bees2.Models;
namespace Bees2.Models
{
    public class Hive
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Bee> Bees { get; set; }

        public Hive(string name, int capacity)
         {
            this.Name = name;
            this.Capacity = capacity;
            this.Bees = new List<Bee>();
         }

        public float collecthoney(int days){
            float count = 0;
            float honey = 0;
            for (int i = 0; i < this.Bees.Count; i++)
            {
            count = count + this.Bees[i].Size; 
            }
            honey = (count*days)*0.2f;
            return honey;
         }

    }
}