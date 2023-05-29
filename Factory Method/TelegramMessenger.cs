namespace Factory_Method
{
    public class TelegramMessenger : BaseMessenger
    {
        public TelegramMessenger(string username, string password) : base(username, password)
        {
        }

        public override bool Authorize()
        {
            /// TODO: accessing the Telegram API for authorization.
            Console.WriteLine($"User authorization: {UserName}");
            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new TelegramMessage(text, source, target);
            /// TODO: calling the Instagram API to send a message.
            Console.WriteLine($"Telegram: {message.Text}");
            return message;
        }
    }
}
