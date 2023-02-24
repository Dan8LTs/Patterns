namespace Factory_Method
{
    public class Messenger
    {
        
        public string UserName { get; }
        public string Password { get; }
        public bool Connected { get; }
        public Messenger(string username, string password)
        {
            UserName = username;
            Password = password;
            Connected = ConnectToTelegram();
        }

        private bool ConnectToTelegram()
        {
            throw new NotImplementedException();
        }
    }
}
