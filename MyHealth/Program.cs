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

namespace MyHealth
{
    using System.Linq;

    using MyIdentity.Messages;

    using NServiceBus.Persistence.Legacy;

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
            busConfiguration.EndpointName("MyHealth");
            busConfiguration.UseSerialization<JsonSerializer>();
            busConfiguration.UsePersistence<InMemoryPersistence>();
            busConfiguration.EnableInstallers();
            var startableBus = Bus.Create(busConfiguration);
            using (var bus = startableBus.Start())
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Start(bus);
            }
        }

        /// <summary>
        /// The start.
        /// </summary>
        /// <param name="bus">
        /// The bus.
        /// </param>
        static void Start(IBus bus)
        {
            PrintInstructions();
            var line = "";
            var numberEntered = 0;
            var username = "[No Username]";
            while (line != null)
            {
                line = Console.ReadLine();

                try
                {
                    var pieces = line.Split(':');
                    if (pieces.Count() > 1)
                    {
                        username = pieces[1];
                    }

                    numberEntered = Convert.ToInt16(pieces[0]);
                }
                catch(Exception e)
                {
                    continue;
                }

                switch (numberEntered)
                {
                    case 1:
                        bus.Publish<SelfEnrollmentCompleted>(e =>
                        {
                            e.Username = username;
                            e.DateOccurred = DateTime.Now;
                            e.ApplicationId = "MyHealth";
                        });

                        break;
                    case 2:
                        bus.Publish<SelfEnrollmentFailed>(e =>
                        {
                            e.Username = username;
                            e.DateOccurred = DateTime.Now;
                            e.ApplicationId = "MyHealth";
                        });

                        break;
                    case 3:
                        bus.Publish<MinorProxyGranted>(e =>
                        {
                            e.Username = username;
                            e.DateOccurred = DateTime.Now;
                            e.ApplicationId = "MyHealth";
                            e.ProxyId = new Guid().ToString();
                        });

                        break;
                    case 4:
                        bus.Publish<AdultProxyGranted>(e =>
                        {
                            e.Username = username;
                            e.DateOccurred = DateTime.Now;
                            e.ApplicationId = "MyHealth";
                            e.ProxyId = new Guid().ToString();
                        });

                        break;
                    default:

                        continue;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Published event with Id {0}.", numberEntered);

                Console.WriteLine("==========================================================================");
            }
        }

        static void PrintInstructions()
        {
            Console.WriteLine("Enter the event number to publish the event");
            Console.WriteLine("You can specify the username by adding them after the event number like so, 1:testuser");
            Console.WriteLine("1 - Self Enrollment Completed");
            Console.WriteLine("2 - Self Enrollment Failed");
            Console.WriteLine("3 - Minor Proxy Granted");
            Console.WriteLine("4 - Adult Proxy Granted");
        }
    }
}