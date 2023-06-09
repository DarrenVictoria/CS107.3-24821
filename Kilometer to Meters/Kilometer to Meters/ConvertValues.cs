using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometer_to_Meters
{
    internal class ConvertValues
    {
        public void kilometerTOmeter()
        {
            Console.Write("Enter the value in Kilometer: ");
            double kilometers=double.Parse(Console.ReadLine());
            double meters = kilometers * 1000;
            Console.WriteLine("The value in meters is: {0}", meters);
        }
    }
}
