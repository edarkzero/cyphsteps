using cyphsteps.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cyphsteps
{
    public partial class MainForm : Form
    {
        private MainController controller;

        public MainForm(MainController _controller)
        {
            InitializeComponent();
            controller = _controller;
        }

        private void tb_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (tb_entrada.Text.Contains("-."))
                tb_salida1.Text += "casa";*/

            if (e.KeyChar == (char)Keys.Return)
            {
                progressBar1.Value = 0;
                tb_salida1.Text = controller.Cypher.convertText(tb_entrada.Text);
                progressBar1.Value = 50;
                tb_salida2.Text = controller.Decypher.convertText(tb_entrada.Text);
                progressBar1.Value = 100;
            }
        }
    }
}
