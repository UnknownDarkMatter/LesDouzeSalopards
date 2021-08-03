using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace LesDouzeSalopards
{
    static class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // Set up a simple configuration that logs on the console.
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            Log.Info("this is a first log");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
