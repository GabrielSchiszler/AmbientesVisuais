using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class FormLogin : Form
    {
        public bool entrar;
        public FormLogin()
        {
            InitializeComponent();
            lblErroLogin.Visible = false;
        }

        private void btnLoginEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.login = txtLoginNome.Text;
            usuario.senha = txtLoginSenha.Text;
            entrar = usuario.autenticar();
            if (entrar == true)
            {
                this.Hide();
                FormCadastro cadastro = new FormCadastro();
                cadastro.ShowDialog();
            }
            else
            {
                lblErroLogin.Visible = true;
            }
        }
    }
}
