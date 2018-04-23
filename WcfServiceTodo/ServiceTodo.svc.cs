using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceTodo
{

    public class ServiceTodo : IServiceTodo
    {
        public bool create(Todo todo)
        {
            using (dev101Entities entity = new dev101Entities())
            {
                try
                {
                    MyTodosTable task = new MyTodosTable();
                    task.id = todo.Id;
                    task.title = todo.Title;
                    task.tags = todo.Tags;
                    task.author = todo.Author;
                    task.executor = todo.Executor;
                    task.datedue = todo.DateDue;
                    task.datedone = todo.DateDone;

                    entity.MyTodosTables.Add(task);
                    entity.SaveChanges();

                    GetOptions();

                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool delete(Todo todo)
        {
            using (dev101Entities entity = new dev101Entities())
            {
                try
                {
                    MyTodosTable task = entity.MyTodosTables.Single(pe => pe.id == todo.Id);

                    entity.MyTodosTables.Remove(task);

                    entity.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool edit(Todo todo)
        {
            using (dev101Entities entity = new dev101Entities())
            {
                try
                {
                    //int iid = Convert.ToInt32(todo.Id);

                    MyTodosTable task = entity.MyTodosTables.Single(pe => pe.id == todo.Id);
                    task.id = todo.Id;
                    task.title = todo.Title;
                    task.tags = todo.Tags;
                    task.author = todo.Author;
                    task.executor = todo.Executor;
                    task.datedue = todo.DateDue;
                    task.datedone = todo.DateDone;

                    entity.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public Todo find(string id)
        {
            using (dev101Entities entity = new dev101Entities())
            {
                int iid = Convert.ToInt32(id);
                
                return entity.MyTodosTables.Where(pe => pe.id == iid).Select(pe => new Todo
                {
                    Id = pe.id,
                    Title = pe.title,
                    Tags = pe.tags,
                    Author = pe.author,
                    Executor = pe.executor,
                    DateDue = pe.datedue,
                    DateDone = pe.datedone
                }).First();
            };
        }

        public List<Todo> findAll()
        {
            using (dev101Entities entity = new dev101Entities())
            {
                return entity.MyTodosTables.Select(pe => new Todo
                {
                    Id = pe.id,
                    Title = pe.title,
                    Tags = pe.tags,
                    Author = pe.author,
                    Executor = pe.executor,
                    DateDue = pe.datedue,
                    DateDone = pe.datedone
                }).ToList();
            };
        }

        public void GetOptions()
        {
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "*");
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Methods", "POST, GET, OPTIONS");
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
        }
    }
}
