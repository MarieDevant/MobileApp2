using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;

namespace MobileApp2.ModelView
{
    public class ToDoItem
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public bool Complete { get; set; }

    }
}
