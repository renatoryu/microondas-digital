using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroondasDigital.Entities;
using MicroondasDigital.Enums;
using MicroondasDigital.Exceptions;

namespace MicroondasDigital.Services
{
    public class AquecimentoService
    {
        public Microondas Iniciar(int tempo, int potencia)
        {
            if (tempo < 1 || tempo > 120)
                throw new RegraNegocioException("O tempo deve ser entre 1 e 120 segundos.");

            if (potencia < 1 || potencia > 10)
                throw new RegraNegocioException("A potência deve ser entre 1 e 10.");

            return new Microondas
            {
                TempoRestante = tempo,
                Potencia = potencia,
                Processo = "",
                CaractereAquecimento = '.',
                PermiteAdicionarTempo = true,
                Status = StatusAquecimento.Aquecendo
            };
        }

        public Microondas IniciarPrograma(ProgramaAquecimento programa)
        {
            return new Microondas
            {
                TempoRestante = programa.Tempo,
                Potencia = programa.Potencia,
                Processo = "",
                CaractereAquecimento = programa.Caractere,
                Status = StatusAquecimento.Aquecendo,
                PermiteAdicionarTempo = programa.PermiteAdicionarTempo
            };
        }
    }
}

