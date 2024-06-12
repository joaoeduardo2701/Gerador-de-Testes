using eAgenda.WinApp.Compartilhado;
using Gerador_de_TestesWinApp.ModuloDisciplinas;

namespace Gerador_de_TestesWinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private TabelaDisciplinaControl tabelaDisciplina;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorio)
        {
            repositorioDisciplina = repositorio;
        }

        public override string TipoCadastro => "Disciplina";

        public override string ToolTipAdicionar => "Cadastro de  Disciplina";

        public override string ToolTipEditar => "Editar uma disciplina existente";

        public override string ToolTipExcluir => "Excluir uma disciplina existente";

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina novoDisciplina = telaDisciplina.Disciplina;

            repositorioDisciplina.Cadastrar(novoDisciplina);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoDisciplina.NomeDisciplina}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possivel realizar esta ação sem selecionar algo",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            telaDisciplina.Disciplina = disciplinaSelecionada;

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina disciplinaEditado = telaDisciplina.Disciplina;

            repositorioDisciplina.Editar(idSelecionado, disciplinaEditado);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{disciplinaEditado.NomeDisciplina}\" foi atualizado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina clienteSelecionado = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                     "Não é possível realizar esta ação sem um registro selecionado.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{clienteSelecionado.NomeDisciplina}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioDisciplina.Excluir(clienteSelecionado.Id);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{clienteSelecionado.NomeDisciplina}\" foi excluido com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarClientes();

            return tabelaDisciplina;
        }

        private void CarregarClientes()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplina.AtualizarRegistros(disciplinas);
        }
    }
}
