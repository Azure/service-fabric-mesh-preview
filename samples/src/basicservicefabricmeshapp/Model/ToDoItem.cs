using System;

namespace Model
{
    public class ToDoItem
    {
        public string Description { get; set; }
        public int Index { get; set; }
        public bool Completed { get; set; }

        public ToDoItem(string description)
        {
            Description = description;
            Index = 0;
        }

        public static ToDoItem Load(string description, int index, bool completed)
        {
            ToDoItem newItem = new ToDoItem(description)
            {
                Index = index,
                Completed = completed
            };

            return newItem;
        }
    }
}
