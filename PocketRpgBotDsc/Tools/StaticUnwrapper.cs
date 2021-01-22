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
            int[] toReturn ;
            try
            {
                toReturn = new int[] {
                    Convert.ToInt32(unwraped[0]),
                    Convert.ToInt32(unwraped[1])
                };
            }
            catch
            {
                return new int[] {0,0};
            }
            if(toReturn[0] == null || toReturn[0] == 0)
                toReturn[0] = 1;
            return toReturn;
        }
    }
}
