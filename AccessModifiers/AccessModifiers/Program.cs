using System;
using System.Reflection;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Public - class, all class members(fields,methods,property)
            //Car car = new Car();
            //car.Brand = "BMW";
            //Console.WriteLine(car.Brand);
            //Console.WriteLine(car.Info());
            #endregion

            #region Protected - all class members
            //Car car = new Car();
            //car.Brand = "";
            #endregion

            #region Private - all class members
            //Car car = new Car();
            //typeof(Car).GetField("horsePower", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(car, 111);
            //var horsePower = typeof(Car).GetField("horsePower", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(car);
            //Console.WriteLine(horsePower);
            #endregion

            #region Encapsulation
            //Car car = new Car();
            //car.HorsePower = 300;
            //Console.WriteLine(car.HorsePower);
            #endregion

            #region Readonly
            Car car = new Car();
            Console.WriteLine(car.color);
            #endregion
        }
    }
}
