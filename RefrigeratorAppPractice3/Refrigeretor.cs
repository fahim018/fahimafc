using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrigeretor
    {
        public int MaxWeight { set; get; }
        public List<int> item = new List<int>();
        public List<int> weightPerUnit = new List<int>();
        
         public int sum = 0;
         int currentweight = 0;
         string it= "";
         string weight = "";
        string wu="";

       
        public int rw;

        public void AddItemWeight(int item, int weight)
        {

            
                this.item.Add(item);
                weightPerUnit.Add(weight);
            
           
        }

        public int CurrentWeight()
        {
        
            for (int i=0; i<weightPerUnit.Count; i++)
            {
               currentweight= item[i] * weightPerUnit[i];
               

            }
            sum = sum + currentweight;
            return sum;
            
        }

        public int RemainWeight()
        {
            rw = MaxWeight -sum;
            return rw;
        }
        public bool Checkadd()
        {

            if (MaxWeight > sum)
            {
                return true;
            }

            return false;
        }
        public bool Check()
        {
            
            if(MaxWeight<sum)
            {
                return false;
            }

            return true;
        }

        public string Itemreturn()
        {
            for(int i=0;i<item.Count; i++)
            {
                wu =Convert.ToString( item[i] * weightPerUnit[i]);
                it= Convert.ToString(item[i]);
                weight =Convert.ToString( weightPerUnit[i]);
                
            }
            return it+","+weight+","+wu ;
        }
        


    }
}
