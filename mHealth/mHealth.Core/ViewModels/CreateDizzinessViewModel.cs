using mHealth.core.Models;
using mHealth.core.Services;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{
    public class CreateDizzinessViewModel : MvxViewModel<User>
    {
        private User User { get; set; }
        private DizzinessService dizzinessService;
        Dizziness dizziness;
        public ICommand MeasureDizzinessCommand => new MvxAsyncCommand(NavigateToMainMenu);  

        private int _level;

        public int Level
        {
            get { return _level; }
            set { _level = value; RaisePropertyChanged(() => Level); }
        }

        private string _result;

        public string Result
        {
            get { return _result; }
            set { _result = value; RaisePropertyChanged(() => Result); }
        }



        public CreateDizzinessViewModel()
        {
            dizzinessService = new DizzinessService();
            dizziness = new Dizziness();

        }

        public async Task NavigateToMainMenu()
        {
            HttpResponseMessage response;
            try
            {
                dizziness.Date = DateTime.Now;
                dizziness.Level = Level;
                dizziness.UserID = User.Username;
                response = await dizzinessService.Create(dizziness);
            }
            catch (Exception)
            {
                Result = "Something went wrong, try again.";
            }            
        }

        public override void Prepare(User parameter)
        {
            User = parameter;
        }


    }
}
