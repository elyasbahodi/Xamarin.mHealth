using mHealth.core.Services;
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
    public class CreateUserOneViewModel : MvxViewModel
    {
        public ICommand NavigateToCreateClient => new MvxCommand(GoToNavigateToCreateClient);

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; RaisePropertyChanged(() => Username); }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; RaisePropertyChanged(() => Password); }
        }

        public CreateUserOneViewModel()
        {
        }
        private void GoToNavigateToCreateClient()
        {
            ShowViewModel<CreateUserTwoViewModel>(new { username = Username, password = Password });
        }
    }
}
