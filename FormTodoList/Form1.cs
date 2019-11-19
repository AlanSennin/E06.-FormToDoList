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
    public partial class frmTarea : Form
    {
        int i = 1; //Variable contadora para las veces que agreguemos una tarea nueva

        int Estatus; //Variable para asignarle la celda de "Estatus" que seleccionmos en el form para proceder a Editarla

        string H; //Variable para el nuevo Estatus

        public List<TareaAtributo> Lista = new List<TareaAtributo>(); //Instanciando la lista como "Lista"

        TareaAtributo T = new TareaAtributo(); //instanciando la clase "TareaAtributo" como "T"

        Add A = new Add(); //Instanciando la segunda forma de Agregar Tarea como "A" 
        Edit E = new Edit(); //Instanciando la segunda forma de Editar Estatus como "E"
        Show S = new Show(); //Instanciando la segunda forma de Mostrar Detalles de Tarea como "S"

        public frmTarea()
        {
            InitializeComponent();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            Limpiar(); //Mando a llamar el Metodo "Limpiar()" para dejar en blanco los TextBox cada que querramos ingresar una tarea nueva
            A.ShowDialog(); //Se muestra la segunda forma para ingresarle los valores a los Textbox
            AgregarTarea(); //Mando a llamar el metodo "AgregarTarea()" para que procesa a imprimirla en el DataGrind
        }

        private void CmdEditar_Click(object sender, EventArgs e)
        {
            EditarEstatus(); //Mando a llamar el metodo "EditarEstatus()" para cambiar el estatus de la tarea que seleccionemos en el DataGrid

            cmdAgregar.Enabled = true; //Una vez terminado el metodo volvemos a activar el Boton para agregar tareas (que se desactiva en cuanto damos click a una celda de Estatus)
            cmdDetalles.Enabled = true; //Lo mismo con el boton de mostrar detalles
        }

        private void CmdDetalles_Click(object sender, EventArgs e)
        {
            VerDetalles(); //Mando a llamar el metodo de  "VerDetalles()" para que nos muestre los detalles en completo de una Tarea
            S.ShowDialog(); //Se muestra la segunda forma con el puro DataGrind2 donde estaran todos los detalles
        }

        public void AgregarTarea() //Metodo para agregar una tarea al DataGrid de la forma Main
        {
            //Le asignamos lo que hay en los textbox de la forma "Add" a los objetos instanciados de la clase TareaAtributo...
            T.Usuario = A.txtUsuario.Text; 
            T.Nombre = A.txtNombre.Text; 
            T.Horario = A.txtHorario.Text; 
            T.Fecha = A.txtFecha.Text; 
            T.Estatus = A.txtEstatus.Text; 

            Lista.Add(T); //Agregamos todo a la lista creada al inicio del codigo...

            int Imprimir = dataGridView1.Rows.Add(); //Le Asignamos una fila del DataGrid1 a la variable Imprimir

            dataGridView1.Rows[Imprimir].Cells[0].Value = i; //Para la primera celda va el numero de la Tarea ingresada...
            dataGridView1.Rows[Imprimir].Cells[1].Value = T.Nombre; //Para la segunda celda va el nombre de la Tarea ingresada...
            dataGridView1.Rows[Imprimir].Cells[2].Value = T.Estatus; //Para la tercera celda va el estatus de le Tarea ingresada...

            i = i + 1; //Le vamos sumando +1 a la variable para especificar cuantas tareas van
        }

        public void EditarEstatus() //Metodo para Editar el estatus (vease primero el codigo de hasta mero abajo...)
        {
            dataGridView1[2, Estatus].Value = H; //Hace el cambio en el DataGrind en la celca 2 (la del estatus) de la fila que hayamos dado click (Osea la varibale "Estatus" que es global)

            lblTarea.Text = "Tarea Seleccionada:"; //Volemos a dejar el label como antes por si queremos cambiar otro estatus...
        }

        public void VerDetalles() //Metodo para ver todos los detalles de la tarea en una segunda forma "Show"
        {
            //Le asignamos lo que hay en los textbox de la forma "Add" a los objetos instanciados de la clase TareaAtributo...
            T.Usuario = A.txtUsuario.Text;
            T.Nombre = A.txtNombre.Text;
            T.Horario = A.txtHorario.Text;
            T.Fecha = A.txtFecha.Text;
            T.Estatus = A.txtEstatus.Text;

            Lista.Add(T); //Agregamos todo a la lista creada al inicio del codigo...

            int Imprimir = S.dataGridView2.Rows.Add(); //Le Asignamos una fila del DataGrid1 a la variable Imprimir

            //Al igual que el metodo agregar tarea, solo que aqui agregamos todos en el DataGrid2 de la segunda forma "Show"
            S.dataGridView2.Rows[Imprimir].Cells[0].Value = T.Nombre;
            S.dataGridView2.Rows[Imprimir].Cells[1].Value = T.Usuario;
            S.dataGridView2.Rows[Imprimir].Cells[2].Value = T.Fecha;
            S.dataGridView2.Rows[Imprimir].Cells[3].Value = T.Horario;
            S.dataGridView2.Rows[Imprimir].Cells[4].Value = T.Estatus;
        }

        public void Limpiar() //Metodo para limpiar los textbox de la forma Add
        {
            //Limpiando los textbox...
            A.txtUsuario.Clear();
            A.txtNombre.Clear();
            A.txtHorario.Clear();
            A.txtFecha.Clear();
            A.txtEstatus.Clear();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //Metodo para cuando querramos cambiar el estatus de la Tarea, dar click en el Estatus del DataGrid1
        {
            E.txtEstatusEdit.Clear(); //Limpiamos el textbox de la segunda forma (Edit)

            E.ShowDialog(); //Mando llamar a la segunda forma para introducir el nuevo valor del Estatus

            H = E.txtEstatusEdit.Text; //Le asignamos a la variable "E" lo que este en el textbox 

            Estatus = dataGridView1.CurrentRow.Index; //Le asignamos a la variable "Estatus" (que es global) la celda del estatus que querramos cambiar 

            lblTarea.Text = "Tarea Seleccionada: "+ Convert.ToString(dataGridView1[1, Estatus].Value); //Muestra en el label la tarea que es en base al Estatus que seleccionamos

            cmdAgregar.Enabled = false; //Deshabilitamos el boton de Agregar Tarea una vez que hayamos seleccionado un Estatus para cambiar
            cmdDetalles.Enabled = false; //Lo mismo con el boton de Mostrar detalles
        }
    }
}
