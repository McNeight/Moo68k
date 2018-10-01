using System;
using static System.Console;

namespace Moo68k.Console
{
    public static class RandomTester
    {
        public static void Run()
        {
            var m68k = new MC68000();
            var r = new Random();
            while (true)
            {
                System.Threading.Thread.Sleep(150);

                // Operation code
                var op = (ushort)r.Next(ushort.MaxValue);
                // Operand
                var opr = (uint)r.Next(int.MaxValue);

                m68k.Execute(op, opr);

                Clear();

                WriteLine($" D0={m68k.D0:X8}  D1={m68k.D1:X8}  D2={m68k.D2:X8}  D3={m68k.D3:X8}");
                WriteLine($" D4={m68k.D4:X8}  D5={m68k.D5:X8}  D6={m68k.D6:X8}  D7={m68k.D7:X8}");
                WriteLine($" A0={m68k.A0:X8}  A1={m68k.A1:X8}  A2={m68k.A2:X8}  A3={m68k.A3:X8}");
                WriteLine($" A4={m68k.A4:X8}  A5={m68k.A5:X8}  A6={m68k.A6:X8}");
                WriteLine($"USP={m68k.USP:X6}  SSP={m68k.SSP:X6}  SR={m68k.SR:X4}");
                WriteLine();
                WriteLine($"{m68k.PC:X8}  {op:X4}  {opr:X8}");
            }
        }
    }
}
