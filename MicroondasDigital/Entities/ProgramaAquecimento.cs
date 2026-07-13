using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroondasDigital.Entities
{
    public class ProgramaAquecimento
    {
        public string Nome { get; set; }

        public string Alimento { get; set; }

        public int Tempo { get; set; }

        public int Potencia { get; set; }

        public char Caractere { get; set; }

        public string Instrucoes { get; set; }

        public bool Personalizado { get; set; }

        public bool PermiteAdicionarTempo { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
