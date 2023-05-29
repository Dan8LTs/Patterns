namespace Singleton
{
    public sealed class FileHandlerSingleton
    {
        /// <summary>
        /// A private static class field that holds a single instance of the singleton class.
        /// Instance initialization is performed lazily - that is, only on the first call. 
        /// This construct ensures that only one instance of the class will be created from multiple threads.
        /// </summary>
        private static readonly Lazy<FileHandlerSingleton> instance = new Lazy<FileHandlerSingleton>(() => new FileHandlerSingleton());
        /// <summary>
        /// An open static class field to access an instance of the class.
        /// </summary>
        public static FileHandlerSingleton Instance { get { return instance.Value; } }

        /// <summary>
        /// The path to the file.
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// File contents.
        /// </summary>
        public string Text { get; private set; }
        /// <summary>
        /// Create a new class instance.
        /// We make this constructor private in order to limit the number of instances. So the user can create only one.
        /// </summary>
        private FileHandlerSingleton()
        {
            Path = "test2.txt";
            ReadTextFromFile();
        }
        /// <summary>
        /// Append text to file without saving to permanent memory.
        /// </summary>
        /// <param name="text"></param>
        public void WriteText(string text)
        {
            Text += text;
        }
        public void Save()
        {
            using (var writer = new StreamWriter(Path, false))
            {
                writer.WriteLine(Text);
            }
        }
        /// <summary>
        /// Read data from file.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void ReadTextFromFile()
        {
            if (File.Exists(Path))
            {
                using (var reader = new StreamReader(Path))
                {
                    Text = reader.ReadToEnd();
                }
            }
            else
            {
                Text = "";
            }
        }
    }
}
