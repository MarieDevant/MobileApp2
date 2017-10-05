using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileApp2.View
{
    public partial class CreateItem : ContentPage
    {
        public CreateItem()
        {
            InitializeComponent();
			StackLayout grid= AddHeader();
            this.Content = grid;
            grid.Children.Add(AddContent());

		}
        public StackLayout AddHeader(){

            Label title = new Label
            {
                Text = "Create an item",
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
                Text = "Item Name",
                TextColor = Color.Black
            };
            Label optionalImage = new Label
            {
                
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                Text = "Add Image\n(Optional)",
                WidthRequest = 150
                    
            };
            BoxView fakeImage = new BoxView{
                Color = Color.Gray,
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.End
            };
			StackLayout imageLayout = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children =
				{
                    optionalImage,
                    fakeImage
				}
			};
			
			Entry nameOtherItem = new Entry
			{
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 20,
				TextColor = Color.Black,
				HorizontalTextAlignment = TextAlignment.Start,
                WidthRequest = 250,
				Text = "Add Item to Box"
			};
            Button addOtherItem = new Button
            {
				Text = "+",
				HorizontalOptions = LayoutOptions.End,
				BackgroundColor = Color.Lavender,
				TextColor = Color.Black,
				FontSize = 20,
            };

			StackLayout addOtherItemLayout = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children =
				{
					nameOtherItem,
					addOtherItem
				}
			};

            Button addIt = new Button
            {
                Text = "Add Item",
                TranslationY = 50,
                VerticalOptions = LayoutOptions.End,
                BackgroundColor = Color.RoyalBlue,
                TextColor= Color.White
            };
            StackLayout grid = new StackLayout
            {
                Spacing = 20,
                Children = {
                    name,
                    imageLayout,
                    addOtherItemLayout,
                    addIt
                }
            };
            return grid;
        }
    }
}
