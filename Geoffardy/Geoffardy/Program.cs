using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geoffardy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Board1 Board = new Board1();
            Form2 HostBoard = new Form2();
            Board.Show();
            HostBoard.Show();
            Application.Run(Board);
        }
    }
}
