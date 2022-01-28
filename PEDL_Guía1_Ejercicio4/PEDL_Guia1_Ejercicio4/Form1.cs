using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEDL_Guia1_Ejercicio4
{
    public partial class Form1 : Form
    {

        enum Posicion //Define un set de constantes que pueden ser asignados a una variable
        {
            izquierda, derecha, arriba, abajo, limite
        }

        private int x;
        private int y;
        private int xmax;
        private int ymax;
        private Posicion objposicion; //Variable del enum Posicion

        public Form1()
        {
            InitializeComponent();
            x = 50; //Inicializamos la variable
            y = 50; //Inicializamos la variable
            objposicion = Posicion.abajo; //Por defecto definimos que se mueve hacia abajo
            xmax = 633;
            ymax = 279;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (objposicion == Posicion.derecha && x <= xmax)
            {

                x += 10; //Desplazarse 10 pixeles a la derecha
            }
            

            if (objposicion == Posicion.izquierda && x > 0)
            {
              
                    x -= 10; //Desplazarse 10 pixeles a la izquierda
            } 

            if (objposicion == Posicion.arriba && y > 0)
            {

                    y -= 10; //Desplazarse 10 pixeles arriba
                
            } 

            if (objposicion == Posicion.abajo && y <= ymax)
            {
                    y += 10; //Desplazarse 10 pixeles abajo
                
            } 


            Invalidate(); //Invalida la superficie del contro y hace que se vuelva a dibujar el control
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("Dvd.png"), x, y, 65, 65);
            //Se dibuja la imagen agragada al proyecto y se establece el punto inicial y tamaño
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //Si se presiona la trecla flecha izquierda
            {
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode == Keys.Right) //Si se presiona la trecla flecha derecha
            {
                objposicion = Posicion.derecha;
            }
            else if (e.KeyCode == Keys.Up) //Si se presiona la trecla flecha arriba
            {
                objposicion = Posicion.arriba;
            }
            else if (e.KeyCode == Keys.Down) //Si se presiona la trecla flecha abajo
            {
                objposicion = Posicion.abajo;
            }
        }
    }
}
