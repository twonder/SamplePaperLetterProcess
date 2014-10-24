// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="">
//   
// </copyright>
// <summary>
//   The self enrollment completed handler.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Distribution.PaperLetters
{
    using System;

    using MyIdentity.Messages;

    using NServiceBus;

    /// <summary>
    /// The self enrollment completed handler.
    /// </summary>
    public class SelfEnrollmentCompletedHandler : IHandleMessages<SelfEnrollmentCompleted>
    {
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="myEvent">
        /// The my event.
        /// </param>
        public void Handle(SelfEnrollmentCompleted myEvent)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Printing Letter SelfEnrollmentCompleted for: {0}.", myEvent.Username);
            Console.WriteLine("Event Ocurred: {0}.", myEvent.DateOccurred);
            Console.WriteLine("Event Received: {0}.", DateTime.Now);
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Empty);
        }
    }

    /// <summary>
    /// The minor proxy granted handler.
    /// </summary>
    public class MinorProxyGrantedHandler : IHandleMessages<MinorProxyGranted>
    {
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="myEvent">
        /// The my event.
        /// </param>
        public void Handle(MinorProxyGranted myEvent)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Printing Letter MinorProxyGranted for: {0}.", myEvent.Username);
            Console.WriteLine("Event Ocurred: {0}.", myEvent.DateOccurred);
            Console.WriteLine("Event Received: {0}.", DateTime.Now);
            Console.WriteLine("ProxyId: {0}.", myEvent.ProxyId);
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Empty);
        }
    }

    /// <summary>
    /// The adult proxy granted handler.
    /// </summary>
    public class AdultProxyGrantedHandler : IHandleMessages<AdultProxyGranted>
    {
        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="myEvent">
        /// The my event.
        /// </param>
        public void Handle(AdultProxyGranted myEvent)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Printing Letter AdultProxyGranted for: {0}.", myEvent.Username);
            Console.WriteLine("Event Ocurred: {0}.", myEvent.DateOccurred);
            Console.WriteLine("Event Received: {0}.", DateTime.Now);
            Console.WriteLine("ProxyId: {0}.", myEvent.ProxyId);
            Console.WriteLine("==========================================================================");
            Console.WriteLine(string.Empty);
        }
    }
}