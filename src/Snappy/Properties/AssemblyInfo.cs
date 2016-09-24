using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Snappy for .NET Standard")]
[assembly: AssemblyDescription(".NET Standard client for Google's Snappy compression library, inspired by Snappy.NET. Snappy is a very fast compression(250 MB/sec)/decompression(500 MB/sec) library written in C++.")]
[assembly: AssemblyCompany("David Rouyer")]
[assembly: AssemblyProduct("Snappy")]

[assembly: InternalsVisibleTo("Snappy.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

[assembly: ComVisible(false)]