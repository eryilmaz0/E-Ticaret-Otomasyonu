using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviDemo.Forms
{
    public class FormGecis
    {
        public void MainFormPass(Form frm,Form frm2)
        {
            frm.Show();
            frm2.Hide();
        }

        public void OperantFormPass(Form frm)
        {
            frm.Show();
        }
    }
}
