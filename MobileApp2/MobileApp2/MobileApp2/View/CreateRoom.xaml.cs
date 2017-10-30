using MobileApp2.ModelView;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp2.View
{
    public partial class CreateRoom : CarouselPage
    {
        public CreateRoom()
        {
            InitializeComponent();

        }


        private bool MainMenuOn = false;
        private void btnAddRoom_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateRoom());
        }
        private void btnCreateBox_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateBox());
        }
        private void btnCreateItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateItem());
        }
        private void btnMoveItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MoveObject());
        }
        private void btnRemoveItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RemoveObject());
        }
        private void btnTitlePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TitlePage());
        }
        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            // Navigation.PushAsync(new SearchResult());
        }
        private void btnHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TitlePage());
        }

        private void MenuClicked(object sender, EventArgs e)
        {
            // check if the menu is on
            if (MainMenuOn)
            {
                MainMenuOn = false;
                Border.IsVisible = false;
                Button0.IsVisible = false;
                Button1.IsVisible = false;
                Button2.IsVisible = false;
                Button3.IsVisible = false;
                Button4.IsVisible = false;
                Button6.IsVisible = false;
                Button7.IsVisible = false;
            }
            else
            {
                MainMenuOn = true;
                Border.IsVisible = true;
                Button0.IsVisible = true;
                Button1.IsVisible = true;
                Button2.IsVisible = true;
                Button3.IsVisible = true;
                Button4.IsVisible = true;
                Button6.IsVisible = true;
                Button7.IsVisible = true;

            }
        }

        private void AddRoomButton(object sender, EventArgs e)
        {
            MyDatabase db = new MyDatabase();
            if (Name.Text == "")
            {
                Message.IsVisible = true;
                Message.Text = "Error Invalid Input";
                Message.TextColor = Color.Red;
                return;
            }
            // insert data check here
            db.Insert(new ToDoItem()
            {
                ObjectType = "Room",
                Name = Name.Text,
                Owner = "none"
            });
            Message.IsVisible = true;
            Message.Text = "Room Added";
            Message.TextColor = Color.Green;
        }

        private void AddBoxButton(object sender, EventArgs e)
        {
            MyDatabase db = new MyDatabase();
            List<ToDoItem> items = db.GetAllItems();

            foreach(ToDoItem item in items)
            {
                if (item.ObjectType == "Box")
                {
                    if (item.Name == BoxName.Text)
                    {
                        BoxAdded.IsVisible = true;
                        db.InsertUpdate(new ToDoItem
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Description = item.Description,
                            ObjectType = item.ObjectType,
                            Owner = Name.Text,                           
                        });
                        BoxAdded.Text = "Box added";
                        return;
                    }
                }
            }
            BoxAdded.IsVisible = true;
            BoxAdded.Text = "No Box Found";
        }
    }
}
