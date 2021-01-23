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
        [Command("roll"), Aliases("r")]
        public async Task Roll(CommandContext ctx, string dices)
        {
            var diceRes = dices+"\n"
                        +"Resoults: \n";
            var diceVars = StaticUnwrapper.UwrapSeparator(dices, "d");
            var diceValueReturn = 0;
            if(diceVars[1] > 1)
            {
                for(int i = 0; i < diceVars[0]; i++)
                {
                    var intDiceValue = StaticRandom.Rand(diceVars[1]);
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
