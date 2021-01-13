using System;
using System.Threading.Tasks;

namespace PocketRpgBotDsc
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
	}
}
