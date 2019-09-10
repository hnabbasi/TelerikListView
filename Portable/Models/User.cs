using System;
using System.Collections.Generic;
using System.Linq;
using MvvmHelpers;

namespace TelerikListView.Models
{
    public class User : ObservableObject
    {
        public User()
        {
            var r = new Random();
            Total = r.Next(5, 20);
            Completed = r.Next(1, Total - 1);
            Progress = (Completed * 100) / Total;
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

        public int Progress { get; }
        public int Completed { get; }
        public int Total { get; }
    }
}
