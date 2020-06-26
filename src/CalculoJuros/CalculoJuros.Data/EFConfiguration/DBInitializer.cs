using CalculoJuros.Data.EFConfiguration.Seeds;

namespace CalculoJuros.Data.EFConfiguration
{
    public static class DBInitializer
    {
        public static void Initialize(CalculoJurosContext context)
        {
            context.Database.EnsureCreated();

            UsuariosSeed.Executar(context);
        }
    }
}