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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void CmdCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Datos Guardados!"); //Menaje de que se agregaron los datos exitosamente
            Close(); //Cerramos la segunda forma...
        }
    }
}
