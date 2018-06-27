using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ToDoList
    {
        private List<ToDoItem> _items;

        public string Name { get; set; }
        public IEnumerable<ToDoItem> Items { get => _items; }

        public ToDoList(string name)
        {
            Name = name;
            _items = new List<ToDoItem>();
        }

        public ToDoItem Add(string description)
        {
            var item = new ToDoItem(description);
            _items.Add(item);
            item.Index = _items.IndexOf(item);
            return item;
        }
        public void Add(ToDoItem item)
        {
            _items.Add(item);
            item.Index = _items.Count - 1;
        }

        public ToDoItem RemoveAt(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                var result = _items[index];
                _items.RemoveAt(index);

                // Reorder items
                for (int i = index; i < _items.Count; i++)
                {
                    _items[i].Index = i;
                }

                return result;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
