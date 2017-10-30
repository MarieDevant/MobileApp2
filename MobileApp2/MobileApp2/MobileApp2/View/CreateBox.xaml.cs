using MobileApp2.ModelView;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp2.View
{
    public partial class CreateBox : ContentPage
    {
        public CreateBox()
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
      //      Navigation.PushAsync(new SearchResult());
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
                Button12.IsVisible = false;
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
                Button12.IsVisible = true;

            }
        }

        private void Test(object sender, EventArgs e)
        {
             MyDatabase db = new MyDatabase();
            List<ToDoItem> items = db.GetAllItems();
            if (Description.Text == "" || Name.Text == "" || RoomName.Text =="")
             {
                Message.IsVisible = true;
                Message.Text = "Error Invalid Input";
                Message.TextColor = Color.Red;
                 return;
             }
            // insert data check here
            bool stop = true;
            int count = 0;
            while(stop){
                if(items[count].ObjectType.ToLower() == "room" && items[count].Name.ToLower()==RoomName.ToLower()){
                    stope = false;
                }
                if(count == items.Count)
                {
                    stop = false;
                }
                count++;
            }

            if (count == items.Count)
            {
                Message.IsVisible = true;
                Message.Text = "Error Room doesn't exist";
                Message.TextColor = Color.Red;
                return;
            }
            else
            {
                db.Insert(new ToDoItem()
                {
                    ObjectType = "Box",
                    Description = Description.Text,
                    Name = Name.Text,
                    Owner = RoomName.Text
                });
                Message.IsVisible = true;
                Message.Text = "Box Added";
                Message.TextColor = Color.Green;
            }
        }
    }
}
