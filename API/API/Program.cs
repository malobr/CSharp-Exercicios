var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos =
[
    new Produto("Celular", "IOS"),
    new Produto("Bolacha", "Trakinas"),
    new Produto("Charuto", "Cohiba"),
    new Produto("Computador", "Dell"),
];

app.MapGet("/produtos/listar", () => produtos);


//Cadastrar produtos dentro da lista
app.MapPost("/produtos/cadastrar", () => "Cadastro de produtos");


app.Run();

record Produto(string nome, string descricao);
