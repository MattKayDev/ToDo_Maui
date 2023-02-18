using ToDoMaui.ViewModels;

namespace ToDoMaui.Views;

public partial class TodoListPage : ContentPage
{
	public TodoListPage(TodoItemDatabase todoItemDatabase)
	{
		InitializeComponent();
		BindingContext = new TodoListPageViewModel(todoItemDatabase);
	}
}