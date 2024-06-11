# Especificações - Gerador de Testes

## Sumário Executivo:

Mariana prepara diversos exercícios para suas filhas que estão na 1ª e 2ª séries.  Ela gostaria de informatizar esses exercícios, para gerar testes aleatórios. Cada teste  gerado deve ser guardado (acompanhado de suas questões), com a indicação de sua  data de geração. Na geração de um teste, é preciso informar o número de questões  desejadas e qual a disciplina pertence ao teste.

Para cada disciplina, cadastra-se: uma lista de questões objetivas, e matérias pertencentes. O gabarito também é  cadastrado a fim de facilitar a correção do teste. Cada matéria faz parte de uma única  disciplina. A série está ligada à matéria. 
Requisitos Funcionais

# 1 - Módulo de Disciplinas
Requisito 1.1: Cadastrar Novas Disciplinas
Critérios:
O registro de disciplina é composto por nome
O campo nome é obrigatório
Não pode registrar uma disciplina com o mesmo nome
A disciplina deve armazenar informações sobre as matérias que serão relacionadas à ela posteriormente
Protótipo:

Requisito 1.2: Editar Disciplinas
	Critérios:
Os critérios de validação são os mesmos do Requisito 1.1
Requisito 1.3: Excluir Disciplinas
	Critérios:
Não deve ser possível excluir disciplinas com matérias e testes relacionados.
Requisito 1.4 Visualizar Todas as Disciplinas.
Critérios:
Deve exibir: Id e Nome

# 2 - Módulo de Matérias
Requisito 2.1: Cadastrar Matérias.
Critérios:
O registro de matéria é composto por nome, disciplina e série
Todos os campos são obrigatórios
Não pode registrar uma matéria com o mesmo nome
Protótipos:

Requisito 2.2: Editar Matérias.
	Critérios:
Os critérios de validação são os mesmos do do Requisito 2.1
Requisito 2.3: Excluir Matérias.
	Critérios:
Não deve ser possível excluir matérias sendo utilizadas em questões.
Requisito 2.4: Visualizar Todas as Matérias.
	Critérios:
Deve exibir: Id, Nome, Disciplina e Série



#3 - Módulo de Questões
Requisito 3.1: Cadastrar Questões.
Critérios:
O registro de questão é composto por matéria, enunciado e alternativas.
Todos os campos são obrigatórios
Cada questão deve ter um mínimo e máximo de alternativas (máximo sugerido: 4)
Protótipo:


Requisito 3.2: Editar Questões.
	Critérios:
Os critérios de validação são os mesmos do Requisito 3.1
Requisito 3.3: Excluir Questões.
	Critérios:
Não deve ser possível excluir uma questão relacionada a um teste.
Requisito 3.5: Visualizar Todas as Questões.
Critérios:
Deve exibir: Id, Enunciado, Matéria e Resposta Correta
Requisito 3.6: Configurar Alternativas da Questão.
Critérios:
Deve permitir adicionar alternativas à questão
Deve permitir remover alternativas à questão
Não permitir o cadastro de questões sem uma alternativa correta
Não deve permitir o cadastro de mais de uma alternativa correta
No mínimo duas alternativas devem ser configuradas

# 4 - Módulo de Testes
Requisito 4.1: Gerar Testes.
Critérios:
O registro de teste é composto por título, disciplina, matéria*, série e quantidade de questões
Deve ser informado a quantidade de questões que deverão ser geradas
Não pode registrar um teste com o mesmo nome
A quantidade de questões informada deve ser menor ou igual a quantidade de questões cadastradas
As matérias devem ser carregadas a partir da disciplina selecionada
Não deve permitir selecionar uma matéria que não pertença a disciplina selecionada.
Caso a disciplina seja alterada, o campo matéria deve ficar em branco
Caso seja “Prova de Recuperação” deve considerar as questões de todas as matérias da disciplina selecionada
Todos os campos são obrigatórios.
As questões devem ser selecionadas de forma aleatória
Protótipo:


Requisito 4.2: Duplicar Testes.
Critérios:
Deve permitir duplicar testes
Na duplicação do teste o título, disciplina, quantidade de questões, série, prova de recuperação e matéria deverão vir preenchidos
Não pode duplicar um teste com o mesmo nome
Na duplicação do teste, as questões devem vir em branco
Protótipo:







Requisito 4.3: Excluir Testes.
	Critérios:
Deve permitir excluir testes existentes
Requisito 4.4: Visualizar Todos os Testes.
Critérios:
Deve exibir: Id, Título, Disciplina, Matéria (ou informar se é recuperação) e Quantidade de Questões
Requisito 4.5: Visualizar Detalhes sobre Testes.
Critérios:
Deve ser possível visualizar os testes individualmente, com informações detalhadas incluindo as questões.
		Protótipo:
		

Requisito 4.6: Gerar PDF dos Testes.
Critérios:
O arquivo PDF do Teste deve apresentar: Título, Disciplina, Matéria, as questões e suas as alternativas
Requisito 4.7: Gerar PDF do Gabarito dos Testes.
Critérios:
O arquivo PDF do Gabarito do Teste deve apresentar: Título, Disciplina, Matéria, as questões e suas alternativas (com a alternativa correta assinalada)
Requisitos Não Funcionais

# Persistência das informações
Critérios:
Os dados devem ser salvos e recuperados em arquivo.

# Arquitetural 
Critérios:
Deve-se trabalhar utilizando o modelo MVC
Exemplo de nomenclatura dentro do projeto: ModuloDisciplina

# Interfaces com Usuário
Critérios:	
* A visualização dos registros deve ser apresentada utilizando o componente DataGridView
* As telas de cadastro devem aparecer centralizadas
* Não deve permitir redimensionar telas de cadastro
* Não deve permitir minimizar ou maximizar telas de cadastro
* As telas de cadastro devem ser dialogs
* As telas de cadastro devem ter um título
* Os elementos das telas de cadastro devem seguir um padrão de posicionamento
* Os elementos das telas de cadastro devem estar alinhados
* O nome do sistema deve ser apresentado na tela principal
* As notificações para usuário devem ser apresentadas seguindo um padrão
* As telas de cadastro devem ter uma opção que fecha a janela e não grava as alterações
* As telas de cadastro devem ter uma opção que grava as alterações
* A tabulação dos campos deve seguir uma sequência lógica iniciando pelos campos superiores
* As alterações realizadas devem ser gravadas e devem manter uma referência única em todas as telas
* As telas de listagem devem permitir selecionar apenas um registro
