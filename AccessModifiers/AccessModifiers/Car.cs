using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Car
    {
        private string Brand { get; set; }
        public string Model { get; set; }
        protected int Speed;
        private int horsePower;
        //public readonly string color;
        public int Color { get; }

        #region Encapsulation - property
        public int HorsePower {
            get 
            {
                if (horsePower == 0)
                {
                    Console.WriteLine("Not set horse power yet");
                    return -1;
                }
                return horsePower;
            } 
            set 
            {
                if (value > 20)
                {
                    horsePower = value;
                    return;
                }
                Console.WriteLine("Horse Power must be more than 20");
            } 
        }
        #endregion

        #region Encapsulation- low level
        //public int GetHorsePower()
        //{
        //    if (horsePower == 0)
        //    {
        //        Console.WriteLine("Not set horse power yet");
        //        return -1;
        //    }
        //    return horsePower;
        //}

        //public void SetHorsePower(int power)
        //{
        //    if (power > 20)
        //    {
        //        horsePower = power;
        //        return;
        //    }
        //    Console.WriteLine("Horse Power must be more than 20");
        //}
        #endregion


        public Car()
        {
            color = "red";
            //Console.WriteLine("car created");
        }

        public Car(string brand,string model):this()
        {
            Brand = brand;
            Model = model;
        }

        public string Info()
        {
            return $"{Brand} {Model} {Speed} {color}";
        }
    }
}
