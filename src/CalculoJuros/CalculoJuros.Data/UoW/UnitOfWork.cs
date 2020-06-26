using CalculoJuros.Data.EFConfiguration;
using CalculoJuros.Domain.Common.Interfaces;

namespace CalculoJuros.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CalculoJurosContext context;

        public UnitOfWork(CalculoJurosContext context)
        {
            this.context = context;
        }

        public bool Commit()
        {
            return context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}