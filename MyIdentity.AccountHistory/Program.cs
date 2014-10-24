// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyIdentity.AccountHistory
{
    using System;

    using NServiceBus;

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
            busConfiguration.EndpointName("MyIdentity.AccountHistory");
            busConfiguration.UseSerialization<JsonSerializer>();
            busConfiguration.UsePersistence<InMemoryPersistence>();
            busConfiguration.EnableInstallers();
            var startableBus = Bus.Create(busConfiguration);
            using (startableBus.Start())
            {
                
                Console.WriteLine("To exit, Ctrl + C");
                Console.ReadLine();
            }
        }
    }
}