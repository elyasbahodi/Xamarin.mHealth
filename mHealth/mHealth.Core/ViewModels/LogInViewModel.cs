using Acr.UserDialogs;

using mHealth.core.Business_Logic;
using mHealth.core.Models;
using mHealth.core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{

    public class LogInViewModel : MvxViewModel
    {
        private User user;
        private readonly IMvxNavigationService _navigationService;
        
        public IMvxCommand MvxCreateAccountCommand { get; set; }
        public ICommand NavigateToMainMenuCommand => new MvxAsyncCommand(Navigate);
        public UserService UserService { get; set; }

        private string _result;
        public string Result
        {
            get => _result;
            set { _result = value; RaisePropertyChanged(() => Result); RaisePropertyChanged(() => HasResult); }
        }

        public bool HasResult => string.IsNullOrEmpty(Result) == false;

        private ObservableDictionary<string, string> _errors;
        public ObservableDictionary<string, string> Errors
        {
            get => _errors;
            set { _errors = value; RaisePropertyChanged(() => Errors); }
        }


        private string _txtPassword;
        public string TxtPassword
        {
            get { return _txtPassword; }
            set { _txtPassword = value; RaisePropertyChanged(() => TxtPassword); }
        }
        private string _txtUser;
        public string TxtUser
        {
            get { return _txtUser; }
            set { _txtUser = value; RaisePropertyChanged(() => TxtUser); }
        }

     

        public LogInViewModel(IMvxNavigationService navigationService)
        {
            UserService = new UserService();
            _navigationService = navigationService;
            MvxCreateAccountCommand = new MvxCommand(() => ShowViewModel<CreateUserOneViewModel>());
            user = new User();
          
    }
        
        private async Task Navigate()
        {
            if (Validate())
            {
                try {
                    user = UserService.Get(TxtUser, TxtPassword, user);

                    if (!user.Equals(null))
                    {
                        await _navigationService.Navigate<MainMenuViewModel, User>(user);
                    }
                  
                } catch (Exception ex)
                {
                    Result = "Forkert brugernavn eller kodeord";
                }
            }
            else
            {
                return;
            }
        }

        private bool Validate()
        {
            var validator = new ValidationHelper();
            validator.AddRequiredRule(() => TxtUser, "Brugernavn skal indtastes");
            validator.AddRequiredRule(() => TxtPassword, "Kodeord skal indtastes");

            var result = validator.ValidateAll();


            Errors = result.AsObservableDictionary();

            return result.IsValid;
        }




    }
}
