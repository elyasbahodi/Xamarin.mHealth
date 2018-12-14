using mHealth.core.Business_Logic;
using mHealth.core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmValidation;
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
            if (Validate())
            {
                ShowViewModel<CreateUserTwoViewModel>(new { username = Username, password = Password });
            }
        }

        private bool Validate()
        {
            var validator = new ValidationHelper();
            validator.AddRequiredRule(() => Password, "Vælg et kodeord");
            validator.AddRequiredRule(() => Username, "Vælg et brugernavn");
           

            var result = validator.ValidateAll();


            Errors = result.AsObservableDictionary();

            return result.IsValid;
        }
    }
}
