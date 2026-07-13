using MicroondasDigital.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Entities
{
    public class Microondas
    {
        public int TempoRestante { get; set; }
        public int Potencia { get; set; }
        public StatusAquecimento Status { get; set; }
        public string Processo { get; set; }
        public char CaractereAquecimento { get; set; }
        public bool PermiteAdicionarTempo { get; set; }

        public Microondas()
        {
            Potencia = 10;
            Status = StatusAquecimento.Parado;
            Processo = string.Empty;
            CaractereAquecimento = '.';
        }
    }
}
