﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarioBasico_2020
{
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //VentanaPrincipal v = new VentanaPrincipal();
            //v.Show();
            if (conexion.loginVeterinario(textBoxDNI.Text, textBoxpass.Text))
            {
                this.Hide();
                VentanaPrincipal v = new VentanaPrincipal();
                v.Show();
            }
            else
            {
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
            {
                UsuarioNuevo v = new UsuarioNuevo();
                v.Show();
            }
        }
    }
