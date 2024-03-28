namespace API.Models;

public class Produto
{


    public Produto(string nome, string descricao,  double valor)
    {
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
    }






    //Atributos ou propriedades = Caracteristicas de um objeto //EM C# o ATributo e publico
    public string? Nome { get; set; }  //o ? serve para informarmos que sabemos que a string e null
    public string? Descricao { get; set; }
    public double Valor { get; set; }







   /* private String nome;
    private String descricao;


    public void setNome(String nome)
    {
        this.nome = nome;
    }
    public String getNome()
    {
        return this.nome;
    }*/
}




