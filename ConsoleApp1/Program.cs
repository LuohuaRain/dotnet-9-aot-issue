using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static partial class TestDllExport
    {


        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(Test))]
        public static nint Test() => nint.Zero;

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(Test1))]
        public static nint Test1() => nint.Zero;

    }
}
