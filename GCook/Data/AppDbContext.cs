using GCook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GCook.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Categoria> categorias { get; set; }
    public DbSet<Comentario> Comentarios { get; set; }
    public DbSet<Ingrediente> Ingredientes { get; set; }
    public DbSet<Receita> Receitas { get; set; }
    public DbSet<ReceitaIngrediente> ReceitaIngredientes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ReceitaIngrediente>()
            .HasKey(ri => new {ri.ReceitaId, ri.IngredienteId});

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Usuário",
               NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@gcook.com",
                NormalizedEmail = "ADMIN@GCOOK.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "Antonio Junior",
                DataNascimento = DateTime.Parse("07/10/1100"),
                Foto = "/img/users/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}
