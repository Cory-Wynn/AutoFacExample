using AutoFacConsoleApp.Interfaces;
using System;

namespace AutoFacConsoleApp.Services
{
    public class ServiceCalculator : IServiceCalculator
    {
        public void Calculate(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
