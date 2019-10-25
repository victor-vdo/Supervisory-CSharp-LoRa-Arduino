
using System.Windows.Forms;

namespace Apresentacao.Configuration
{
    class verticalProgressbar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |=  0x04;
                return cp;
            }
        }
    }
}
