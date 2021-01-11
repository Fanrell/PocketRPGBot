﻿using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace PocketRpgBotDsc
{
    class LoggingService
    {
        public LoggingService(DiscordSocketClient client, CommandService command)
        {
            client.Log += LogAsync;
            command.Log += LogAsync;
        }

        private Task LogAsync(LogMessage message)
        {
            if (message.Exception is CommandException commandException)
            {
                Console.WriteLine($"[Command/{message.Severity}] {commandException.Command.Aliases}"
                    + $" failed to execute in {commandException.Context.Channel}.");
                Console.WriteLine(commandException);
            }
            else
                Console.WriteLine($"[General/{message.Severity}] {message}");
            return Task.CompletedTask;
        }

    }
}
