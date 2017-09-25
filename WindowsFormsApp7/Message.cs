using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Message : IMessage
    {
        public void ShowHi()
        {
            System.Windows.Forms.MessageBox.Show("Hi!");
        }

        public void ShowMe(string str)
        {
            System.Windows.Forms.MessageBox.Show(str);
        }
    }
}
