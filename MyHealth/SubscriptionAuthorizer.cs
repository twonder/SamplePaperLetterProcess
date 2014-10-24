// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SubscriptionAuthorizer.cs" company="">
//   
// </copyright>
// <summary>
//   The subscription authorizer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Collections.Generic;

using NServiceBus;

namespace MyHealth
{
    /// <summary>
    /// The subscription authorizer.
    /// </summary>
    public class SubscriptionAuthorizer : IAuthorizeSubscriptions
    {
        /// <summary>
        /// The authorize subscribe.
        /// </summary>
        /// <param name="messageType">
        /// The message type.
        /// </param>
        /// <param name="clientEndpoint">
        /// The client endpoint.
        /// </param>
        /// <param name="headers">
        /// The headers.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool AuthorizeSubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
        {
            return true;
        }

        /// <summary>
        /// The authorize unsubscribe.
        /// </summary>
        /// <param name="messageType">
        /// The message type.
        /// </param>
        /// <param name="clientEndpoint">
        /// The client endpoint.
        /// </param>
        /// <param name="headers">
        /// The headers.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool AuthorizeUnsubscribe(string messageType, string clientEndpoint, IDictionary<string, string> headers)
        {
            return true;
        }
    }
}