using MobileApp2.Interfaces;
using SQLite.Net;
using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MobileApp2.ModelView
{

    public class MyDatabase
    {
        static SQLiteConnection database;
        public MyDatabase()
        {

            database = new SQLiteConnection(DependencyService.Get<ISQLitePlatform>(),
                  DependencyService.Get<IFileHelper>().GetLocalpath("TestDatabase2.db3"));
            database.CreateTable<ToDoItem>();

        }

        public int Insert(ToDoItem toDoItem)
        {

            var item = database.Insert(toDoItem);
            database.Commit();
            return item;
        }

        public int InsertUpdate(ToDoItem toDoItem)
        {
            int num;
            if (database.Table<ToDoItem>().Any(x=> x.Id == toDoItem.Id))
            {
                num = database.Update(toDoItem);
            }
            else
            {
                num = database.Insert(toDoItem);
            }
            database.Commit();
            return num;
        }

        public int Delete(ToDoItem toDoItem)
        {
            int num;
            num = database.Delete<ToDoItem>(toDoItem.Id);
            return num;

        }

        public List<ToDoItem> GetAllItems()
        {
            return database.Table<ToDoItem>().ToList();

        }
        
        public ToDoItem GetToDoItem(int key)
        {
            return database.Table<ToDoItem>().Where(tableRow => tableRow.Id == key).FirstOrDefault();
        }
    }
}
