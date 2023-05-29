namespace Factory_Method
{
    public abstract class BaseMessenger : IMessenger
    {
        public string UserName { get; }

        public string Password { get; }

        public bool Connected { get; }

        public BaseMessenger(string username, string password)
        {
            /// <summary>
            /// TODO: add input validation
            /// </summary>
            UserName = username;
            Password = password;
            Connected = Authorize();
        }
        public abstract bool Authorize();

        public abstract IMessage CreateMessage(string text, string source, string target);
    }
}
