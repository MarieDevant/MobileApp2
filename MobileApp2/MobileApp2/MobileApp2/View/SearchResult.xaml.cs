﻿using MobileApp2.Model;
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
    public partial class SearchResult : ContentPage
    {
        public SearchResult()
        {
            //// Initialize a fake database
            //User me = new User("me", "pwd");
            //MoveOut vacance = new MoveOut("vacances", me);
            //Room r1 = new Room("Living Room", ConsoleColor.Red, vacance);
            //Box b11 = new Box("B1LR", r1);
            //Item it111 = new Item("Lamp", b11);
            //Item it112 = new Item("Pillow", b11);
            //Box b12 = new Box("B2LR", r1);
            //Item it121 = new Item("Blap", b12);
            //Room r2 = new Room("Kitchen", ConsoleColor.Green, vacance);
            //Box b21 = new Box("B1K", r2);
            //Item it211 = new Item("Plates", b21);
            //Item it212 = new Item("Forks x24", b21);
            //Box b22 = new Box("B2K", r2);
            //Item it221 = new Item("Glasses", b22);
            //Room r3 = new Room("Garage", ConsoleColor.Blue, vacance);
            //Box b31 = new Box("B1G", r3);
            //Item it311 = new Item("Bike", b31);


            //List<Room> rooms = new List<Room>();
            //rooms.Add( r1);
            //rooms.Add(r2);
            //rooms.Add(r3);

            //Load lo = new Load(me, vacance, rooms);
            Load lo = ModelView.LoadJson.LoadTheJson();
            string searchedString = "i";

            List<Room> foundR; List<Box> foundB; List<Item> foundI;
            Sortage.FindObject(searchedString, lo,out foundR, out foundB, out foundI);

            InitializeComponent();

            Label header = new Label
            {
                Text = "Results",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 30,
                TextColor = Color.Black,
            };
            Label subTitle = new Label
            {
                Text = "for \"" + searchedString + "\"",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.Black,
            };
            Textlayout.Children.Add(header);
            Textlayout.Children.Add(subTitle);
            Textlayout.Children.Add(AddRoom(foundR));
            Textlayout.Children.Add(AddBox(foundB));
            Textlayout.Children.Add(AddItem(foundI));

            
            /*Load lo = new Load(me, vacance, rooms);

            InitializeComponent();
            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            this.Content = layout;
            int x = 0;
            while (x != 3)

            {
                var label = new Label { Text = "This is a label.", TextColor = Color.FromHex("#77d065"), FontSize = 20 };
                layout.Children.Add(label);
                x++;
            }*/


        }

        private static StackLayout AddRoom(List<Room> r)
        {
            Label title = new Label
            {
                Text = "Rooms",
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
                    title
                }
            };

            for (int j = 0; j < r.Count; j++)
            {
                Label room = new Label{
                    Text = r[j].Name,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment= TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 40,
                WidthRequest = 400,
            };
                grid.Children.Add(room);
            }
            return grid;
        }

        private static StackLayout AddBox(List<Box> b)
        {

            Label title = new Label
            {
                Text = "Boxes",
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
                    title
                }
            };

            for (int j = 0; j < b.Count; j++)
            {
                Label box = new Label{
                    Text = b[j].Name,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment= TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 40,
                WidthRequest = 400,
            };
                grid.Children.Add(box);
            }
            return grid;
        }

        private static StackLayout AddItem(List<Item> i)
        {

            Label title = new Label
            {
                Text = "Items",
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
                    title
                }
            };

            for (int j = 0; j < i.Count; j++)
            {
                Label box = new Label{
                    Text = i[j].Name,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment= TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 40,
                WidthRequest = 400,
            };
                grid.Children.Add(box);
            }
            return grid;
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
        }/*
        private void btnDetailBox_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailBox());
        }*/
        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchResult());
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
                Button5.IsVisible = false;
                Button6.IsVisible = false;
                Button7.IsVisible = false;
                Button8.IsVisible = false;
                Button9.IsVisible = false;
                Button10.IsVisible = false;
                Button11.IsVisible = false;
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
                Button5.IsVisible = true;
                Button6.IsVisible = true;
                Button7.IsVisible = true;
                Button8.IsVisible = true;
                Button9.IsVisible = true;
                Button10.IsVisible = true;
                Button11.IsVisible = true;
                Button12.IsVisible = true;

            }
        }
    }
}