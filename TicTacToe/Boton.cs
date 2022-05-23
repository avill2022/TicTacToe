using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    class Boton : Button
    {
        private Form1 form1;

        public Boton()
        { 
            
        }
        public Boton(Form1 form,int i,int j,int indice)
        {
            form1 = form;
            this.Location = new Point(i, j);
            this.Size = new Size(88, 85);
            this.AccessibleName = indice.ToString();
            this.Font = new Font("Arial",40);
            this.Text = " ";
            this.Click += new EventHandler(Boton_Click);
        }

        void Boton_Click(object sender, EventArgs e)
        {
            form1.Precionado(int.Parse(this.AccessibleName));
        }
    }
}
