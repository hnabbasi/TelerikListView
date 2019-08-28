using System;
using MvvmHelpers;

namespace TelerikListView.Models
{
    public class Task : ObservableObject
    {
        public string Title { get; set; }
        public bool IsComplete { get; set; }
    }
}
