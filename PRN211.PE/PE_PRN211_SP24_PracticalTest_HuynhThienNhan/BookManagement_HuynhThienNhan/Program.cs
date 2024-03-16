namespace BookManagement_HuynhThienNhan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new BookManagerMainUI());
            // mỗi form là 1 class nhưng có thêm phần render
            //mỗi class thì cứ new như bình thường 
        }
    }
}