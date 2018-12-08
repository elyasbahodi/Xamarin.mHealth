using mHealth.core.Converter;
using mHealth.core.Models;
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


    public class CreateUserTwoViewModel : MvxViewModel
    {
        private User user;
        private EnumDisplayNameValueConverter displayNameValueConverter;

        private UserService userService;
     

        public ICommand NavigateToLogin => new MvxAsyncCommand(Navigate);

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

        public CreateUserTwoViewModel()
        {
           // Init(username, password);
            user = new User();
            userService = new UserService();
            displayNameValueConverter = new EnumDisplayNameValueConverter();
        }

        public async Task Navigate()
        {
            user.Gender = displayNameValueConverter.Convert(SelectedType);
            user.Weight = Weight;
            user.Height = Height;
            user.Birthdate = Birthday;
            await userService.Create(user);

            ShowViewModel<LogInViewModel>();
          
           
        }

        public void Init(string username, string password)
        {
            user.Username = username;
            user.Password = password;
        }

    }





 
}
