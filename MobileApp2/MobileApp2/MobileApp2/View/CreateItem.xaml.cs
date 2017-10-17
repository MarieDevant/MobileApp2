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

            Textlayout.Children.Add(title);
            Textlayout.Children.Add(AddContent());

		}
        public StackLayout AddHeader(){

            
            StackLayout head = new StackLayout
            {
                TranslationY = 70,
                Padding = new Thickness(30, 0),
                Children =
                {

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
        /*
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
