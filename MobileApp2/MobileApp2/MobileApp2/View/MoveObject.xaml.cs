using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp2.View
{
    public partial class MoveObject : ContentPage
    {
        public MoveObject()
        {
            InitializeComponent();
			StackLayout grid = AddHeader();
			this.Content = grid;
			grid.Children.Add(AddContent());

		}
		public StackLayout AddHeader()
		{

			Label title = new Label
			{
				Text = "Move Object",
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
			Entry name = new Entry
			{
				Text = "Box name",
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				FontSize = 20,
                WidthRequest = 200,
				TextColor = Color.Black
			};
            Entry destination = new Entry
            {
                Text = "New room name",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 20,
                WidthRequest = 200,
                TextColor = Color.Black
            };

			Button remove = new Button
			{
				Text = "Move",
				TranslationY = 50,
				VerticalOptions = LayoutOptions.End,
				BackgroundColor = Color.RoyalBlue,
				TextColor = Color.White
			};
			StackLayout content = new StackLayout
			{
				Padding = new Thickness(30, 0),
				Children =
				{
					name,
                    destination,
                    remove
				}
			};

            return content;
        }
    }
}
