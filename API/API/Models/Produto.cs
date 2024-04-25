﻿
using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Produto
{
    //Construtor
    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    public Produto(string nome, string descricao, double valor)
    {
        Id = Guid.NewGuid().ToString();
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
        CriadoEm = DateTime.Now;
    }

    //Atributos ou propriedades = Características de um objeto
    public string Id { get; set; }

//ANotacao- personalizacao do atributo- data annotations C#
    [Required(ErrorMessage = "Este campo e obrigatorio!")]
    public string? Nome { get; set; }

    //limitacao da descricao
    [MinLength(3, ErrorMessage = "Este campo tem o tamanho minimo de 3 caracteres")]
    [MaxLength(10, ErrorMessage = "Este campo tem o tamanho maximo de 10 caracteres")]
    public string? Descricao { get; set; }


    //LImites para numeros
    [Range (1, 1000, ErrorMessage ="esse campo tem um limite de valor entre 1 e 1000" )]
    public double Valor { get; set; }
    public DateTime CriadoEm { get; set; }
    public int Quantidade { get; set; }
}
