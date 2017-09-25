using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    class Presenter
    {
        private readonly IForm iForm;
        private readonly IManager iManager;
        private readonly IMessage iMessage;
        public Presenter(IForm iForm, IManager iManager, IMessage iMessage)
        {
            this.iForm = iForm;
            this.iManager = iManager;
            this.iMessage = iMessage;
            iForm.buttonClick += click;
        }

        private void click(object sender, EventArgs e)
        {
            iMessage.ShowHi();
            iMessage.ShowMe(iManager.AddTwo(iForm.Namee));
        }
    }
}
