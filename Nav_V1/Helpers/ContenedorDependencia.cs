using Nav_V1.Services;
using Nav_V1.Services.Interfaces;
using Nav_V1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nav_V1.Helpers
{
   public static class ContenedorDependencia
    {
        #region Metodos
        public static IServiceCollection AgregarDependencias(this IServiceCollection services)
        {
            services.AddSingleton<INavigationServices, NavigationServices>();
            services.AddSingleton<ViewModels>();
            services.AddTransient<MainPage>();
            services.AddTransient<TwoPage>();
            return services;
        }
        #endregion
    }
}
