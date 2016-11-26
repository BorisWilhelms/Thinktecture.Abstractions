﻿#if NETSTANDARD1_3 || NET45 || NET46

using System.ComponentModel;
using System.Net;

namespace Thinktecture.Net
{
	/// <summary>Identifies a network address.</summary>
	public interface IDnsEndPoint : IEndPoint
	{
		/// <summary>
		/// Gets inner instance of <see cref="DnsEndPoint"/>.
		/// It is not intended to be used directly. Use <see cref="DnsEndPointExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		new DnsEndPoint UnsafeConvert();
		
		/// <summary>Gets the host name or string representation of the Internet Protocol (IP) address of the host.</summary>
		/// <returns>A host name or string representation of an IP address.</returns>
		string Host { get; }

		/// <summary>Gets the port number of the <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <returns>An integer value in the range 0 to 0xffff indicating the port number of the <see cref="T:System.Net.DnsEndPoint" />.</returns>
		int Port { get; }

		/// <summary>Compares two <see cref="T:System.Net.DnsEndPoint" /> objects.</summary>
		/// <returns>true if the two <see cref="T:System.Net.DnsEndPoint" /> instances are equal; otherwise, false.</returns>
		/// <param name="comparand">A <see cref="T:System.Net.DnsEndPoint" /> instance to compare to the current instance.</param>
		bool Equals(object comparand);

		/// <summary>Returns a hash value for a <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <returns>An integer hash value for the <see cref="T:System.Net.DnsEndPoint" />.</returns>
		int GetHashCode();

		/// <summary>Returns the host name or string representation of the IP address and port number of the <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <returns>A string containing the address family, host name or IP address string, and the port number of the specified <see cref="T:System.Net.DnsEndPoint" />.</returns>
		string ToString();
	}
}

#endif