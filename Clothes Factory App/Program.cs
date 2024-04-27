using Clothes_Factory_App.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes_Factory_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client entrepreneur = new Client(new ElegantClothesFactory());
            Console.WriteLine($"Entrepreneur: {entrepreneur.DecribeYourClothes()}");

            Client student = new Client(new CasualClothesFactory());
            Console.WriteLine($"Student: {student.DecribeYourClothes()}");

            Console.ReadKey();

        }
    }
}
