using AutoFacConsoleApp.Interfaces;

namespace AutoFacConsoleApp
{
    public class Application : IApplication
    {
        private readonly IServiceWriter _serviceWriter;
        private readonly IServiceCalculator _serviceCalculator;

        public Application(IServiceWriter serviceWriter, IServiceCalculator serviceCalculator)
        {
            _serviceWriter = serviceWriter;
            _serviceCalculator = serviceCalculator;
        }

        public void Run()
        {
            _serviceWriter.WriteInformation("Injected");
            _serviceCalculator.Calculate(1, 2);
        }
    }
}
