namespace Singleton
{
    internal class FileHandler
    {
        /// <summary>
        /// The path to the file.
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// File contents.
        /// </summary>
        public string Text { get; private set; }
        /// <summary>
        /// Create new class instance.
        /// </summary>
        public FileHandler()
        {
            Path = "test.txt";
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
