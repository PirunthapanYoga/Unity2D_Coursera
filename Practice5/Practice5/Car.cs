using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{\
    internal class Car
    {
        public string brandName { 
            get{
                return brandName;
            }
            set{ 
                brandName = value;
            } 
        }


        public string name { get; set; }
        public int yearOfManufacture { get; set; }
        public string colour { get; set; }

        public Car()
        {

        }

    }

    internal class Electric : Car
    {
        public string type { get; set; }
    }

    internal class programme
    {
        static void Main(string[] args)
        {
            Car car1 = new Electric();
            Electric car2 = new Electric();

            car1.brandName = "Ford";
            car2.brandName = "Tesla";
            car2.type = "ALL ELECTRIC";

            Console.WriteLine(car1.brandName);
            Console.WriteLine(car2.brandName);
            Console.WriteLine(car2.type);
            Console.WriteLine(car1.type);

            
        }
    }
}
