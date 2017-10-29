﻿﻿using MobileApp2.Model;
using MobileApp2.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TitlePage : ContentPage
    {
        private List<string> source = new List<string>()
        {
            "Room 1","Room2"
        };

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
        /*private void btnDetailBox_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailBox());
        }*/
        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchResult());
        }



        public TitlePage()
        {
            MyDatabase db = new MyDatabase();
            db.Insert(new ToDoItem()
            {
                Title = "test",
                Details = "test",
                Complete = true
            });
          List<ToDoItem> items = db.GetAllItems();
            // Initialize a fake database
            /*
            User me = new User("me", "pwd");
            MoveOut vacance = new MoveOut("vacances", me);
            Room r1 = new Room("Living Room", ConsoleColor.Red, vacance);
            Box b11 = new Box("B1LR", r1);
            Item it111 = new Item("Lamp", b11);
            Item it112 = new Item("Pillow", b11);
            Box b12 = new Box("B2LR", r1);
            Item it121 = new Item("Blap", b12);
            Room r2 = new Room("Kitchen", ConsoleColor.Green, vacance);
            Box b21 = new Box("B1K", r2);
            Item it211 = new Item("Plates", b21);
            Item it212 = new Item("Forks x24", b21);
            Box b22 = new Box("B2K", r2);
            Item it221 = new Item("Glasses", b22);
            Room r3 = new Room("Garage", ConsoleColor.Blue, vacance);
            Box b31 = new Box("B1G", r3);
            Item it311 = new Item("Bike", b31);


            List<Room> rooms = new List<Room>();
            rooms.Add( r1);
            rooms.Add(r2);
            rooms.Add(r3);

            */
            // Load lo = new Load(me, vacance, rooms);

            InitializeComponent();

            Label header = new Label
            {
                Text = items[0].Title,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 30,
                TextColor = Color.Black,
            };
            Label subTitle = new Label
            {
                Text = "Rooms",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.Black,
            };

            // add the title
            Textlayout.Children.Add(header);
            Textlayout.Children.Add(subTitle);

            // StackLayout grid = AddHeader();
            // this.Content = grid;
            //for (int i = 0; i < App.lo.MoveOut.Rooms.Count; i++){
            //   Textlayout.Children.Add(AddRoom(App.lo.MoveOut.Rooms[i]));
            //}


        }

        // when the main menu button is clicked this action will play
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
            } else
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


        private StackLayout AddRoom(Room r)
        {
            Label room = new Label
            {
                Text = r.Name,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.White,
                HorizontalTextAlignment= TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 40,
                WidthRequest = 400,
                BackgroundColor = Color.RoyalBlue,
            };
            StackLayout grid = new StackLayout
            {
                Margin=new Thickness(0,10),
                TranslationY = 20,
                Children =
                {
                    room
                }
            };

            for (int j = 0; j < r.Boxes.Count; j++)
            {
                grid.Children.Add(AddBox(r.Boxes[j]));
            }
            return grid;
        }

        private StackLayout AddBox(Box b)
        {

            Label box = new Label
            {
                Text = b.Name,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Start,
				VerticalTextAlignment = TextAlignment.Center,
                WidthRequest = 300,
                BackgroundColor = Color.Lavender,
            };
            Button plus = new Button
            {
                Text = "+",
                HorizontalOptions = LayoutOptions.End,
                BackgroundColor = Color.Lavender,
                TextColor = Color.Black,
                FontSize = 20,
                CommandParameter= b,
            };

            plus.Clicked += onPlusButtonClicked;

			

			StackLayout lign = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                TranslationX=20,
                HeightRequest =40,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    box,
                    plus
                }
            };
            return lign;
        }
		private void onPlusButtonClicked(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			Box boxF = (Box)btn.CommandParameter;
			Navigation.PushAsync(new DetailBox(boxF));
		}

        private void mySearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue.ToString()))
                myListView.ItemsSource = source; //return default
            else
            {
                string searchText = mySearchBar.Text.ToLower();
                IEnumerable<string> result = source.Where(x => x.ToLower().Contains(searchText));
                if (result.Count() > 0)
                    myListView.ItemsSource = result;
                else
                    myListView.ItemsSource = new List<string>() { "Not found" };
            }
        }
        private void mySearchBar_ButtonPressed(object sender, EventArgs e)
        {
            string searchText = mySearchBar.Text.ToLower();
            IEnumerable<string> result = source.Where(x => x.ToLower().Contains(searchText));
            if (result.Count() > 0)
                myListView.ItemsSource = result;
            else
                myListView.ItemsSource = new List<string>() { "Not found" };
        }
    }
}

