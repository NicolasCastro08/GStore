using GStore.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedUsuario
{
    public SeedUsuario(ModelBuilder builder)
    {
        #region Perfis de Usuário
        List<IdentityRole> perfis = [
            new() {
                Id = "893fe876-481f-476a-bd49-d1f27646ee55",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new() {
                Id = "781cd017-4d08-4452-9f54-3d55d25a2d01",
                Name = "Cliente",
                NormalizedName = "CLIENTE"
            }
        ];
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion

        #region Usuário
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
        #endregion

        #region Usuário Perfil
        List<IdentityUserRole<string>> userRoles = [
            new() {
                UserId = usuarios[0].Id,
                RoleId = perfis[0].Id
            }
        ];
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}