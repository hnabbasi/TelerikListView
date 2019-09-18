using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmHelpers;
using TelerikListView.Models;

namespace TelerikListView.ViewModels
{
    public class TasksViewModel : BaseViewModel
    {
        public ObservableCollection<Sprint> Burndown { get; }
        public ObservableCollection<User> TeamStatus { get; }
        
        public TasksViewModel()
        {
            Title = "Team Status";
            Burndown = GetReleaseBurndown();
            TeamStatus = GetTeamStatus();
        }

        ObservableCollection<Sprint> GetReleaseBurndown()
        {
            return new ObservableCollection<Sprint>
            {
                new Sprint { Name = "Sprint 13", OpenTasks = 92 },
                new Sprint { Name = "Sprint 15", OpenTasks = 58 },
                new Sprint { Name = "Sprint 16", OpenTasks = 38 },
                new Sprint { Name = "Sprint 18", OpenTasks = 9 }
            };
        }

        ObservableCollection<User> GetTeamStatus()
        {
            return new ObservableCollection<User> {
                new User { Name = "Hussain A.", EmailAddress = "h@h.com" },
                new User { Name = "John P.", EmailAddress = "j@j.com" },
                new User { Name = "Charlotte V.", EmailAddress = "l@k.com" },
                new User { Name = "Kimberly R.", EmailAddress = "l@k.com" },
                new User { Name = "Steve J.", EmailAddress = "l@k.com" }
            };
        }
    }
}
