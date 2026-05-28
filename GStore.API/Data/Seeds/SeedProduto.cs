using GStore.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;

namespace GStore.API.Data.Seeds;

public class SeedProduto
{
    public SeedProduto(ModelBuilder modelBuilder)
            {
                List<Produto> produtos = [
                new() {
                Id = 1,
                CategoriaId = 1,
                Nome = "Camisa Corinthians II 26/27 s/n Torcedor Nike Masculina - Preto+Branco",
                Descricao = @"texto",
                ValorCusto = 129.90m,
                ValorVenda = 249.90m,
                Qtde = 15,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

            new() {
                Id = 2,
                CategoriaId = 1,
                Nome = "Camisa Corinthians III 25/26 s/n Torcedor Nike Total 90 Masculina - Preto+Laranja",
                Descricao = @"texto",
                ValorCusto = 139.90m,
                ValorVenda = 269.90m,
                Qtde = 10,
                Destaque = true,
                Foto = "/img/produtos/2.png"
            },

            new() {
                Id = 3,
                CategoriaId = 2,
                Nome = "Calça Corinthians III 25/26 Nike Masculina - Preto+Laranja",
                Descricao = @"texto",
                ValorCusto = 99.90m,
                ValorVenda = 189.90m,
                Qtde = 8,
                Destaque = true,
                Foto = "/img/produtos/3.png"
            },
            
            new() {
                Id = 4,
                CategoriaId = 2,
                Nome = "Calça Corinthians Treino 26/27 Nike Masculina - Preto",
                Descricao = @"texto",
                ValorCusto = 109.90m,
                ValorVenda = 199.90m,
                Qtde = 12,
                Destaque = true,
                Foto = "/img/produtos/4.png"
            },

            new() {
                Id = 5,
                CategoriaId = 3,
                Nome = "Jaqueta Corinthians T90 Nike Masculina - Preto+Laranja",
                Descricao = @"texto",
                ValorCusto = 179.90m,
                ValorVenda = 329.90m,
                Qtde = 6,
                Destaque = true,
                Foto = "/img/produtos/5.png"
            },
            
            new() {
                Id = 6,
                CategoriaId = 3,
                Nome = "Jaqueta Corinthians Treino 26/27 Jogador Nike Masculina - Bordô",
                Descricao = @"texto",
                ValorCusto = 189.90m,
                ValorVenda = 349.90m,
                Qtde = 5,
                Destaque = true,
                Foto = "/img/produtos/6.png"
            },

            new() {
                Id = 7,
                CategoriaId = 4,
                Nome = "Shorts Corinthians Esportivo Masculino - Preto",
                Descricao = @"texto",
                ValorCusto = 59.90m,
                ValorVenda = 119.90m,
                Qtde = 20,
                Destaque = true,
                Foto = "/img/produtos/7.png"
            },
            
            new() {
                Id = 8,
                CategoriaId = 4,
                Nome = "Shorts Cargo Corinthians Nike Masculino - Preto+Branco",
                Descricao = @"texto",
                ValorCusto = 79.90m,
                ValorVenda = 149.90m,
                Qtde = 14,
                Destaque = true,
                Foto = "/img/produtos/8.png"
            },
        ];
    }
}