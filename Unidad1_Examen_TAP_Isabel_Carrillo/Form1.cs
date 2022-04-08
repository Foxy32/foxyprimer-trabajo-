using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad1_Examen_TAP_Isabel_Carrillo
{
    public partial class Form1 : Form
    {
        //se crea un directorio para alumnos y uno para empleados.
        Dictionary<string, string> Alumno = new Dictionary<string, string>();
        Dictionary<string, string> Empleado = new Dictionary<string, string>();
        //se crea una varieble global y de tipo public static.
        public static string usuario;
        public Form1()
        {
            InitializeComponent();
        
        }
        //aqui se cree un evento chkinvitado para cuando este seleccionado la opción
        private void chkInvitado_CheckedChanged(object sender, EventArgs e)
        {
            //Aqui es por si la opcíon es si ,se ejecute lo siguente
            if (chkInvitado.Checked == true)
            {
                //muestre este el siguente mensaje
                DialogResult result = MessageBox.Show("¿Estas seguro que deseas ingresar como invitado?", "PIDETEC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //esto va acargar el el txtBox 
                    txtNombre.Focus();
                    txtNombre.Text = "Ingresa tu nombre de usuario";
                }
                //esta es la opción por si selecciona no
                if (result == DialogResult.No)
                {
                    //este mensaje se vera si el usuario selecciona la opción no 
                    chkInvitado.Checked = false;
                    txtNombre.Text = "Ingresa tu matricula o número de empleado";
                }
            }
            // esto es por la opción por si selecciona que no es ivitado y se equivoco 
            if (chkInvitado.Checked == false)
            {
                //por si el el chkinvitado es no mande el mensaje 
                chkInvitado.Checked = false;
                //en el txtbox que ingrese su matricula o número de empleado
                txtNombre.Text = "Ingresa tu matricula o número de empleado";
            }
        }
        //este es el boton aceptar 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //tengo dudas aqui
            string msg = string.Empty;
            string usuario = string.Empty;
            //esto es para que el diccionario busque el Número de empelado o el Número de matricula y tambien seleccione la opción invitado 
            if (Alumno.ContainsKey(txtNombre.Text) || Empleado.ContainsKey(txtNombre.Text)|| chkInvitado.Checked == true)
            {
                //si es una matricula 
                if (Alumno.ContainsKey(txtNombre.Text))
                {
                    //va a mostrar el siguente mensaje 
                    msg = string.Format("Bienvenido a PIDETEC estimado alumno: {0}, espero tu visita sea placentera.", Alumno[txtNombre.Text].ToString());
                    usuario = Alumno[txtNombre.Text].ToString();
                }
                //si es empelado
                if (Empleado.ContainsKey(txtNombre.Text))
                {
                    //mostrara el siguente mensaje 
                    msg = string.Format("Bienvenido a PIDETEC {0}", Empleado[txtNombre.Text].ToString());
                    usuario = Empleado[txtNombre.Text].ToString();
                }
                //si es el nombre del ivitado
                if (chkInvitado.Checked == true)
                {
                    //mostrara el siguente mensaje 
                    msg = string.Format("Bienvenido señor invitado llamado: {0}", txtNombre.Text);
                    usuario = txtNombre.Text;
                }
                //tengo dudas
                MessageBox.Show(msg);
                fmrMenuComida cambiar = new fmrMenuComida(usuario);
                this.Hide();
                //Es para madar llamar el from , par aque salga un proseso secundario
                DialogResult dialogResult = cambiar.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    this.Show();
                }               
            }
            //sino se encuentra el usaurio
            else
            {
                //va a mostrar el siguente mensaje 
                MessageBox.Show("Usuario no encontrado");
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkInvitado.Checked == true)
            {
                //aqui estamos implementado una regla para que el usuario si es que ingreasa como invitado solo pueda escribir letras
                //y no signos 
                if (e.KeyChar >= 00 && e.KeyChar <= 64 && e.KeyChar != 127 && e.KeyChar != 08 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar != 8 && e.KeyChar >= 123 && e.KeyChar <= 126 || e.KeyChar != 8 && e.KeyChar >= 128)
                {
                    //si es verdad mostrara el siguente mensaje 
                    e.Handled = true;
                    //mostramos el siguente mensaje 
                    MessageBox.Show("Solo puedes ingresar letras");
                }
            }
            //sino 
            else
            {
                //esto es por sino eres invitado , no ingreses tu nombre, sino que 
                //ingreses el número de tu matricula o el número de trabajador.
                if (e.KeyChar >= 00 && e.KeyChar <= 47 && e.KeyChar != 127 && e.KeyChar != 08 || e.KeyChar >= 58 && e.KeyChar <= 255)
                {
                    e.Handled = true;
                    MessageBox.Show("Solo puedes ingresar numeros");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //se llena el directorio de alumnos.
            //no se colocaron todos los nombres de las personas , ya que daba un error , los nombres eran demaciado largo y tapaban
            //el boton de cerrar sesión.
            Alumno.Add("201000067", "CARRILLO RODRIGUEZ ISABEL");
            Alumno.Add("201000076", "SANTANA RODRIGUEZ RAMON");
            Alumno.Add("201000175", "CARRIZALES CARRILLO LUIS GAEL");
            Alumno.Add("201000069", "CERVANTES LUJAN JORGE LUIS");
            Alumno.Add("201000133", "LOZA MILAN LEONARDO");
            Alumno.Add("201000188", "OCHOA ESPARZA SANJUANA MELISSA");
            Alumno.Add("201000152", "SCOTT CARREON PAOLA ALEJANDRA");
            Alumno.Add("201000114", "VELASQUEZ VAZQUEZ DIANA KAREN");
            //se llena el directorio de empleados.
            Empleado.Add("001", "ALEJANDRO DANIEL REYES EQUIVEL");
            Empleado.Add("002", "ISABEL ESMERALDA CARILLO RODRIGUEZ");
            Empleado.Add("003", "JAIME EMMANUEL QUISTIAN SANCHEZ");
            Empleado.Add("004", "CHRISTIAN HUMBERTO PONCE FLORES");
            Empleado.Add("005", "ADRIANA ZURITA DE LA CRUZ");
            Empleado.Add("006", "DANIELA RAMIREZ MARTINEZ");
            Empleado.Add("007", "KEVIN OROZCO REBOLLAR");
            Empleado.Add("008", "FANNY BERLANGA ESCOBEDO");
            Empleado.Add("009", "LEONARDO LOZA MILAN");
            Empleado.Add("010", "ALLISON MURILLO LOZA");
        }
        //creamos el evento click 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //se ciere 
            Application.Exit();
        }
        //evento click 
        private void txtNombre_Click(object sender, EventArgs e)
        {
            //guarde el nombre 
            txtNombre.Text = string.Empty;
        }
    }
}
