﻿﻿using MobileApp2.Model;
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
        private bool MainMenuOn = false;
        public TitlePage()
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
            InitializeComponent();

            Label header = new Label
            {
                Text = "Create your Move",
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
            for (int i = 0; i < lo.MoveOut.Rooms.Count; i++){
                Textlayout.Children.Add(AddRoom(rooms[i]));
            }

            

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
                Button5.IsVisible = false;
                Button6.IsVisible = false;
                Button7.IsVisible = false;
                Button8.IsVisible = false;
                Button9.IsVisible = false;
                Button10.IsVisible = false;
                Button11.IsVisible = false;
                Button12.IsVisible = false;
            } else
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


        private static StackLayout AddRoom(Room r)
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

        private static StackLayout AddBox(Box b)
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
                BackgroundColor =Color.Lavender,
                TextColor = Color.Black,
                FontSize = 20,

            };
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

    }
}