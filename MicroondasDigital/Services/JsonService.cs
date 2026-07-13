using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MicroondasDigital.Entities;

namespace MicroondasDigital.Services
{
    public class JsonService
    {
        private readonly string caminho = "Dados/programas.json";

        public List<ProgramaAquecimento> Ler()
        {
            if (!File.Exists(caminho))
                return new List<ProgramaAquecimento>();

            string json = File.ReadAllText(caminho);

            if (string.IsNullOrWhiteSpace(json))
                return new List<ProgramaAquecimento>();

            return JsonConvert.DeserializeObject<List<ProgramaAquecimento>>(json)
                   ?? new List<ProgramaAquecimento>();
        }

        public void Salvar(List<ProgramaAquecimento> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(caminho, json);
        }
    }
}