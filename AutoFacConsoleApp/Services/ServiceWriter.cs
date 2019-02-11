using System;
using AutoFacConsoleApp.Interfaces;

namespace AutoFacConsoleApp.Services
{
    public class ServiceWriter : IServiceWriter
    {
        public void WriteInformation(string information)
        {
            Console.WriteLine(information);
        }
    }
}
