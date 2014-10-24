// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;

using NServiceBus;
using NServiceBus.Persistence;
using NServiceBus.Features;

namespace Distribution.PaperLetters
{
    /// <summary>
    /// The program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        static void Main()
        {
            var busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("Distribution.PaperLetters");
            busConfiguration.UseSerialization<JsonSerializer>();
            busConfiguration.UsePersistence<InMemoryPersistence>();
            busConfiguration.EnableInstallers();
            var startableBus = Bus.Create(busConfiguration);
            using (var bus = startableBus.Start())
            {
                Console.WriteLine("To exit, Ctrl + C");
                Console.ReadLine();
            }
        }
    }
}