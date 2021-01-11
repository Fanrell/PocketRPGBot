using Discord;
using Discord.WebSocket;
using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace PocketRpgBotDsc
{
    class Program
    {
		public static void Main(string[] args)
				=> new Program().MainAsync().GetAwaiter().GetResult();

		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}

		private DiscordSocketClient _client;

		public async Task MainAsync()
		{
            var _config = new DiscordSocketConfig { MessageCacheSize = 100 };

			_client = new DiscordSocketClient(_config);
			_client.Log += Log;

			var token = Environment.GetEnvironmentVariable("Token");

			await _client.LoginAsync(TokenType.Bot, token);
			await _client.StartAsync();

			_client.MessageUpdated += MessageUpdated;
            _client.Ready += () =>
			{
				Console.WriteLine("Bot is connected");
				return Task.CompletedTask;
			};

			await Task.Delay(-1);
		}

		private async Task MessageUpdated(Cacheable<IMessage, ulong> befor, SocketMessage after, ISocketMessageChannel channel)
        {
			var message = await befor.GetOrDownloadAsync();
			Console.WriteLine($"{message} -> {after}");
        }

	}
}
