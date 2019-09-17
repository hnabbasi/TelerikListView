using System;
using System.Collections.Generic;
using System.Linq;
using MvvmHelpers;

namespace TelerikListView.Models
{
    public class User
    {
        public User()
        {
            var r = new Random();
            Total = r.Next(5, 20);
            Completed = r.Next(4, Total - 1);
            Progress = (Completed * 100) / Total;
            Capacity = r.Next(25, 100);
        }

        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public int Progress { get; }
        public int Capacity { get; }
        public int Completed { get; }
        public int Total { get; }
    }
}
