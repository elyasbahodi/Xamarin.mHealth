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
    public class CreateClientViewModel : MvxViewModel<Account>
    {
        private Account Account;
        private Client Client;
      

        private ClientService ClientService;
        public IMvxNavigationService _navigationService { get; set; }


       

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

        public CreateClientViewModel(IMvxNavigationService navigationService)
        {
            Client = new Client();
         
            _navigationService = navigationService;
            ClientService = new ClientService();



        }

        public override void Prepare(Account parameter)
        {
            Account = parameter;
        }

        public async Task Navigate()
        {
            Client.gender = GenderConverter.Convert(SelectedType);
            Client.weight = Weight;
            Client.height = Height; 
            Client.birthdate = Birthday;
            Client.ID = Account.CPR;
            ClientService.Create(Client); 
            await _navigationService.Navigate<LogInViewModel>();
        }

        



        

    }
}
