namespace Factory_Method
{
    public class InstagramMessage : BaseMessage
    {
        public InstagramMessage(string text, string target, string source) : base(text, target, source)
        {
            if (File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageBytes);
                Text = base64String;
            }
        }
        public override void Send()
        {
            /// TODO: Calling the Instagram API to send a message.
            Console.WriteLine($"Instagram: Photo sent from {Source} to {Target}");
        }
    }
}
