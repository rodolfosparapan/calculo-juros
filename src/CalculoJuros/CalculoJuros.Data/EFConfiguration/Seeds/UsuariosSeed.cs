using CalculoJuros.Domain.Usuarios.Entities;
using System.Linq;

namespace CalculoJuros.Data.EFConfiguration.Seeds
{
    public static class UsuariosSeed
    {
        public static void Executar(CalculoJurosContext context)
        {
            if (context.Usuarios.Any())
            {
                return;
            }

            foreach (var usuario in Listar())
            {
                context.Usuarios.Add(usuario);
            }

            context.SaveChanges();
        }

        public static Usuario[] Listar()
        {
            return new Usuario[]
            {
                new Usuario { Nome = "Administrador", Email = "adm@softplan.com", Senha= "123456" },
            };
        }
    }
}