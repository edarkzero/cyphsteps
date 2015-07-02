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
        private Decypher decypher;

        public MainController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            cypher = new Cypher();
            decypher = new Decypher();
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

        public Decypher Decypher
        {
            get
            {
                return decypher;
            }
        }
    }
}
