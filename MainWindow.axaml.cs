using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace TodoListAvalonia
{
    public partial class MainWindow : Window
    {
        TodoList todos;
        public MainWindow()
        {
            InitializeComponent();
            todos = new();
        }

        private void OnClickAddTODO(object sender, RoutedEventArgs e)
        {
            todos.Add(txtTODO.Text);
            txtItemTODO.Text = todos.Show();
        }

        private void OnClickDeleteTODO(object sender, RoutedEventArgs e)
        {
            todos.Delete(txtTODODelete.Text);
            txtItemTODO.Text = todos.Show();
        }

        private void OnClickResetTODO(object sender, RoutedEventArgs e)
        {
            todos.DeleteAll();
            txtItemTODO.Text = todos.Show();
        }

        private void OnClickEditTODO(object sender, RoutedEventArgs e)
        {
            todos.Delete(txtTODOEditOld.Text);
            todos.Add(txtTODOEditNew.Text);
            txtItemTODO.Text = todos.Show();
        }
    }
}