namespace MicroondasDigital
{
    partial class FrmMicroondas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tempo;
            this.lblTempo = new System.Windows.Forms.Label();
            this.timerAquecimento = new System.Windows.Forms.Timer(this.components);
            this.txtProcesso = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.txtInstrucoes = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPausarCancelar = new System.Windows.Forms.Button();
            this.txtPrograma = new System.Windows.Forms.Label();
            this.cbPrograma = new System.Windows.Forms.ComboBox();
            this.btnNovoPrograma = new System.Windows.Forms.Button();
            tempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F);
            this.lblTempo.Location = new System.Drawing.Point(83, 99);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(242, 92);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "00:00";
            // 
            // timerAquecimento
            // 
            this.timerAquecimento.Enabled = true;
            this.timerAquecimento.Tick += new System.EventHandler(this.timerAquecimento_Tick_1);
            // 
            // txtProcesso
            // 
            this.txtProcesso.Location = new System.Drawing.Point(36, 346);
            this.txtProcesso.Name = "txtProcesso";
            this.txtProcesso.Size = new System.Drawing.Size(703, 96);
            this.txtProcesso.TabIndex = 1;
            this.txtProcesso.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(33, 318);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // tempo
            // 
            tempo.AutoSize = true;
            tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            tempo.Location = new System.Drawing.Point(559, 32);
            tempo.Name = "tempo";
            tempo.Size = new System.Drawing.Size(60, 20);
            tempo.TabIndex = 3;
            tempo.Text = "Tempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(546, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instruções";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(551, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Potência";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(442, 55);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(297, 20);
            this.txtTempo.TabIndex = 6;
            this.txtTempo.TextChanged += new System.EventHandler(this.txtTempo_TextChanged);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(442, 113);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(297, 20);
            this.txtPotencia.TabIndex = 7;
            // 
            // txtInstrucoes
            // 
            this.txtInstrucoes.Location = new System.Drawing.Point(440, 234);
            this.txtInstrucoes.Multiline = true;
            this.txtInstrucoes.Name = "txtInstrucoes";
            this.txtInstrucoes.ReadOnly = true;
            this.txtInstrucoes.Size = new System.Drawing.Size(299, 20);
            this.txtInstrucoes.TabIndex = 8;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnIniciar.Location = new System.Drawing.Point(440, 275);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(147, 56);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar/30s";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click_1);
            // 
            // btnPausarCancelar
            // 
            this.btnPausarCancelar.BackColor = System.Drawing.Color.Red;
            this.btnPausarCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPausarCancelar.Location = new System.Drawing.Point(593, 275);
            this.btnPausarCancelar.Name = "btnPausarCancelar";
            this.btnPausarCancelar.Size = new System.Drawing.Size(146, 56);
            this.btnPausarCancelar.TabIndex = 10;
            this.btnPausarCancelar.Text = "Pausar/Cancelar";
            this.btnPausarCancelar.UseVisualStyleBackColor = false;
            this.btnPausarCancelar.Click += new System.EventHandler(this.btnPausarCancelar_Click_1);
            // 
            // txtPrograma
            // 
            this.txtPrograma.AutoSize = true;
            this.txtPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPrograma.Location = new System.Drawing.Point(546, 152);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(82, 20);
            this.txtPrograma.TabIndex = 11;
            this.txtPrograma.Text = "Programa";
            // 
            // cbPrograma
            // 
            this.cbPrograma.FormattingEnabled = true;
            this.cbPrograma.Location = new System.Drawing.Point(440, 175);
            this.cbPrograma.Name = "cbPrograma";
            this.cbPrograma.Size = new System.Drawing.Size(297, 21);
            this.cbPrograma.TabIndex = 12;
            this.cbPrograma.SelectedIndexChanged += new System.EventHandler(this.cbPrograma_SelectedIndexChanged_1);
            // 
            // btnNovoPrograma
            // 
            this.btnNovoPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnNovoPrograma.Location = new System.Drawing.Point(744, 175);
            this.btnNovoPrograma.Name = "btnNovoPrograma";
            this.btnNovoPrograma.Size = new System.Drawing.Size(45, 23);
            this.btnNovoPrograma.TabIndex = 13;
            this.btnNovoPrograma.Text = "+";
            this.btnNovoPrograma.UseVisualStyleBackColor = true;
            this.btnNovoPrograma.Click += new System.EventHandler(this.btnNovoPrograma_Click);
            // 
            // FrmMicroondas
            // 
            this.ClientSize = new System.Drawing.Size(806, 475);
            this.Controls.Add(this.btnNovoPrograma);
            this.Controls.Add(this.cbPrograma);
            this.Controls.Add(this.txtPrograma);
            this.Controls.Add(this.btnPausarCancelar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtInstrucoes);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(tempo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtProcesso);
            this.Controls.Add(this.lblTempo);
            this.Name = "FrmMicroondas";
            this.Text = "Micro-ondas Digital";
            this.Load += new System.EventHandler(this.FrmMicroondas_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer timerAquecimento;
        private System.Windows.Forms.RichTextBox txtProcesso;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.TextBox txtInstrucoes;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPausarCancelar;
        private System.Windows.Forms.Label txtPrograma;
        private System.Windows.Forms.ComboBox cbPrograma;
        private System.Windows.Forms.Button btnNovoPrograma;
    }
}

