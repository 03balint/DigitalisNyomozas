using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
    internal class DecisionEngine
    {
        private int hatarErtek;

        public DecisionEngine(int hatarErtek=4)
        {
            this.hatarErtek = hatarErtek;
        }

        public int HatarErtek { get => hatarErtek; set => hatarErtek = value; }

        public void Ertekel(Suspect gyanusitott, List<Evidence> bizonyitekok)
        {

            int novel = bizonyitekok.Count / 2;

            gyanusitott.Gyanusitottsagi_szint += novel;


            if (gyanusitott.Gyanusitottsagi_szint < 1)
                gyanusitott.Gyanusitottsagi_szint = 1;

            if (gyanusitott.Gyanusitottsagi_szint > 5)
                gyanusitott.Gyanusitottsagi_szint = 5;

            Console.WriteLine($"Aktuális gyanúsítottsági szint: {gyanusitott.Gyanusitottsagi_szint}");


            if (gyanusitott.Gyanusitottsagi_szint >= 4)
            {
                Console.WriteLine("A gyanúsított magas kockázatú!");
            }
        }
    }
}
