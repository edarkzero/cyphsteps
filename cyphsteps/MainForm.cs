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
                int maxInputs = 3;
                int progress = 100/maxInputs;

                controller.Cypher.encode(tb_entrada.Text);
                controller.Cypher.decode(controller.Cypher.GetEncodedBytes());

                progressBar1.Value = 0;
                tb_salida1.Text = controller.Cypher.GetEncodedText();
                progressBar1.Value += progress;
                tb_salida2.Text = controller.Cypher.GetDecodedText();
                progressBar1.Value += progress;
                tb_salida3.Text = controller.Cypher.GetText();
                progressBar1.Value += progress;
            }
        }
    }
}
