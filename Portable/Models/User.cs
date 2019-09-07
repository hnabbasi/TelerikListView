using System;
using System.Collections.Generic;
using System.Linq;
using MvvmHelpers;

namespace TelerikListView.Models
{
    public class User : ObservableObject
    {
        //temp
        private int _progress;

        public User()
        {
            _progress = new Random().Next(0, 100);
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        private string _emailAddress;
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { SetProperty(ref _emailAddress, value); }
        }
        private IList<Task> _tasks;
        public IList<Task> Tasks
        {
            get { return _tasks; }
            set
            {
                SetProperty(ref _tasks, value);
                OnPropertyChanged(nameof(Progress));
                OnPropertyChanged(nameof(Completed));
                OnPropertyChanged(nameof(Total));
            }
        }

        public int Progress => _progress; //(Completed / Total) * 100;
        public int Completed => Tasks.Count(t => t.IsComplete);
        public int Total => Tasks.Count();
    }
}
