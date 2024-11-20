// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 04-21-2022
//
// Last Modified By : David McCarter
// Last Modified On : 11-20-2024
// ***********************************************************************
// <copyright file="BinarySerialization.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Serialization
{
	/// <summary>
	/// Provides methods for serializing and deserializing objects to and from binary format.
	/// </summary>
	public static class BinarySerialization
	{
		/// <summary>
		/// Deserializes the specified byte array.
		/// </summary>
		/// <typeparam name="TResult">The type of the t result.</typeparam>
		/// <param name="bytes">The bytes.</param>
		/// <returns>T.</returns>
		[Information("Orginal code from: https://www.robokiwi.com/wiki/dotnet/interop/marshaling/", author: "David McCarter", createdOn: "4/21/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static TResult Deserialize<TResult>([NotNull] byte[] bytes)
		{
			bytes = bytes.ArgumentNotNull();

			var pinnedPacket = new GCHandle();

			TResult result;

			try
			{
				pinnedPacket = GCHandle.Alloc(bytes, GCHandleType.Pinned);
				result = (TResult)Marshal.PtrToStructure(pinnedPacket.AddrOfPinnedObject(), typeof(TResult));
			}
			finally
			{
				pinnedPacket.Free();
			}

			return result;
		}

		/// <summary>
		/// Deserialize JSON from a file.
		/// </summary>
		/// <typeparam name="TResult">The type of the t result.</typeparam>
		/// <param name="fileName">Name of the file.</param>
		/// <returns>TResult.</returns>
		/// <exception cref="FileNotFoundException">File not found. Cannot deserialize from JSON.</exception>
		[Information(nameof(DeserializeFromFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.New)]
		public static TResult DeserializeFromFile<TResult>([NotNull] string fileName) where TResult : class
		{
			if (File.Exists(fileName) is false)
			{
				ExceptionThrower.ThrowFileNotFoundException("File not found. Cannot deserialize from JSON.", fileName);
			}

			return Deserialize<TResult>(File.ReadAllBytes(fileName));
		}


		/// <summary>
		/// Serializes the specified object.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <returns>System.String.</returns>
		[Information("Orginal code from: https://www.robokiwi.com/wiki/dotnet/interop/marshaling/", author: "David McCarter", createdOn: "4/21/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
		public static byte[] Serialize([NotNull] object obj)
		{
			obj = obj.ArgumentNotNull();

			// Get the size of our structure in bytes
			var structSize = Marshal.SizeOf(obj);

			// This will contain the result, and be returned
			var bytes = new byte[structSize];

			// Allocate some unmanaged memory for our structure
			var pointer = IntPtr.Zero;

			try
			{
				pointer = Marshal.AllocHGlobal(structSize);

				// Write the structure to the unmanaged memory
				Marshal.StructureToPtr(obj, pointer, false);

				// Copy the resulting bytes from unmanaged memory to our result array
				Marshal.Copy(pointer, bytes, 0, structSize);

				return bytes;
			}
			finally
			{
				if (pointer != IntPtr.Zero)
				{
					// Free up our unmanaged memory
					Marshal.FreeHGlobal(pointer);
				}
			}
		}

		/// <summary>
		/// Serializes to and object to a JSON file.
		/// </summary>
		/// <param name="obj">The object.</param>
		/// <param name="fileName">Name of the file.</param>
		[Information(nameof(SerializeToFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.New)]
		public static void SerializeToFile([NotNull] object obj, [NotNull] string fileName)
		{
			obj = obj.ArgumentNotNull();
			fileName = fileName.ArgumentNotNullOrEmpty(true);

			if (File.Exists(fileName))
			{
				File.Delete(fileName);
			}

			File.WriteAllBytes(fileName, Serialize(obj));
		}
	}
}
