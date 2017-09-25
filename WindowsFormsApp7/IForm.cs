using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    interface IForm
    {
        event EventHandler buttonClick;
        string Namee { get; }
    }
}
