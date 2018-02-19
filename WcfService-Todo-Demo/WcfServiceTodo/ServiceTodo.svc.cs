using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTodo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTodo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTodo.svc or ServiceTodo.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTodo : IServiceTodo
    {
        public bool create(Todo todo)
        {
            using (dev101Entities entity = new dev101Entities())
            {
                try
                {
                    TaskEntity task = new TaskEntity();
                    task.id = todo.Id;
                    task.title = todo.Title;
                    task.tags = todo.Tags;
                    task.author = todo.Author;
                    task.executor = todo.Executor;
                    task.datedue = todo.DateDue;
                    task.datedone = todo.DateDone;

                    entity.TaskEntities.Add(task);
                    entity.SaveChanges();
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
                    TaskEntity task = entity.TaskEntities.Single(pe => pe.id == todo.Id);

                    entity.TaskEntities.Remove(task);

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
                    TaskEntity task = entity.TaskEntities.Single(pe => pe.id == todo.Id);
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

        public Todo find(int id)
        {
            using (dev101Entities entity = new dev101Entities())
            {
                return entity.TaskEntities.Where(pe => pe.id == id).Select(pe => new Todo
                {
                    Id = pe.id,
                    Title = pe.title,
                    Tags = pe.tags,
                    Author = pe.author,
                    Executor = pe.executor,
                    DateDue = (DateTime)pe.datedue,
                    DateDone = (DateTime)pe.datedone
                }).First();
            };
        }

        public List<Todo> findAll()
        {
            using (dev101Entities entity = new dev101Entities())
            {
                return entity.TaskEntities.Select(pe => new Todo
                {
                    Id = pe.id,
                    Title = pe.title,
                    Tags = pe.tags,
                    Author = pe.author,
                    Executor = pe.executor,
                    DateDue = (DateTime) pe.datedue,
                    DateDone = (DateTime) pe.datedone
                }).ToList();
            };
        }
    }
}
