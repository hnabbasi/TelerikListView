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
                new User { Name = "Hussain A.", EmailAddress = "h@h.com", Tasks = new List<Task> { new Task { Title = "Estimate Feature A" }, new Task { Title = "Code Review Feature X", IsComplete = true } } },
                new User { Name = "John P.", EmailAddress = "j@j.com", Tasks = new List<Task> { new Task { Title = "Setup call with Matt" }, new Task { Title = "Email status" } } },
                new User { Name = "Charlotte V.", EmailAddress = "l@k.com", Tasks = new List<Task> { new Task { Title = "Setup call with PM" }, new Task { Title = "Email report" } } },
                new User { Name = "Kimberly R.", EmailAddress = "l@k.com", Tasks = new List<Task> { new Task { Title = "Setup call with BA" }, new Task { Title = "Email PM" } } },
                new User { Name = "Steve J.", EmailAddress = "l@k.com", Tasks = new List<Task> { new Task { Title = "Setup a meeting" }, new Task { Title = "Take Call" } } }
            };
            return new ObservableCollection<User>(statuses);
        }
    }
}
