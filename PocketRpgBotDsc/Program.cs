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
		private CommandHandler handler;

		public async Task MainAsync()
		{
			_client = new DiscordSocketClient();
			_client.Log += Log;

			var token = Environment.GetEnvironmentVariable("Token");

			/*handler = new CommandHandler(_client,)*/

			await _client.LoginAsync(TokenType.Bot, token);
			await _client.StartAsync();

			await Task.Delay(-1);
		}

	}
}
