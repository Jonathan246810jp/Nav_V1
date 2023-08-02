using Nav_V1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nav_V1.ViewModel
{
    public class ViewModels : ViewModelBase
    {
        #region Atributos 
        private readonly INavigationServices NavigationServices;
        #endregion
        public ViewModels(INavigationServices navigationService)
        {
            NavigationServices = navigationService;
        }

        private Command iniciaSesionCommand;
        public Command IniciaSesionCommand
        {
            get => iniciaSesionCommand ?? (new Command(async () =>
                {
                    await NavigationServices.Navegar(nameof(TwoPage));
                }));
        }

    }
}

