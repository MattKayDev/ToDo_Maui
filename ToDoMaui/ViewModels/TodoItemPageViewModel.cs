using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoMaui.Models;

namespace ToDoMaui.ViewModels
{
    [INotifyPropertyChanged]
    public partial class TodoItemPageViewModel
    {
        private TodoItemDatabase database;

        [ObservableProperty]
        private TodoItem item;
        public TodoItemPageViewModel(TodoItemDatabase todoItemDatabase)
        {
            // pass across database and if null create a new one
            database = todoItemDatabase ?? new TodoItemDatabase();
        }

        [RelayCommand]
        private async void SaveItem()
        {
            if (string.IsNullOrWhiteSpace(Item.Title))
            {
                await AppShell.Current.DisplayAlert("Title required", "Please enter a title for the to do item", "OK");
                return;
            }

            await this.database.SaveItemAsync(Item);
            await Shell.Current.Navigation.PopToRootAsync();
        }
    }
}
