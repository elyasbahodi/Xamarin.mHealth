using mHealth.core.Models;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel<User>
    {
        private User user;

        private List<string> _columnNames;

        public List<string> ColumnNames
        {
            get { return _columnNames; }
            set { _columnNames = value; RaisePropertyChanged(() => ColumnNames); }
        }

        private string _profileColumn;

        public string ProfileColumn
        {
            get { return _profileColumn; }
            set { _profileColumn = value; RaisePropertyChanged(() => ProfileColumn); }
        }

        private string _smartStepColumn;

        public string SmartStepColumn
        {
            get { return _smartStepColumn; }
            set { _smartStepColumn = value; RaisePropertyChanged(() => SmartStepColumn); }
        }

        private string _diaryColumn;

        public string DiaryColumn
        {
            get { return _diaryColumn; }
            set { _diaryColumn = value; RaisePropertyChanged(() => DiaryColumn); }
        }

        private string _exercisesColumn;

        public string ExercisesColumn
        {
            get { return _exercisesColumn; }
            set { _exercisesColumn = value; RaisePropertyChanged(() => ExercisesColumn); }
        }

        private string _dizzinessColumn;

        public string DizzinessColumn
        {
            get { return _dizzinessColumn; }
            set { _dizzinessColumn = value; RaisePropertyChanged(() => DizzinessColumn); }
        }

        private string _statisticColumn;

        public string StatisticColumn
        {
            get { return _statisticColumn; }
            set { _statisticColumn = value; RaisePropertyChanged(() => StatisticColumn); }
        }

        public MainMenuViewModel()
        {
            ColumnNames = new List<string>();
            ColumnNames.Add(ProfileColumn);
            ColumnNames.Add(SmartStepColumn);
            ColumnNames.Add(DiaryColumn);
            ColumnNames.Add(ExercisesColumn);
            ColumnNames.Add(DizzinessColumn);
            ColumnNames.Add(StatisticColumn);

        }

        public override void Prepare(User parameter)
        {
            user = parameter;
        }
    }
}
