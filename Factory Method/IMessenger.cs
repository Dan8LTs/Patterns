namespace Factory_Method
{
    public interface IMessenger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }
        IMessage CreateMessage(string text, string source, string target);
        bool Authorize();
    }
}
