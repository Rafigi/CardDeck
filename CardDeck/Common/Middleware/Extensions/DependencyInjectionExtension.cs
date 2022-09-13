using CardDeck.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CardDeck.Common.Middleware.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void AddDependencyInjections(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICardService, CardService>();
        }
    }
}
