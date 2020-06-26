using System;

namespace CalculoJuros.Domain.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}