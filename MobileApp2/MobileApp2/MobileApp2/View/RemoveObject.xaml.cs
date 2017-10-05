using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp2.View
{
    public partial class RemoveObject : ContentPage
    {
        public RemoveObject()
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
				Text = "Remove Object",
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
				Text = "Item name",
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,
				FontSize = 20,
                WidthRequest = 200,
				TextColor = Color.Black
			};
			Button remove = new Button
			{
				Text = "Remove",
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
                    remove
				}
			};

            return content;
        }
    }
}
