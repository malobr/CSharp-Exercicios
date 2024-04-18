using Microsoft.EntityFrameworkCore;

namespace API.Models;

//Classe que representa o Entity Framework Core : Code First
public class AppDataContext : DbContext

{
    //Respresentacao das classes que vao virar tabelas no Banco de Dados
    public DbSet<Produto> Produtos { get; set; }//obrigatoriamente tem que ser public...

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Configuracao da conexao com o Banco de Dados
        optionsBuilder.UseSqlite("Data Source=app.db");

    }



}
