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
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

             new() {
                Id = 2,
                CategoriaId = 1,
                Nome = "Camisa Corinthians III 25/26 s/n Torcedor Nike Total 90 Masculina - Preto+Laranja",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

             new() {
                Id = 1,
                CategoriaId = 2,
                Nome = "Calça Corinthians III 25/26 Nike Masculina - Preto+Laranja",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            
             new() {
                Id = 2,
                CategoriaId = 2,
                Nome = "Calça Corinthians Treino 26/27 Nike Masculina - Preto",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

             new() {
                Id = 1,
                CategoriaId = 3,
                Nome = "Jaqueta Corinthians T90 Nike Masculina - Preto+Laranja",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            
             new() {
                Id = 2,
                CategoriaId = 3,
                Nome = "Jaqueta Corinthians Treino 26/27 Jogador Nike Masculina - Bordô",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },

             new() {
                Id = 1,
                CategoriaId = 4,
                Nome = "",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            
             new() {
                Id = 2,
                CategoriaId = 4,
                Nome = "",
                Descricao = @"texto",
                ValorCusto = 1,
                ValorVenda = 1.99m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
            
        ]; 
    }
}