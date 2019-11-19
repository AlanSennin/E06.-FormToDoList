using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTodoList
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void CmdCambiar_Click(object sender, EventArgs e)
        {
            Close(); //Cerramos la forma una vez que hayamos introducido el valor en el textbox...
        }
    }
}
