using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketRpgBotDsc.Memento;

namespace PocketRpgBotDsc.Tools
{
    class StaticRandom
    {
        private static IntMemento intMemento = new IntMemento();
        public static int Rand(int max)
        {
            var seed = Guid.NewGuid().GetHashCode();
            var toReturm = -1;
            Random random = new Random(seed);
            if (intMemento.Update(random.Next(1, max + 1)))
            {
                Console.WriteLine("StunLock");
                toReturm = Rand(max, seed + 1);
            }
            else
            {
                toReturm = intMemento.RandomValue;
            }
            return toReturm;
        }

        private static int Rand(int max, int seed)
        {
            Random radnom = new Random(
                seed
                );
            return radnom.Next(1, max + 1);
        }
    }
}
