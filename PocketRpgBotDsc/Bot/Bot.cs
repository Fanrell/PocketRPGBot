using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using Newtonsoft.Json;
using PocketRpgBotDsc.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRpgBotDsc
{
    class Bot
    {
        public DiscordClient Clinet
        {
            get;
            private set;
        }

        public CommandsNextExtension Commands 
        {
            get;
            private set;
        }

        public async Task RunAsync()
        {
            var json = string.Empty;

            using (var fs = File.OpenRead("Config/config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync().ConfigureAwait(false);

            var configJson = JsonConvert.DeserializeObject<ConfigJson>(json);

            var config = new DiscordConfiguration
            {
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug,
                AutoReconnect = true,
            };

            Clinet = new DiscordClient(config);

            Clinet.Ready += OnClientReady;


            var commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { configJson.Prefix },
                EnableDms = false,
                EnableMentionPrefix = true,

            };

            Commands = Clinet.UseCommandsNext(commandsConfig);

            Commands.RegisterCommands<FunCommands>();

            await Clinet.ConnectAsync();

            await Task.Delay(-1);
        }

        private Task OnClientReady(DiscordClient client, ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}
