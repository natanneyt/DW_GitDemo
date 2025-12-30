using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16Rekening.Domein
{
    internal class Zichtrekening : Rekening
    {
        public Zichtrekening(double saldo) : base(saldo) { }
        public override void HaalAf(double bedrag)
        {
            if (Saldo - bedrag < -250) throw new ArgumentException("Het saldo mag niet kleiner dan -250 zijn.");
            else Saldo -= bedrag;
            Console.WriteLine($"Nieuw saldo: {Saldo}");
        }
    }
}
