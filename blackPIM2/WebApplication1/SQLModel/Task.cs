using System;
using System.Collections.Generic;
using System.Text;

namespace SQLModel
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public Project Project { get; set; }
        public List<User> Task_Owner { get; set; }
        public List<User> Task_Executors { get; set; }
    }
}
