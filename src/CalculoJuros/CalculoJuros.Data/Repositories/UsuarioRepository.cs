using CalculoJuros.Data.EFConfiguration;
using CalculoJuros.Domain.Usuarios.Entities;
using CalculoJuros.Domain.Usuarios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CalculoJuros.Data.Repositories
{
    internal class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(CalculoJurosContext context) : base(context)
        {
        }

        public bool Login(string email, string senha)
        {
            return DbSet.AsNoTracking().Any(u => u.Email == email && u.Senha == senha);
        }
    }
}