using Nav_V1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nav_V1.Services
{
    public class NavigationServices : INavigationServices
    {
        #region Metodos
        public Task MostrarSnak(Color color, string mensaje)
        {
            throw new NotImplementedException();
        }

        public Task MostrarToast(string mensaje)
        {
            throw new NotImplementedException();
        }

        public async Task Navegar(string pagina)
        {
            try
            {
                await Shell.Current.GoToAsync(pagina, true);
            }
            catch (Exception e)
            {
                await MostrarToast(e.Message);
            }
        }

        public async Task Regresar()
        {
            try
            {
               await Shell.Current.Navigation.PopAsync();
            }
            catch (Exception e)
            {
                await MostrarToast(e.Message);
            }
        }
        #endregion
    }
}
