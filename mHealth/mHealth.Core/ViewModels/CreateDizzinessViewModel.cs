using mHealth.core.Models;
using mHealth.core.Services;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mHealth.core.ViewModels
{
    public class CreateDizzinessViewModel : MvxViewModel<User>
    {
        private User user;
        private DizzinessService dizzinessService;
        Dizziness dizziness;
        public ICommand MeasureDizzinessCommand => new MvxAsyncCommand(NavigateToMainMenu);  

        private int _level;

        public int Level
        {
            get { return _level; }
            set { _level = value; RaisePropertyChanged(() => Level); }
        }


        public CreateDizzinessViewModel()
        {
            dizzinessService = new DizzinessService();
            dizziness = new Dizziness();

        }

        public async Task NavigateToMainMenu()
        {
            dizziness.Date = DateTime.Now;
            dizziness.Level = Level;
            await dizzinessService.Create(dizziness);
            
        }


        public override void Prepare(User parameter)
        {
            user = parameter;
        }
    }
}
