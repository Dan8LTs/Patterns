namespace Factory_Method
{
    public class TelegramMessage : BaseMessage
    {
        public TelegramMessage(string text, string target, string source) : base(text, target, source)
        {
            /// <summary>
            /// TODO: add input validation
            /// </summary>
            Text = text;
            Target = target;
            Source = source;
        }

        public override void Send()
        {
            /// TODO: calling the Telegram API to send a message.
            Console.WriteLine($"Telegram: Message sent from {Source} to {Target}");
        }
    }
}
