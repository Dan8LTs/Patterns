namespace Factory_Method
{
    public interface IMessage
    {
        string Text { get; }
        string Target { get; }
        string Source { get; }
        void Send();
    }
}
