using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListAvalonia
{
    internal class TodoList
    {
        private List<string> todos = [];
        public void Add(string todo)
        {
            todos.Add(todo);
        }

        public void Delete(string todo)
        {
            todos.Remove(todo);
        }

        public void Edit(string oldTodo, string newTodo)
        {
            todos.Remove(oldTodo);
            todos.Add(newTodo);
        }

        public void DeleteAll()
        {
            todos.Clear();
        }

        public string Show()
        {
            string todos_str = "";
            foreach (string item in todos)
            {
                todos_str += "\n" + item;
            }
            return todos_str; 
        }
    }
}
