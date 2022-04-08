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
    public partial class fmrMenuComida : Form
    {
        //creamos variables publicas 
        public int progressPizza, progressLonche, progressSandwich, progressGordita, total;
        //privado que solo quermeos que se usen aqui en este apartado 
        private string usuario;
        fmrImagen imagen;
        public fmrMenuComida(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        //creamos un evento load para que muestre un from con las imagenes de la comida
        private void fmrMenuComida_Load(object sender, EventArgs e)
        {
            //aqui colocamos las coordenadas de las iamgenes
            imagen = new fmrImagen(this.Location.X + ClientSize.Width + 50, this.Location.Y + ClientSize.Height -280);
            toolLabel.Text = usuario;
        }
        //creamos el evento click para sandwitch
        private void btnSandwich_Click(object sender, EventArgs e)
        {
            //si el usuario le da click  se ejecutara lo siguente
            if (progressSandwich >=0 && progressSandwich <= 90)
            {
                //duda
                total += 20;
                //aqui estamos dando la indicacion de que cuando se de click 
                //en el boton la barra de progreso debe de cargar de 10 en 10
                progressSandwich += 10;
                pbSandwich.Value = progressSandwich;
                //muestre el total
                lblTotalD.Text = total.ToString();
            }
        }
        //duda
        private void toolButon_ButtonClick(object sender, EventArgs e)
        {
            //duda
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //creamos un evento de mouseHover para que cargue la cuando el raton este en enciama del boton
        private void btnPizza_MouseHover(object sender, EventArgs e)
        {
            //cargara la imagen del from
            imagen.pbImagen.Image = Properties.Resources.Pizza;
            //la mostrara en un show
            imagen.Show();
        }
        //creamos un enevto que cuando se este moviendo el mouse no cargue la imagen , ya que quermeos 
        //que solo se cargue cuando este quieto.
        private void btnPizza_MouseLeave(object sender, EventArgs e)
        {
            imagen.Hide();
        }
        //creamos un evento de mouseHover
        private void btnSandwich_MouseHover(object sender, EventArgs e)
        {
            //va agargar la imagen cuando el mouse se quede quieto en el boton 
            imagen.pbImagen.Image = Properties.Resources.Sandwich;
            //se va a cerrar cuando se quite el mouse del boton
                imagen.Show();
        }
        //creamos un enevto que cuando se este moviendo el mouse no cargue la imagen , ya que quermeos 
        //que solo se cargue cuando este quieto.
        private void btnSandwich_MouseLeave(object sender, EventArgs e)
        {
            //no cargue la imagen
            imagen.Hide();
        }
        //creamos un evento de mouseHover
        private void btnLonche_MouseHover(object sender, EventArgs e)
        {
            //va agargar la imagen cuando el mouse se quede quieto en el boton 
            imagen.pbImagen.Image = Properties.Resources.Lonche;
            //se va a cerrar cuando se quite el mouse del boton
            imagen.Show();
        }
        //creamos un enevto que cuando se este moviendo el mouse no cargue la imagen , ya que quermeos 
        //que solo se cargue cuando este quieto.
        private void btnLonche_MouseLeave(object sender, EventArgs e)
        {
            //no va acargar la imaagen
            imagen.Hide();
        }
        //creamos un evento 
        private void btnGordita_MouseHover(object sender, EventArgs e)
        {
            //va a cargar el from con las imagenes cuando em mouse se quede quieto en el boton
            imagen.pbImagen.Image = Properties.Resources.Gordita;
            //se va a quitar el from cuando el mouse se quite
            imagen.Show();
        }
        //creamos un enevto que cuando se este moviendo el mouse no cargue la imagen , ya que quermeos 
        //que solo se cargue cuando este quieto.
        private void btnGordita_MouseLeave(object sender, EventArgs e)
        {
            //no cargara la iamgen
            imagen.Hide();
        }
        //creamos el evento click 
        private void btnLonche_Click(object sender, EventArgs e)
        {
            //este if es por si el usuario precioan el boton 
            if (progressLonche >= 0 && progressLonche <= 90 )
            {
                //vriable global , se aumento el precio
                total += 40;
                //para que la barra de progreso aumente de 10 en 10 cad avez que de click
                progressLonche += 10;
                //se valla cargado el resultado
                pbLonche.Value = progressLonche;
                lblTotalD.Text = total.ToString();
            }
        }
        //creamos el evento click 
        private void btnGordita_Click(object sender, EventArgs e)
        {
            //este if es por si el usuario precioan el boton 
            if (progressGordita >=0 && progressGordita <= 90)
            {//vriable global , se aumento el precio
                total += 10;
                //para que la barra de progreso aumente de 10 en 10 cad avez que de click
                progressGordita += 10;
                    //cargado el resultado
                pbGordita.Value = progressGordita;
                lblTotalD.Text = total.ToString();
            }
        }
       //lo que se me ocurre es poner otro label sobre ese para en ese mandar la variable, no dijo como tenía que funcionar, solo que lo tenía que hacer, verdad?
        private void btnPizza_Click(object sender, EventArgs e)
        {
            //por si preciona el boton 
            if (progressPizza >= 0 && progressPizza <= 90)
            {
                //el total se valla cargado 
                total += 25;
                //para que la barra de progreso aumente de 10 en 10 cad avez que de click
                progressPizza += 10;
                //se muestre el resultado completo 
                pbPizza.Value = progressPizza;
               lblTotalD.Text = total.ToString();
            }
        }
    }
}
