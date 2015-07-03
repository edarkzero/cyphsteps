using cyphsteps.models.cyphers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyphsteps.controllers
{
    public class MainController
    {
        private MainForm form;
        private Cypher cypher;

        public MainController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            cypher = new Cypher();
            form = new MainForm(this);
        }

        public void render()
        {
            Application.Run(form);
        }

        public void stop()
        {
            Application.Exit();
        }

        public Cypher Cypher
        {
            get
            {
                return cypher;
            }            
        }
    }
}
