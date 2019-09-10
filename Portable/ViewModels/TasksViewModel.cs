using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmHelpers;
using TelerikListView.Models;
using System.Linq;

namespace TelerikListView.ViewModels
{
    public class TasksViewModel : BaseViewModel
    {
        private ObservableCollection<User> _teamStatus;
        public ObservableCollection<User> TeamStatus
        {
            get { return _teamStatus; }
            set { SetProperty(ref _teamStatus, value); }
        }

        public TasksViewModel()
        {
            Title = "Team Status";
            TeamStatus = GetTeamStatus();
        }

        ObservableCollection<User> GetTeamStatus()
        {
            var statuses = new List<User> {
                new User { Name = "Hussain A.", EmailAddress = "h@h.com" },
                new User { Name = "John P.", EmailAddress = "j@j.com" },
                new User { Name = "Charlotte V.", EmailAddress = "l@k.com" },
                new User { Name = "Kimberly R.", EmailAddress = "l@k.com" },
                new User { Name = "Steve J.", EmailAddress = "l@k.com" }
            };
            return new ObservableCollection<User>(statuses);
        }
    }
}
