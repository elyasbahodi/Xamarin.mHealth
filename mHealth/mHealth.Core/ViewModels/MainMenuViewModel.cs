using mHealth.core.Models;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel<User>
    {
        private User user;
        public ICommand DizzinessCommand => new MvxCommand(NavigateToDizziness);
        private IMvxNavigationService _navigationService;

        public MainMenuViewModel(IMvxNavigationService NavigationService)
        {
            _navigationService = NavigationService;
        }

        public void NavigateToDizziness()
        {

            _navigationService.Navigate<CreateDizzinessViewModel, User>(user);
        }



        public override void Prepare(User parameter)
        {
            user = parameter;
        }
    }
}
