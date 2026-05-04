using System.Runtime.CompilerServices;
using GStore.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedUsuario
{
    public SeedUsuario(ModelBuilder builder)
    {
        #region Perfis de Usuario
        List<IdentityRole> perfis = [
            new() {
                Id = "e5e46613-1600-4a23-a5e8-d5cba949b561",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new() {
                Id = "2a8a6a23-ece5-45da-ae85-39344451214b",
                Name = "Cliente",
                NormalizedName = "CLIENTE"
            }
        ];
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion

        #region Usuario
        List<Usuario> usuarios = [
            new() {
               Id = "fca9b084-c3d5-4c55-8b18-66c00289e601",
                Email = "admin@gstore.com.br",
                NormalizedEmail = "ADMIN@GSTORE.COM.BR",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "Diego Fernando dos Santos Junior",
                DataNascimento = DateTime.Parse("02/05/2008"),
                Foto = "/img/usuarios/fca9b084-c3d5-4c55-8b18-66c00289e601.png"
                
            }
        ];
         foreach(var usuario in usuarios)
        {
            PasswordHasher<Usuario> pass = new();
            usuario.PasswordHash = pass.HashPassword(usuario, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        }
        #endregion

        #region Usuario Perfil
        #endregion

        
    }
    
}
