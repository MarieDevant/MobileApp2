using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp2.View
{
    public partial class CreateRoom : ContentPage
    {
        public CreateRoom()
        {
            InitializeComponent();
			StackLayout grid= AddHeader();
            this.Content = grid;
            grid.Children.Add(AddContent());

		}
        public StackLayout AddHeader(){

            Label title = new Label
            {
                Text = "Create a room",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 30,
                VerticalTextAlignment = TextAlignment.Start,
                HeightRequest = 70,
                TextColor = Color.Black
            };
            StackLayout head = new StackLayout
            {
                TranslationY = 70,
                Padding = new Thickness(30, 0),
                Children =
                {
                    title
                }
            };
            return head;
        }
        public StackLayout AddContent(){

            Entry name = new Entry { 
                Text = "Room Name",
                TextColor = Color.Black
            };
            Label color = new Label
            {
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 20,
				TextColor = Color.Black,
				HorizontalTextAlignment = TextAlignment.Start,
				VerticalTextAlignment = TextAlignment.Start,
				WidthRequest = 300,
                Text = "Color :"
            };
            BoxView rectColor = new BoxView { 
                Color = Color.Red,
                WidthRequest = 20,
                HeightRequest = 20,
                HorizontalOptions = LayoutOptions.Center
            };
            StackLayout col = new StackLayout
            {
				Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Start,
				Children =
				{
					color,
                    rectColor
				}
			};

			Label optionalBox = new Label
			{
                
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 20,
				TextColor = Color.Black,
				HorizontalTextAlignment = TextAlignment.Start,
				VerticalTextAlignment = TextAlignment.Center,
                Text = "Add Box (Optional)"
			};
			Entry nameBox = new Entry
			{
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 20,
				TextColor = Color.Black,
				HorizontalTextAlignment = TextAlignment.Start,
                WidthRequest = 250,
				Text = "Box Name"
			};
            Button addBox = new Button
            {
				Text = "+",
				HorizontalOptions = LayoutOptions.End,
				BackgroundColor = Color.Lavender,
				TextColor = Color.Black,
				FontSize = 20,
            };

			StackLayout addBoxLayout = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children =
				{
					nameBox,
					addBox
				}
			};

            Button addIt = new Button
            {
                Text = "Add Room",
                TranslationY = 100,
                VerticalOptions = LayoutOptions.End,
                BackgroundColor = Color.RoyalBlue,
                TextColor= Color.White
            };
            StackLayout grid = new StackLayout
            {
                Spacing = 20,
                Children = {
                    name,
                    col,
                    optionalBox,
                    addBoxLayout,
                    addIt
                }
            };
            return grid;
        }
    }
}
