using AgendaYael.ModelEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace AgendaYael.Service
{
    public class DAOToDoList
    {
        Todolist _todolist;
       
            public List<Todolist> GetToDoLists()
            {


            _todolist = new Todolist();
            using (var context = new DbagendaContext())
            {
                var allTodolist = context.Todolists.ToList();
                return allTodolist;
            }




            }
      


    }


 }

