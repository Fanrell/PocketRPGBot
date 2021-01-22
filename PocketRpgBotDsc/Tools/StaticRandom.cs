using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRpgBotDsc.Tools
{
    class StaticRandom
    {
        //zmienic sposób wywoływania komendy w taki sposób, aby nie losować liczby n razy, tylko wywołać samą komendę odpowiednią ilość razy, z zapamiętaniem wylosowanej wartości, która pozwoli na wywołanie ingerencji kodu opserwatora.
        public static int Radnom(int max)
        {
            Random radnom = new Random(
                Guid.NewGuid().GetHashCode()
                );
            return radnom.Next(1, max + 1);
        }
    }
}
