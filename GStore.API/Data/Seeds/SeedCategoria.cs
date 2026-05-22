using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedCategoria
{
    public SeedCategoria(ModelBuilder modelBuilder)
    {
        List<Categoria> categorias = [
            new() { Id = 1, Nome = "Camisetas" },
            new() { Id = 2, Nome = "Calças"},
            new() { Id = 3, Nome = "Jaquetas"},
            new() { Id = 4, Nome = "Bermudas"}
        ];
        modelBuilder.Entity<Categoria>().HasData(categorias);
    }
}