using FestasInfantis.WinApp.Compartilhado;

namespace Gerador_de_TestesWinApp.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioBaseEmArquivo<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contexto.Disciplina;
        }
    }
}
