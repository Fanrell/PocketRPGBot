using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus;
using DSharpPlus.CommandsNext.Attributes;
using PocketRpgBotDsc.Tools;

namespace PocketRpgBotDsc.Commands
{
    class FunCommands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("name")]
        public async Task Name(CommandContext ctx)
        {
            string hello = ctx.Member.Nickname.ToString();
            hello = "Hello " + hello + " my name is Roni";

            await ctx.Channel.SendMessageAsync(hello).ConfigureAwait(false);
        }

        [Command("add")]
        public async Task Add(CommandContext ctx, int a, int b)
        {
            await ctx.Channel.SendMessageAsync((a + b).ToString())
                .ConfigureAwait(false);
        }

        [Command("hello")]
        public async Task Hello(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello :3")
                .ConfigureAwait(false);
        }
        //znaleźć sposób na wprowadzenie "pustej komendy" która pozwoli na wywołanie losowania bez konieczności wpisywania "dice"
        [Command("dice"), Aliases("d")]
        public async Task Hello(CommandContext ctx, string dices)
        {
            var diceRes = dices+"\n"
                        +"Resoults: \n";
            var diceVars = StaticUnwrapper.UwrapSeparator(dices, "d");
            var diceValueReturn = 0;
            if(diceVars[1] > 1)
            {
                for(int i = 0; i < diceVars[0]; i++)
                {
                    var intDiceValue = StaticRandom.Radnom(diceVars[1]);
                    diceRes += intDiceValue.ToString() + " ";
                    diceValueReturn += intDiceValue;
                }
                diceRes += "\nSum: ";
                await ctx.Channel.SendMessageAsync(
                    (diceRes+"\n"+diceValueReturn.ToString())
                ).ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync(
                    ("Invalide argument")
                ).ConfigureAwait(false);
            }
        }
    }
}
