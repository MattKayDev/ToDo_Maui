using ToDoMaui.ViewModels;

namespace ToDoMaui.Views;

public partial class TodoItemPage : ContentPage
{
	public TodoItemPage(TodoItemDatabase todoItemDatabase)
	{
		InitializeComponent();
		BindingContext = new TodoItemPageViewModel(todoItemDatabase);
	}
}