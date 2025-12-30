using System;

namespace D12soortenafrondingen
{
    internal class Program
    {
        private const int _columnWidth = 15;
        static void Main(string[] args)
        {
            Console.WriteLine($"{"g",_columnWidth}{"Math.Ceiling",_columnWidth}{"Math.Floor",_columnWidth}{"Math.Round",_columnWidth}{"Math.Round(g,MidPointRounding.AwayFromZero",45}");
            WriteRow(7.4);
            WriteRow(7.5);
            WriteRow(7.6);
            WriteRow(-7.4);
            WriteRow(-7.5);
            WriteRow(-7.6);
        }

        static void WriteRow(double value)
        {
            Console.WriteLine($"{value,_columnWidth}{Math.Ceiling(value),_columnWidth}{Math.Floor(value),_columnWidth}{Math.Round(value),_columnWidth}{Math.Round(value,MidpointRounding.AwayFromZero),45}");

        }
    }
}
