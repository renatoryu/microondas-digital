using MicroondasDigital.Entities;
using MicroondasDigital.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroondasDigital
{
    public partial class FrmCadastroPrograma : Form
    {
        private readonly ProgramaService _programaService = new ProgramaService();
        public FrmCadastroPrograma()
        {
            InitializeComponent();
        }

        private void FrmCadastroPrograma_Load(object sender, EventArgs e)
        {
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
            string.IsNullOrWhiteSpace(txtAlimento.Text) ||
            string.IsNullOrWhiteSpace(txtTempo.Text) ||
            string.IsNullOrWhiteSpace(txtPotencia.Text) ||
            string.IsNullOrWhiteSpace(txtCaractere.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");

                return;
            }

            int tempo;
            int potencia;

            if (!int.TryParse(txtTempo.Text, out tempo))
            {
                MessageBox.Show("Tempo inválido.");
                return;

            }

            if (tempo <= 0)
            {
                MessageBox.Show("O tempo deve ser maior que zero.");
                return;
            }


            if (!int.TryParse(txtPotencia.Text, out potencia))
            {
                MessageBox.Show("Potência inválida.");
                return;
            }

            if (potencia < 1 || potencia > 10)
            {
                MessageBox.Show("A potência deve ser entre 1 e 10.");
                return;
            }

            if (txtCaractere.Text.Length != 1)
            {
                MessageBox.Show("Informe apenas um caractere.");
                return;
            }

            char caractere = txtCaractere.Text[0];

            if (caractere == '.')
            {
                MessageBox.Show("O caractere '.' não pode ser utilizado.");

                return;
            }

            var programas = _programaService.ObterTodos();

            if (programas.Any(x => x.Caractere == caractere))
            {
                MessageBox.Show("Este caractere já está sendo utilizado.");

                return;
            }

            ProgramaAquecimento programa = new ProgramaAquecimento
            {
                Nome = txtNome.Text,
                Alimento = txtAlimento.Text,
                Tempo = tempo,
                Potencia = potencia,
                Caractere = caractere,
                Instrucoes = txtInstrucoes.Text,
                Personalizado = true,
                PermiteAdicionarTempo = false
            };

            _programaService.Adicionar(programa);

            MessageBox.Show("Programa cadastrado com sucesso!");

            this.Close();
        }

        private void txtInstrucoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
