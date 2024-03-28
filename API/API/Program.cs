/*using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;*/

//using API.Models;

using API.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);   //  (cd ./API/) ir para determinada pasta  || crtl c para a aplicacao
var app = builder.Build();

/*
Produto produto = new Produto();
produto.setNome("Bolacha");
Console.WriteLine(produto.getNome());
*/
/*
Produto produto = new Produto();
produto.Nome = "Bolacha";
Console.WriteLine(produto.Nome);
*/

new Produto();



List<Produto> produtos = [

     new Produto("Celular", "IOS", 1700),
     new Produto("Bolacha", "Trakinas", 2),
     new Produto("Charuto", "Cohiba", 500),
     new Produto("Computador", "Dell", 10.000),
];



//GET: http://localhost:5229/api
app.MapGet("/", () => "API de produtos");

//GET: http://localhost:5229/produto/listar
app.MapGet("/produto/listar", () => produtos);


//GET: http://localhost:5229/produto/buscar/nomedoproduto
app.MapGet("/produto/buscar/{nome}", ([FromRoute] string nome) => 
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].Nome == nome)
            {
                //retornar o produto encontrado
                return Results.Ok(produtos[i]);
            } /*else{
                return null;
            }*/
        }
        return Results.NotFound("Produto nao encontrado");
    }
);


//POST: http://localhost:5229/produto/cadastrar
app.MapPost("/produto/cadastrar//", () => "Cadastro de produtos");


//EXERCICIO: cadastrar um produto a) pala url b) pelo corpo
//remocao do produto
//alteracao do produto

app.Run();




record Produto(string nome, string descricao, int V);
