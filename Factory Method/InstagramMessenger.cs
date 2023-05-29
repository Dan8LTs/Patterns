namespace Factory_Method
{
    public class InstagramMessenger : BaseMessenger
    {
        public InstagramMessenger(string username, string password) : base(username, password)
        {
        }

        public override bool Authorize()
        {
            /// TODO: accessing the Instagram API for authorization
            Console.WriteLine($"Authorization in Instagram user: {UserName}");
            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new InstagramMessage(text, source, target);
            /// TODO: calling the instagram API to send a message
            Console.WriteLine($"Instagram: {message.Text}");
            return message;
        }
    }
}
