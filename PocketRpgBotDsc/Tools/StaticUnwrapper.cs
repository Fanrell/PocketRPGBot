using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRpgBotDsc.Tools
{
    static class StaticUnwrapper
    {
        public static string[] UnwrapSpace(string wraped)
        {
            var unwraped = wraped.Split(" ");
            return unwraped;
        }

        public static int[] UwrapSeparator(string wraped, string separatro)
        {
            var unwraped = wraped.Split(separatro);
            int[] toReturn = {
                Convert.ToInt32(unwraped[0]),
                Convert.ToInt32(unwraped[1])
            };
            return toReturn;
        }
    }
}
