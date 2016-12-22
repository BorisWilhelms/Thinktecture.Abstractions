﻿#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="UnicastIPAddressInformation"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class UnicastIPAddressInformationExtensions
	{
		/// <summary>
		/// Converts provided info to <see cref="IUnicastIPAddressInformation"/>.
		/// </summary>
		/// <param name="info">Info to convert.</param>
		/// <returns>Converted info.</returns>
		public static IUnicastIPAddressInformation ToInterface(this UnicastIPAddressInformation info)
		{
			return (info == null) ? null : new UnicastIPAddressInformationAdapter(info);
		}
	}
}

#endif