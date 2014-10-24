// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdultProxyGranted.cs" company="">
//   
// </copyright>
// <summary>
//   The dultProxyGranted interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyIdentity.Messages
{
    /// <summary>
    /// The dultProxyGranted interface.
    /// </summary>
    public interface AdultProxyGranted : IMyEvent
    {
        /// <summary>
        /// Gets or sets the proxy id.
        /// </summary>
        string ProxyId { get; set; }
    }
}
