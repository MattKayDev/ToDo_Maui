using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ToDoMaui.Models;

namespace ToDoMaui.ViewModels
{
    [INotifyPropertyChanged]
    public partial class TodoListPageViewModel
    {
        private TodoItemDatabase database;

        [ObservableProperty]
        private TodoItem item;
        public TodoListPageViewModel(TodoItemDatabase todoItemDatabase)
        {
            // pass across database and if null create a new one
            database = todoItemDatabase ?? new TodoItemDatabase();

        }
    }
}
