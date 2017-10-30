using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;

namespace MobileApp2.Model
{
    public class ToDoItem
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string ObjectType { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Owner { get; set; }

        public string Picture { get; set; }


    }
}
