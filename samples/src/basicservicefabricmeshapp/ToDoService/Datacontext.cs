using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoService
{
    public static class DataContext
    {
        public static Model.ToDoList ToDoList { get; } = new Model.ToDoList("Azure learning List");

        static DataContext()
        {
            ToDoList = new Model.ToDoList("Main List");

            // Seed to-do list

            ToDoList.Add(Model.ToDoItem.Load("Learn about microservices", 0, true));
            ToDoList.Add(Model.ToDoItem.Load("Learn about Service Fabric", 1, true));
            ToDoList.Add(Model.ToDoItem.Load("Learn about Service Fabric Mesh", 2, false));
        }
    }
}
