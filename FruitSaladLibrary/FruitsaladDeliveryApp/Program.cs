using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitSaladLibrary;

namespace FruitSaladDeliveryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Strawberry sweetStrawberry = new Strawberry("Bright red", 15.0, true, true, 9);
            Strawberry sourstrawberry = new Strawberry("Light red", 10.0, false, false, 4);
            //Creating a Fruit salad

            var salad = new FruitSalad(new List<Fruit> { sweetStrawberry, sourstrawberry },3);  
            //Testing ToString
            Console.WriteLine(salad.ToString());
            salad.Add(new Strawberry("Dark Red", 20.0, true, true, 10));
            Console.WriteLine(salad.ToString());
            //testing serving
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());
            Console.WriteLine(salad.Serve());//Should exceed servings
            Console.WriteLine(salad.ToString());
        }
    }
}
