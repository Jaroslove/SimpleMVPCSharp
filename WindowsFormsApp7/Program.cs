﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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
            Manager manager = new Manager();
            Message message = new Message();
            Form1 form1 = new Form1();
            Presenter presenter = new Presenter(form1, manager, message);
            Application.Run(form1);
        }
    }
}
