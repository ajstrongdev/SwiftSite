namespace SwiftSite
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
                int debug = 0;
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "--debug" || args[i] == "-d")
                    {
                        MessageBox.Show("Debug mode on.");
                        debug = 1;
                    }
                }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(debug));
        }
    }
}