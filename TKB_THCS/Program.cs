using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKB_THCS.AppCode;

namespace TKB_THCS
{
    static class Program
    {
        public static TKB_THCS.AppCode.NhiemSacThe nst;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            nst = new TKB_THCS.AppCode.NhiemSacThe();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
            
            
        }
    }
}
