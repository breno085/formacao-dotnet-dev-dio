Passo a passo:

1. criar o modelo mvc: dotnet new mvc  
2. adicionar os pacotes nuget do entity framework (o pacote do entity framework ja foi instalado a nível de máquina): dotnet add package Microsoft.EntityFrameworkCore.SqlServer e dotnet add package Microsoft.EntityFrameworkCore.Design  
3. criar a classe contato em models  
4. criar o contexto (Pasta Context e classe AgendaContext)  
5. cadastrar a string de conexão (no arquivo appsettings.Development.json)  
6. adicionar a conexão no Program.cs (builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));)  
7. Criar as migrations: dotnet ef migrations add AdicionaTabelaCo
ntato
8. Aplicar as migrations no projeto: dotnet ef database update
9. Criar uma nova controller (ContatoController) e criar as suas páginas HTML para fazer um CRUD no projeto MVC
    1. Carregar as informações do banco de dados do Contato em tela, através do Entity Framework
    2. Criar página de novo contato e implementar o método Criar como POST
    3. Criar a página de edição e o POST de editar
    4. Criar a página de detalhes
    5. Criar a página de deletar e o POST de deletar