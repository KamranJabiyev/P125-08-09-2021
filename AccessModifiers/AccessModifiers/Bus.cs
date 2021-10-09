using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Bus:Car
    {
        public int PassengerCount { get; set; }
        public Bus()
        {

        }
        public Bus(string brand,string model):base(brand,model)
        {
            Brand = "asddf";
            Speed = 50;
            Console.WriteLine(Info());
            Console.WriteLine(Speed);
        }
    }
}
