using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyphsteps.controllers
{
    class MainController
    {
        MainForm form;

        public MainController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new MainForm();
        }

        public void render()
        {
            Application.Run(form);
        }

        public void stop()
        {
            Application.Exit();
        }
    }
}
