using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        private Boton boton;
        private List<Boton> listBotones;
        private string letra1;
        private string letra2;

        public Form1()
        {
            InitializeComponent();
            listBotones = new List<Boton>();
            creaBotones();
            letra1 = "X";
            letra2 = "O";
            
        }
        public void creaBotones()
        { 
            int indice = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    boton = new Boton(this, 12 + 95 * i, 12 + 90 * j,indice);
                    listBotones.Add(boton);
                    Controls.Add(boton);
                    indice++;
                }
            }
        }
        public void Precionado(int numero)
        {
            if (listBotones[numero].Text ==" ")
            {
                listBotones[numero].Text = letra1;
                
            }
            if (BuscaDos(0) == false)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (listBotones[i].Text == " ")
                    {
                        listBotones[i].Text = letra2;
                        i = 10;
                    }
                }
            }
            
        }
        public bool BuscaDos(int numero)
        {
            for (int i = 0; i < 4; i++)
            {
                if (listBotones[numero].Text == letra1 && listBotones[numero + 1].Text == letra1)
                {
                    if (listBotones[numero + 2].Text == " ")
                    {
                        listBotones[numero + 2].Text = letra2;
                        return true;
                    }
                    
                }
                if (listBotones[numero + 1].Text == letra1 && listBotones[numero + 2].Text == letra1)
                {
                    if (listBotones[numero].Text == " ")
                    {
                        listBotones[numero].Text = letra2;
                        return true;
                    }
                }
                if (listBotones[numero].Text == letra1 && listBotones[numero + 2].Text == letra1)
                {
                    if (listBotones[numero + 1].Text == " ")
                    {
                        listBotones[numero + 1].Text = letra2;
                        return true;
                    }
                }
                if(i == 1)
                    numero = 3;
                if (i == 2)
                    numero = 6;
            }
            numero = 0;
            for (int i = 0; i < 4; i++)
            {
                if (listBotones[numero].Text == letra1 && listBotones[numero + 3].Text == letra1)
                {
                    if (listBotones[numero + 6].Text == " ")
                    {
                        listBotones[numero + 6].Text = letra2;
                        return true;
                    }
                }
                if (listBotones[numero + 3].Text == letra1 && listBotones[numero + 6].Text == letra1)
                {
                    if (listBotones[numero].Text == " ")
                    {
                        listBotones[numero].Text = letra2;
                        return true;
                    }
                }
                if (listBotones[numero].Text == letra1 && listBotones[numero + 6].Text == letra1)
                {
                    if (listBotones[numero + 3].Text == " ")
                    {
                        listBotones[numero + 3].Text = letra2;
                        return true;
                    }
                }
                if (i == 1)
                    numero = 1;
                if (i == 2)
                    numero = 2;
            }
            numero =0;

            if (listBotones[numero].Text == letra1 && listBotones[numero + 4].Text == letra1)
            {
                if (listBotones[numero + 8].Text == " ")
                {
                    listBotones[numero + 8].Text = letra2;
                    return true;
                }
            }
            if (listBotones[numero + 4].Text == letra1 && listBotones[numero + 8].Text == letra1)
            {
                if (listBotones[numero].Text == " ")
                {
                    listBotones[numero].Text = letra2;
                    return true;
                }
            }
            if (listBotones[numero].Text == letra1 && listBotones[numero + 8].Text == letra1)
            {
                if (listBotones[numero+4].Text == " ")
                {
                    listBotones[numero + 4].Text = letra2;
                    return true;
                }
            }
            /////////////////
            if (listBotones[numero + 2].Text == letra1 && listBotones[numero + 4].Text == letra1)
            {
                if (listBotones[numero + 6].Text == " ")
                {
                    listBotones[numero + 6].Text = letra2;
                    return true;
                }
            }
            if (listBotones[numero + 4].Text == letra1 && listBotones[numero + 6].Text == letra1)
            {
                if (listBotones[numero + 2].Text == " ")
                {
                    listBotones[numero + 2].Text = letra2;
                    return true;
                }
            }
            if (listBotones[numero + 2].Text == letra1 && listBotones[numero + 6].Text == letra1)
            {
                if (listBotones[numero + 4].Text == " ")
                {
                    listBotones[numero + 4].Text = letra2;
                    return true;
                }
            } 
            
            return false;
        } 
        
    }
}
