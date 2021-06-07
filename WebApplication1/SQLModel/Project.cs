using System;
using System.Collections.Generic;
using System.Text;

namespace SQLModel
{
    class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public string Picture { get; set; }
        public List<User> Owner { get; set; }
        public List<User> Contributors { get; set; }
    }
}
