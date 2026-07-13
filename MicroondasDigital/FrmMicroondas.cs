using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroondasDigital.Entities;
using MicroondasDigital.Enums;
using MicroondasDigital.Exceptions;
using MicroondasDigital.Services;

namespace MicroondasDigital
{
    public partial class FrmMicroondas : Form

    {
        private readonly AquecimentoService _service = new AquecimentoService();
        private readonly ProgramaService _programaService = new ProgramaService();

        private Microondas _microondas;
        public FrmMicroondas()
        {
            InitializeComponent();
        }


        private void FrmMicroondas_Load_1(object sender, EventArgs e)
        {
            cbPrograma.DataSource = _programaService.ObterTodos();
            cbPrograma.SelectedIndex = -1;
            cbPrograma.DrawMode = DrawMode.OwnerDrawFixed;
            cbPrograma.DrawItem += cbPrograma_DrawItem;
        }

        private void cbPrograma_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            var programa = (ProgramaAquecimento)cbPrograma.Items[e.Index];

            Font fonte = e.Font;

            if (programa.Personalizado)
            {
                fonte = new Font(e.Font, FontStyle.Italic);
            }
            else
            {
                fonte = new Font(e.Font, FontStyle.Regular);
            }

            e.DrawBackground();

            e.Graphics.DrawString(
                programa.Nome,
                fonte,
                Brushes.Black,
                e.Bounds
            );

            e.DrawFocusRectangle();

            fonte.Dispose();
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if (_microondas != null && _microondas.Status == StatusAquecimento.Aquecendo)
            {
                if (_microondas.PermiteAdicionarTempo)
                {
                    _microondas.TempoRestante += 30;

                    lblTempo.Text = TimeSpan
                        .FromSeconds(_microondas.TempoRestante)
                        .ToString(@"mm\:ss");
                }

                return;

            }
            if (_microondas != null && _microondas.Status == StatusAquecimento.Pausado)
            {
                _microondas.Status = StatusAquecimento.Aquecendo;

                lblStatus.Text = "Aquecendo...";

                timerAquecimento.Start();

                return;
            }
            try
            {
                int tempo;
                int potencia;

                // Início rápido
                if (string.IsNullOrWhiteSpace(txtTempo.Text))
                    tempo = 30;
                else
                    tempo = int.Parse(txtTempo.Text);

                if (string.IsNullOrWhiteSpace(txtPotencia.Text))
                    potencia = 10;
                else
                    potencia = int.Parse(txtPotencia.Text);

                if (cbPrograma.SelectedItem != null)
                {
                    var programa = (ProgramaAquecimento)cbPrograma.SelectedItem;
                    _microondas = _service.IniciarPrograma(programa);
                }
                else
                {
                    _microondas = _service.Iniciar(tempo, potencia);
                }

                lblTempo.Text = TimeSpan.FromSeconds(_microondas.TempoRestante).ToString(@"mm\:ss");

                lblStatus.Text = "Aquecendo...";

                timerAquecimento.Start();
            }
            catch (RegraNegocioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Valores inválidos.");
            }
        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPausarCancelar_Click_1(object sender, EventArgs e)
        {
            if (_microondas == null)
            {
                txtTempo.Clear();
                txtPotencia.Clear();
                lblTempo.Text = "00:00";
                lblStatus.Text = "Pronto";
                txtProcesso.Text = "";
                return;
            }

            if (_microondas.Status == StatusAquecimento.Aquecendo)
            {
                timerAquecimento.Stop();

                _microondas.Status = StatusAquecimento.Pausado;

                lblStatus.Text = "Pausado";

                return;
            }

            if (_microondas.Status == StatusAquecimento.Pausado)
            {
                timerAquecimento.Stop();

                _microondas = null;

                txtTempo.Clear();
                txtPotencia.Clear();

                lblTempo.Text = "00:00";

                lblStatus.Text = "Cancelado";
                txtProcesso.Clear();

                txtTempo.Enabled = true;
                txtPotencia.Enabled = true;

                cbPrograma.SelectedIndex = -1;

                txtInstrucoes.Clear();

                return;
            }
        }

        private void timerAquecimento_Tick_1(object sender, EventArgs e)
        {
            if (_microondas == null)
                return;

            _microondas.TempoRestante--;

            lblTempo.Text = TimeSpan.FromSeconds(_microondas.TempoRestante).ToString(@"mm\:ss");

            lblStatus.Text = "Aquecendo...";

            _microondas.Processo += new string(_microondas.CaractereAquecimento, _microondas.Potencia) + " ";
            txtProcesso.Text = _microondas.Processo;

            if (_microondas.TempoRestante <= 0)
            {
                timerAquecimento.Stop();

                _microondas.Status = StatusAquecimento.Finalizado;

                lblTempo.Text = "00:00";

                lblStatus.Text = "Aquecimento concluído";

                txtProcesso.Text = _microondas.Processo + " Aquecimento concluído";

                MessageBox.Show("Aquecimento concluído!", "Micro-ondas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _microondas = null;

                return;
            }
        }

        private void cbPrograma_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbPrograma.SelectedItem == null)
            {
                txtTempo.Enabled = true;
                txtPotencia.Enabled = true;

                txtTempo.Clear();
                txtPotencia.Clear();

                txtInstrucoes.Clear();

                return;
            }

            var programa = (ProgramaAquecimento)cbPrograma.SelectedItem;

            txtTempo.Text = programa.Tempo.ToString();
            txtPotencia.Text = programa.Potencia.ToString();

            txtTempo.Enabled = false;
            txtPotencia.Enabled = false;

            txtInstrucoes.Text = programa.Instrucoes;
        }

        private void btnNovoPrograma_Click(object sender, EventArgs e)
        {
            FrmCadastroPrograma frm = new FrmCadastroPrograma();

            frm.ShowDialog();

            cbPrograma.DataSource = null;
            cbPrograma.DataSource = _programaService.ObterTodos();
            cbPrograma.SelectedIndex = -1;
        }
    }
}
