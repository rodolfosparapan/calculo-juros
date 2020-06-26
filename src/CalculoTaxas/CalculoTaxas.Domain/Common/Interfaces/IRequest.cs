using Flunt.Validations;

namespace CalculoTaxas.Domain.Common.Interfaces
{
    public interface IRequest : IValidatable
    {
    }

    public interface IRequest<T> : IRequest
    {
        T ToDomain();
    }

    public interface IRequest<T, Model> : IRequest
    {
        T ToDomain(Model model);
    }
}