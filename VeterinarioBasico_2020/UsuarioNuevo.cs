using System;
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
    public partial class UsuarioNuevo : Form
    {
        Conexion conexion = new Conexion();
        public UsuarioNuevo()
        {
            InitializeComponent();
        }

        private void InsertaUsuario_Click(object sender, EventArgs e)
        {
                String textoPassword = textBoxPass.Text;
                String myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
                MessageBox.Show(conexion.insertaUsuario(textBoxDNI.Text, textBoxNombre.Text, myHash));
        }

    }
}
