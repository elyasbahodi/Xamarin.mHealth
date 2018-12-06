using mHealth.core.Models;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.ViewModels
{
    public class CreateClientViewModel : MvxViewModel<Account>
    {
        public Account Account { get; set; }
        public Client Client { get; set; }
        public Gender Gender { get; set; }
        public IMvxNavigationService _navigationService { get; set; }
        public IMvxAsyncCommand MvxAsyncCommand { get; set; }

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

        public CreateClientViewModel(IMvxNavigationService navigationService)
        {
            Client = new Client();
            Gender = new Gender();
            _navigationService = navigationService;
            MvxAsyncCommand = new MvxAsyncCommand(() => _navigationService.Navigate<LogInViewModel>());

        }

        public override void Prepare(Account parameter)
        {
            Account = parameter;
        }
    }
}
