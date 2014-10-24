// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMyEvent.cs" company="">
//   
// </copyright>
// <summary>
//   The MyEvent interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyIdentity.Messages
{
    using System;

    using NServiceBus;

    /// <summary>
    /// The MyEvent interface.
    /// </summary>
    public interface IMyEvent : IEvent
    {
        /// <summary>
        /// Gets or sets the date occurred.
        /// </summary>
        DateTime DateOccurred { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// Gets or sets the application id.
        /// </summary>
        string ApplicationId { get; set; }
    }
}
