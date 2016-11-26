﻿using System;
using System.ComponentModel;
using System.Net.Sockets;

namespace Thinktecture.Net.Sockets
{
	/// <summary>
	/// Represents an element in a SendPacketsElement array.
	/// </summary>
	public interface ISendPacketsElement
	{
		/// <summary>
		/// Gets inner instance of <see cref="SendPacketsElement"/>.
		/// It is not intended to be used directly. Use <see cref="SendPacketsElementExtensions.ToImplementation"/> instead.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		SendPacketsElement UnsafeConvert();

		/// <summary>
		/// Gets the buffer to be sent if the SendPacketsElement class was initialized with a buffer parameter.
		/// </summary>
		byte[] Buffer { get; }

		/// <summary>
		/// Gets the count of bytes to be sent.
		/// </summary>
		int Count { get; }

		/// <summary>
		/// Gets a Boolean value that indicates if this element should not be combined with the next element in a single send request from the sockets layer to the transport.
		/// </summary>
		bool EndOfPacket { get; }

		/// <summary>
		/// Gets the filename of the file to send if the SendPacketsElement class was initialized with a filepath parameter.
		/// </summary>
		string FilePath { get; }

		/// <summary>
		/// Gets the offset, in bytes, from the beginning of the data buffer or file to the location in the buffer or file to start sending the data.
		/// </summary>
		int Offset { get; }
	}
}