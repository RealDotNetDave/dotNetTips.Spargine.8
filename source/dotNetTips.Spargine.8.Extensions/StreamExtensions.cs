// ***********************************************************************
// Assembly         : DotNetTips.Spargine.8.Extensions **
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-19-2024
// ***********************************************************************
// <copyright file="StreamExtensions.cs" company="McCarter Consulting">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods designed for Stream.</summary>
// ***********************************************************************
using System.Buffers;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Provides extension methods for <see cref="Stream"/> to enhance and simplify its use.
/// </summary>
[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available)]
public static class StreamExtensions
{

	/// <summary>
	/// Flushes and closes the specified <see cref="Stream"/>.
	/// </summary>
	/// <param name="stream">The <see cref="Stream"/> to flush and close.</param>
	public static void FlushClose(this Stream stream)
	{
		if (stream is not null)
		{
			stream.Flush();
			stream.Close();
		}
	}

	/// <summary>
	/// Reads from the <see cref="Stream"/> asynchronously.
	/// Validates that <paramref name="stream"/> is not null.
	/// </summary>
	/// <param name="stream">The stream to read from.</param>
	/// <param name="destination">The memory region to fill with the data read from the stream.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
	/// <returns>A task that represents the asynchronous read operation. The value of the TResult parameter contains the total number of bytes read into the buffer.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static ValueTask<int> ReadAsync(this Stream stream, Memory<byte> destination, CancellationToken cancellationToken = default)
	{
		stream = stream.ArgumentNotNull();
		destination = destination.ArgumentNotNull();

		if (MemoryMarshal.TryGetArray(destination, out ArraySegment<byte> array))
		{
			return new ValueTask<int>(stream.ReadAsync(array.Array, array.Offset, array.Count, cancellationToken));
		}
		else
		{
			var buffer = ArrayPool<byte>.Shared.Rent(destination.Length);

			return new ValueTask<int>(FinishReadAsync(stream.ReadAsync(buffer, 0, destination.Length, cancellationToken), buffer, destination));

			static async Task<int> FinishReadAsync(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination)
			{
				try
				{
					var result = await readTask.ConfigureAwait(false);
					new Span<byte>(localBuffer, 0, result).CopyTo(localDestination.Span);
					return result;
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(localBuffer);
				}
			}
		}
	}

	/// <summary>
	/// Writes to the <see cref="Stream"/> asynchronously.
	/// Validates that <paramref name="stream"/> is not null.
	/// </summary>
	/// <param name="stream">The <see cref="Stream"/> to write to.</param>
	/// <param name="source">The data to write to the stream.</param>
	/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
	/// <returns>A <see cref="ValueTask"/> that represents the asynchronous write operation.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestStatus = UnitTestStatus.None, Status = Status.Available)]
	public static ValueTask WriteAsync(this Stream stream, ReadOnlyMemory<byte> source, CancellationToken cancellationToken = default)
	{
		stream = stream.ArgumentNotNull();

		if (MemoryMarshal.TryGetArray(source.ArgumentNotNull(), out var array))
		{
			return new ValueTask(stream.WriteAsync(array.Array, array.Offset, array.Count, cancellationToken));
		}
		else
		{
			var buffer = ArrayPool<byte>.Shared.Rent(source.Length);
			source.Span.CopyTo(buffer);

			return new ValueTask(FinishWriteAsync(stream.WriteAsync(buffer, 0, source.Length, cancellationToken), buffer));

			static async Task FinishWriteAsync(Task writeTask, byte[] localBuffer)
			{
				try
				{
					await writeTask.ConfigureAwait(false);
				}
				finally
				{
					ArrayPool<byte>.Shared.Return(localBuffer);
				}
			}
		}
	}

}
