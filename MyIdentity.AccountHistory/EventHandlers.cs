// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="">
//   
// </copyright>
// <summary>
//   The event message handler.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyIdentity.AccountHistory
{
    using System;
    using System.Runtime.InteropServices;

    using MyIdentity.Messages;

    using NServiceBus;

    /// <summary>
    /// The event message handler.
    /// </summary>
    public class EventMessageHandler : IHandleMessages<IMyEvent>
    {
        private static int i = 0; 
        
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="myEvent">
        /// The my event.
        /// </param>
        public void Handle(IMyEvent myEvent)
        {
            i++;
            if (i % 2 == 0)
            {
                //throw new Exception();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================================================");
            var pieces = myEvent.GetType().Name.Split('_');
            var eventType = pieces[0];
            Console.WriteLine("Recording history for event: {0}.", eventType);
            Console.WriteLine("Event Ocurred: {0}.", myEvent.DateOccurred);
            Console.WriteLine("Event Received: {0}.", DateTime.Now);
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Empty);
        }
    }
}