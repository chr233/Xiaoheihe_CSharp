using Xiaoheihe_CShape.Forms;

namespace Xiaoheihe_CShape
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
            //Application.Run(new FormClient());
        }
    }
}
