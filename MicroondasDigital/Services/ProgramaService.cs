using MicroondasDigital.Entities;
using MicroondasDigital.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace MicroondasDigital.Services
{
    public class ProgramaService
    {
        private readonly JsonService _json = new JsonService();

        public List<ProgramaAquecimento> ObterProgramasPadrao()
        {
            return new List<ProgramaAquecimento>
            {
                new ProgramaAquecimento
                {
                    Nome = "Pipoca",
                    Alimento = "Pipoca (micro-ondas)",
                    Tempo = 180,
                    Potencia = 7,
                    Caractere = '*',
                    Instrucoes = "Observar o intervalo entre os estouros.",
                    Personalizado = false,
                    PermiteAdicionarTempo = false
                },

                new ProgramaAquecimento
                {
                    Nome = "Leite",
                    Alimento = "Leite",
                    Tempo = 300,
                    Potencia = 5,
                    Caractere = '~',
                    Instrucoes = "Cuidado com líquidos aquecidos.",
                    Personalizado = false,
                    PermiteAdicionarTempo = false
                },

                new ProgramaAquecimento
                {
                    Nome = "Carnes",
                    Alimento = "Carne",
                    Tempo = 840,
                    Potencia = 4,
                    Caractere = '#',
                    Instrucoes = "Virar o alimento na metade.",
                    Personalizado = false,
                    PermiteAdicionarTempo = false
                },

                new ProgramaAquecimento
                {
                    Nome = "Frango",
                    Alimento = "Frango",
                    Tempo = 480,
                    Potencia = 7,
                    Caractere = '@',
                    Instrucoes = "Virar o alimento na metade.",
                    Personalizado = false,
                    PermiteAdicionarTempo = false
                },

                new ProgramaAquecimento
                {
                    Nome = "Feijão",
                    Alimento = "Feijão",
                    Tempo = 480,
                    Potencia = 9,
                    Caractere = '%',
                    Instrucoes = "Aquecer destampado.",
                    Personalizado = false,
                    PermiteAdicionarTempo = false
                }
            };
        }

        public List<ProgramaAquecimento> ObterTodos()
        {
            var lista = ObterProgramasPadrao();

            var personalizados = _json.Ler();

            foreach (var programa in personalizados)
            {
                programa.Personalizado = true;
            }

            lista.AddRange(personalizados);

            return lista;
        }

        public void Adicionar(ProgramaAquecimento programa)
        {
            var lista = _json.Ler();

            if (lista.Any(x => x.Caractere == programa.Caractere))
            {
                throw new RegraNegocioException(
                    "Este caractere já está sendo utilizado."
                );
            }

            lista.Add(programa);

            _json.Salvar(lista);
        }
    }
}