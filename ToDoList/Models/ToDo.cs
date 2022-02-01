using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Responsible { get; set; }
        public bool Done { get; set; }

    }
}
