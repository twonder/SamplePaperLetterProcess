// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MinorProxyGranted.cs" company="">
//   
// </copyright>
// <summary>
//   The inorProxyGranted interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyIdentity.Messages
{
    /// <summary>
    /// The inorProxyGranted interface.
    /// </summary>
    public interface MinorProxyGranted : IMyEvent
    {
        /// <summary>
        /// Gets or sets the proxy id.
        /// </summary>
        string ProxyId { get; set; }
    }
}
