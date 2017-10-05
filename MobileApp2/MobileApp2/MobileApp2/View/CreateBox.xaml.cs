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
			StackLayout grid= AddHeader();
            this.Content = grid;
            grid.Children.Add(AddContent());

		}
        public StackLayout AddHeader(){

            Label title = new Label
            {
                Text = "Create a box",
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
                Text = "Box Name",
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
			Label qrcodeTitle = new Label{
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 20,
                WidthRequest = 150,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center,
                Text = "QR Code"
            };
            BoxView fakeQRCode = new BoxView{
                Color = Color.Gray,
                WidthRequest = 50,
                HeightRequest = 50,
                HorizontalOptions = LayoutOptions.End
            };

            StackLayout qrcodeLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    qrcodeTitle,
                    fakeQRCode
                }
            };

			Entry nameItem = new Entry
			{
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 20,
				TextColor = Color.Black,
				HorizontalTextAlignment = TextAlignment.Start,
                WidthRequest = 250,
				Text = "Box Name"
			};
            Button addItem = new Button
            {
				Text = "+",
				HorizontalOptions = LayoutOptions.End,
				BackgroundColor = Color.Lavender,
				TextColor = Color.Black,
				FontSize = 20,
            };

			StackLayout addItemLayout = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children =
				{
					nameItem,
					addItem
				}
			};

            Button addIt = new Button
            {
                Text = "Add Box",
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
                    qrcodeLayout,
                    addItemLayout,
                    addIt
                }
            };
            return grid;
        }
    }
}
