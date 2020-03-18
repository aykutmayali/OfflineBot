using System;
using Syn.Bot.Oscova;

namespace TableReservationBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new OscovaBot();
            bot.ImportWorkspace(@"C:\Users\aykut\OneDrive\Documents\table-reservation-bot.west");
            bot.Trainer.StartTraining();

            bot.MainUser.ResponseReceived += (sender, eventArgs) =>
            {
                Console.WriteLine($"Bot: {eventArgs.Response.Text}");
            };

            while (true)
            {
                var request = Console.ReadLine();
                var evaluationResult = bot.Evaluate(request);
                evaluationResult.Invoke();
            }
        }
    }
}
