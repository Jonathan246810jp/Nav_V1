using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nav_V1.Services.Interfaces
{
    public interface INavigationServices
    {
        #region "Implementaciones"
        Task MostrarSnak(Color color, string mensaje);
        Task MostrarToast(string mensaje);
        Task Navegar(string pagina);
        Task Regresar();
        #endregion
    }
}
