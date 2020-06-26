using Flunt.Notifications;
using System.Collections.Generic;

namespace CalculoTaxas.Domain.Common.Interfaces
{
    public interface IService
    {
        bool Valido { get; }
        bool Invalido { get; }
        List<Notification> Notificacoes { get; }
    }
}