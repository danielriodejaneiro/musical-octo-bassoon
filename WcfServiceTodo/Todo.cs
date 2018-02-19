using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceTodo
{
    public class Todo
    {
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Tags
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public string Executor
        {
            get;
            set;
        }

        public string DateDue
        {
            get;
            set;
        }

        public string DateDone
        {
            get;
            set;
        }
    }
}