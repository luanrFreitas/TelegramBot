using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;


namespace Telegram
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("533776167:AAGijSheuj2BBQooJHNuavzGubmrXlHHUvU");
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
            
        }

        private static void Bot_OnMessage(object sender, Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {

                switch (e.Message.Text)
                {
                    case "Oi":
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Oi nada");
                        break;
                    case "Olá":
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Olá Pra quem?");
                        break;

                }
            }

        }
    }
}
