using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus;
using DSharpPlus.CommandsNext.Attributes;

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
        public async Task Hello(CommandContext ctx)
        {
            string hello = ctx.Member.Nickname.ToString();
            hello = "Hello " + hello + " my name is Roni";

            await ctx.Channel.SendMessageAsync(hello).ConfigureAwait(false);
        }

        [Command("add")]
        public async Task Hello(CommandContext ctx, int a, int b)
        {
            await ctx.Channel.SendMessageAsync((a + b).ToString())
                .ConfigureAwait(false);
        }
    }
}
