using System;
using ToDoList.Models;
using ToDoList.Data;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateNewToDo();


            Console.WriteLine("Vilket Id vill du ta bort?");
            int inputId = Convert.ToInt32(Console.ReadLine());
            using (var database = new ToDoContext())
            {
                var deleteDB = database.ToDo.SingleOrDefault(td => td.Id == inputId);
                database.Remove(deleteDB);
                database.SaveChanges();
            }


            Console.WriteLine("Vilket Id vill du ändra till klart?");
            inputId = Convert.ToInt32(Console.ReadLine());
            using (var db = new ToDoContext())
            {
                var done = db.ToDo.SingleOrDefault(td => td.Id == inputId);
                {
                    done.Done = true;
                    db.SaveChanges();
                }
            }


        }

        static void CreateNewToDo()
        {
            Console.WriteLine("Vad ska du göra?");
            string name = Console.ReadLine();
            Console.WriteLine("Vem är ansvarig?");
            string ansvarig = Console.ReadLine();

            var todo = new ToDo()
            {
                Name = name,
                Responsible = ansvarig
            };


            using (var database = new ToDoContext())
            {
                var todolistDB = database.ToDo;

                todolistDB.Add(todo);
                database.SaveChanges();
            }
        }
    }
}
