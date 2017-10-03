using MobileApp2.Model;
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

            Room[] rooms = new Room[3];
            rooms[1] = r1;
            rooms[2] = r2;
            rooms[3] = r3;
            
            Load lo = new Load(me, vacance, rooms);
            
            StackLayout grid = new StackLayout {
                Children =
                {
                   
                }
            };
            for(int i = 0; i< lo.MoveOut.CountRooms; i++)
            {
                grid.Children.Add(AddRoom(rooms[i]));
            }
        }

        private static StackLayout AddRoom(Room r)
        {
            Label room = new Label {
                Text = r.Name,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TranslationY = 100,
                FontSize = 20,
                TextColor = Color.White,
                HeightRequest = 40,
                BackgroundColor = Color.RoyalBlue,
            };
            StackLayout grid = new StackLayout
            {
                Children =
                {
                    room
                }
            };

            for (int j = 0; j < r.CountBox; j++)
            {
                grid.Children.Add(AddBox(r.Boxes[j]));
            }
            return grid;
            }

        private static Label AddBox(Box b)
        {
            Label box = new Label
            {
                Text = b.Name,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TranslationY = 100,
                TranslationX = 50,
                FontSize = 20,
                TextColor = Color.Black,
                HeightRequest = 40,
                BackgroundColor = Color.Lavender,
            };
            return box;
        }
        }
    }