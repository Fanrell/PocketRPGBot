using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRpgBotDsc.Tools
{
    static class StaticUnwrapper
    {
        public static int[] UwrapSeparator(string wraped, string separatro)
        {
            var unwraped = wraped.Split(separatro);
            int[] toReturn = new int[] { 0, 0 };
            Console.WriteLine("1: "+unwraped[0]+" 2: "+unwraped[1]);
            if (unwraped[0] != "")
            {
                try
                {
                    toReturn = new int[] {
                    Convert.ToInt32(unwraped[0]),
                    Convert.ToInt32(unwraped[1])
                    };
                }
                catch
                {
                    return toReturn;
                }
            }
            else
            {
                try
                {
                    toReturn = new int[] { 1, Convert.ToInt32(unwraped[1])};
                }
                catch
                {
                    return toReturn;
                }
            }
            return toReturn;
        }
    }
}
