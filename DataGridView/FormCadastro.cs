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
    public partial class FormCadastro : Form
    {
        public int valida;
        List<Pessoa> lista = new List<Pessoa>();

        public void validaCampo()
        {
            if (txtNome.Text == "" || mtxtCPF.Text == "" || mtxtRG.Text == "" || cmbSexo == null || dtpDataNascimento == null ||  (rbNao.Checked == false) && (rbSim.Checked == false))
            {
                lblValida.Visible = true;
                valida = 0;
            }
            else
            {
                valida = 1;
            }
        }
        private void preencherDataGridView()
        {
            dgvClientes.Rows.Clear();

            for(int i = 0; i  < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Nome,
                    lista[i].DataNascimento,
                    lista[i].Sexo == 'F' ? "Feminino" : "Masculino",
                    lista[i].CPF, lista[i].RG,
                    lista[i].NecessidadeEspeciais == false ? "Não" : "Sim"
                };

                dgvClientes.Rows.Add(nova_linha);
            }
        }
        public void limpaCampos()
        {
            txtNome.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            cmbSexo.Text = "";
            if (rbSim.Checked)
            {
                rbSim.Checked = false;
            }
            else
            {
                rbNao.Checked = false;
            }
            mtxtCPF.Clear();
            mtxtRG.Clear();
            lblExcluido.Visible = false;
        }

        public FormCadastro()
        {
            InitializeComponent();
            lblExcluido.Visible = false;
            lblValida.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            validaCampo();
            if (valida == 1)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = txtNome.Text;

                // 0 - Masculino, 1 - Feminino
                if (cmbSexo.SelectedIndex == 0)
                {
                    pessoa.Sexo = 'M';
                }
                else
                {
                    pessoa.Sexo = 'F';
                }

                pessoa.DataNascimento = dtpDataNascimento.Text;

                if (rbSim.Checked)
                {
                    pessoa.NecessidadeEspeciais = true;
                }
                else
                {
                    pessoa.NecessidadeEspeciais = false;
                }

                pessoa.RG = mtxtRG.Text;
                pessoa.CPF = mtxtCPF.Text;
                lista.Add(pessoa);

                preencherDataGridView();
                limpaCampos();
                lblValida.Visible = false;
            }
            
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indiceLinha = dgvClientes.CurrentRow.Index;
            lista.RemoveAt(indiceLinha);
            limpaCampos();
            lblExcluido.Visible = true;
            dgvClientes.Rows.Clear();
            preencherDataGridView();
        }
    }
}
