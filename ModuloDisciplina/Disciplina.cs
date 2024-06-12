using eAgenda.ConsoleApp.Compartilhado;

namespace Gerador_de_TestesWinApp.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string NomeDisciplina {  get; set; }

        public Disciplina(string nomeDisciplina)
        {
            NomeDisciplina = nomeDisciplina;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina atualizado = (Disciplina)novoRegistro;

            NomeDisciplina = atualizado.NomeDisciplina;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(NomeDisciplina.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }
    }
}
