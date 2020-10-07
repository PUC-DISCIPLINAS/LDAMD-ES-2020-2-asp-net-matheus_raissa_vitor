<h1 align="center">
    <span href="">COVID Dashboard ASP.NET Core 🔗 </span>
</h1>

### 💻 Sobre o Projeto

O projeto proposto a ser desenvolvido é um sistema pequeno de dashboard (pode ser no formato de tabela), que irá exibir uma tabela de infecção dos países por COVID-19. Utilizando o ASP.NET MVC.

### ⌨️ Instruções para Execução 

- Na tela inicial do Visual Studio, basta selecionar a opção **Abrir um projeto ou uma solução** e dentro da pasta do projeto selecionar **covid_dashboard_aspnet_core.sln**. 

### ⚙️ Estrutura do Sistema

> Model - É a parte da aplicação que implementa a lógica para a camada de dados da aplicação.

- 🛠 Country: Classe responsável por gerenciar os países que serão cadastrados.  
- 📝 DataCovid: Classe responsável por armazenar os dados: (casos_confirmados, mortes, recuperados).
- :x: ErrorViewModel: Classe gerada automaticamente com responsabilidade de validar a comunicação e erros entre as camadas de _View_ e _Model_. 

> Controller - É a parte mediadora entre a comunicação entre a _View_ e o _Model_. Recebem requisições HTTP e retornam as informações para o browser.

- 🛠 CountriesController / 📝 DataCovidsController: Responsável por realizar as funcionalidades da aplicação, contendo elas: index, details, create, edit, delete, etc.
- :office: HomeController: Responsável por renderizar os dados na página inicial referentes ao DataCovid.

> View - É a camada responsável por fazer a renderização da resposta para o usuário. Utilizando o Razor.

- 🛠 Countries / 📝 DataCovids: Responsável pela interface referente as funcionalidades da aplicação. Contendo: Create, Delete, Details, Edit, Index, geradas automaticamente após a criação dos Controllers.
- :office: Home: Responsável pela interface referente aos dados do DataCovid.
- :round_pushpin: Shared: Responsável pelo nosso layout padrão. 








### ⚙️ Requisitos

- [X] O sistema deve possuir um usuário admin.
- [X] O sistema deve possuir um model que armazenará os dados do COVID-19 e um model que armazena os nomes dos países.
- [X] O sistema deve possuir um CRUD simples para os dados do COVID-19.
- [X] O cadastro dos dados deve possuir um combo box que carrega os dados do model de países.
- [X] Apenas o usuário admin poderá cadastrar dados na tabela do COVID-19.
- [X] Os dados da tabela devem ser exibidos na página principal, aberta e pública para qualquer usuário sem a necessidade de login.
- [X] Deverá ser criado um layout para a tabela.

### :busts_in_silhouette: Alunos

* Matheus Santos Rosa Carneiro - [mcarneirobug](https://github.com/mcarneirobug)
* Raissa Carolina Vilela da Silva - [raissavilela](https://github.com/raissavilela)

### 📝 Professor responsável

* Hugo Bastos de Paula - [hugodepaula](https://github.com/hugodepaula)

