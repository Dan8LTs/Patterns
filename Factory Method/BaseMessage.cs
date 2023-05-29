namespace Factory_Method
{
    public abstract class BaseMessage : IMessage
    {
        public string Text { get; protected set; }
        public string Target { get; protected set; }
        public string Source { get; protected set; }
        public BaseMessage(string text, string target, string source)
        {
            /// <summary>
            /// TODO: add input validation
            /// </summary>
            Text = text;
            Target = target;
            Source = source;
        }
        public abstract void Send();
    }
}
