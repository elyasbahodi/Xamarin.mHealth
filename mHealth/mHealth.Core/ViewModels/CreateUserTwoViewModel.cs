using mHealth.core.Business_Logic;
using mHealth.core.Converter;
using mHealth.core.Models;
using mHealth.core.Services;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{


    public class CreateUserTwoViewModel : MvxViewModel
    {
        private User user;
        private EnumDisplayNameValueConverter displayNameValueConverter;

        private UserService userService;
     

        public ICommand NavigateToLogin => new MvxAsyncCommand(Navigate);
      

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




        public IEnumerable<Gender> GenderTypes
        {
            get { return Enum.GetValues(typeof(Gender)).Cast<Gender>(); }

        }
        private Gender _selectedType;
        public Gender SelectedType
        {
            get { return _selectedType; }
            set { _selectedType = value; RaisePropertyChanged(() => SelectedType); }
        }

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; RaisePropertyChanged(() => Birthday); }
        }

        private int _weight;

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; RaisePropertyChanged(() => Weight); }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; RaisePropertyChanged(() => Height); }
        }

        private string _btnText;

        public string BtnText
        {
            get { return _btnText; }
            set { _btnText = value; RaisePropertyChanged(() => BtnText); }
        }

        public CreateUserTwoViewModel()
        {
           // Init(username, password);
            user = new User();
            userService = new UserService();
            displayNameValueConverter = new EnumDisplayNameValueConverter();
            BtnText = "Opret Profil"; 
        }

        public async Task Navigate()
        {
            if (BtnText == "Prøv igen")
            {
                ShowViewModel<CreateUserOneViewModel>();
            }

            if (Validate())
            {
                user.Gender = displayNameValueConverter.Convert(SelectedType);
                user.Weight = Weight;
                user.Height = Height;
                user.Birthdate = Birthday;
               HttpResponseMessage httpResponseMessage = await userService.Create(user);
                if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                   Result = await httpResponseMessage.Content.ReadAsStringAsync();
                    BtnText = "Prøv igen";
               

                }
               
                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    ShowViewModel<LogInViewModel>();
                }

               
            }
            return;
          
           
        }
    


        public void Init(string username, string password)
        {
            user.Username = username;
            user.Password = password;
        }

        private bool Validate()
        {
            var validator = new ValidationHelper();

         

            validator.AddRule(() => Weight ,
                
                () => RuleResult.Assert(Weight > 0, "indtast vægt"));

            validator.AddRule(() => Height,

             () => RuleResult.Assert(Height > 0, "indtast højde"));


            var result = validator.ValidateAll();


            Errors = result.AsObservableDictionary();

            return result.IsValid;
        }


    }





 
}
