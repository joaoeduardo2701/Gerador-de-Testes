using Gerador_de_TestesWinApp.ModuloDisciplina;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FestasInfantis.WinApp.Compartilhado
{
    public class ContextoDados
    {
        private string caminho = $"C:\\temp\\FestasInfantis\\dados.json";

        public List<Disciplina> Disciplina { get; set; }

        public ContextoDados()
        {
            Disciplina = new List<Disciplina>();

        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

            if (ctx == null)
                return;

            Disciplina = ctx.Disciplina;
        }
    }
}
