using CG.BusinessLogic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;


struct BotUpdate
{
    public string text;
    public long id;
    public string? username;
}
public class MyMainClass
{
    static TelegramBotClient Bot = new TelegramBotClient("5969237275:AAGpv9fuz3W1wFJBPaGrkrZBpDVTTBhGz7o");
    static string filename = " update.json";
    static List<BotUpdate> botUpdates = new List<BotUpdate>();
    private static BotUpdate _botUpdate;
    private static ReceiverOptions? receiverOptions;

    public static void Main(string[] args)

    {
        try
        {
            var botUpdatesString = System.IO.File.ReadAllText(filename);
            botUpdates = JsonConvert.DeserializeObject<List<BotUpdate>>(botUpdatesString)??
                botUpdates;
        }
        catch (Exception ex)
        { Console.WriteLine($" Error reading or deserializing {ex}");
        }  
        var receiverOption = new ReceiverOptions
        {
            AllowedUpdates = new UpdateType[]
            {
                UpdateType.Message,
                UpdateType.EditedMessage,
            }
        };

        Bot.StartReceiving(updateHandler, errorHandler, receiverOptions);
       

                                

        Console.WriteLine("*---------------Welcome To Card Games---------------*\n\n");
        GameForm form = new GameForm();
        bool i = true;
        while (i == true)
        {

            Console.WriteLine("\n\t\t Choose the game type from below option :-----------");
            Console.WriteLine("\t\t 1. No Limit Holdem poker.");
            Console.WriteLine("\t\t 2. Rummy.");
            Console.WriteLine("\t\t 3. Pot Limit Omaha.");
            Console.WriteLine("\t\t 4. Short Deck Poker.");
            Console.WriteLine("\t\t 5. Open Face Chinese Poker (Bonus Problem)");
            Console.WriteLine("\t\t 6. EXIT");
            int ch;
            try
            {
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case (1):
                        form.NolimitHolderPoker();

                        break;
                    case (2):
                        form.Rummy();

                        break;
                    case (3):
                        form.PotLimitOmaha();

                        break;
                    case (4):
                        form.ShortDeckPoker();
                        break;
                    case (5):
                        form.OpenFaceChinesePoker();

                        break;
                    case (6):
                        i = false;
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\t\t\t\t----------Thankyou For visiting Crad Games---------- ");
                        Thread.Sleep(1000);
                        break;

                    default:

                        break;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }



        }
    }

    private static Task errorHandler(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
    {
        throw new NotImplementedException();
    }

    private static async Task updateHandler(ITelegramBotClient bot, Update update, CancellationToken arg3)
    {
       if(update.Type == UpdateType.Message)
        {
            if (update.Message.Type == MessageType.Text)
            {
                var _botUpdate = new BotUpdate
                {

                   text = update.Message.Text,
                   id = update.Message.Chat.Id,
                   username = update.Message.Chat.Username
                };

            botUpdates.Add(_botUpdate);

            var botUpdatesString = JsonConvert.SerializeObject(botUpdates);

            System.IO.File.WriteAllText(filename, botUpdatesString);             
            }
        }
    }
}