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
            // Initialize a fake database
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

            Load lo = new Load(me, vacance, rooms);
            string searchedString = "i";

            List<Room> foundR; List<Box> foundB; List<Item> foundI;
            Sortage.FindObject(searchedString, lo,out foundR, out foundB, out foundI);

            InitializeComponent();
            StackLayout grid = AddHeader(searchedString);
            this.Content = grid;
            grid.Children.Add(AddRoom(foundR));
            grid.Children.Add(AddBox(foundB));
            grid.Children.Add(AddItem(foundI));

            
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

        private static StackLayout AddHeader(string searchedString)
        {
            Label header = new Label
            {
                Text = "Results",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 30,
                TextColor = Color.Black,
            };
            Label subTitle = new Label
            {
                Text = "for \"" +searchedString+"\"",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.Black,
            };
            StackLayout grid = new StackLayout
            {
                TranslationY = 70,
                Padding = 40,
                Children =
                {
                    header,
                    subTitle
                }
            };
            return grid;
        }
    }
}