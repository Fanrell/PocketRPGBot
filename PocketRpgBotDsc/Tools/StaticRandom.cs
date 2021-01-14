using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRpgBotDsc.Tools
{
    class StaticRandom
    {
        public static int Radnom(int amount, int max)
        {
            int resoult = 0;

            Random radnom = new Random(
                Guid.NewGuid().GetHashCode()
                );
            for(int i = 0; i< amount; i++)
                resoult += radnom.Next(maxValue: max);

            return resoult;
        }
    }
}
