using MobileApp2.Model;
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
	public partial class DetailBox : ContentPage
	{
        private ToDoItem b;
		public DetailBox (ToDoItem box)
		{
            b = box;
        	InitializeComponent ();
            Label title = new Label
            {
                Text = b.Name,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 30,
                VerticalTextAlignment = TextAlignment.Start,
                HeightRequest = 70,
                TextColor = Color.Black
            };
            Textlayout.Children.Add(title);

		}
        private StackLayout AddHeader()
        {
          
            Image im = new Image
            {
                Source = b.Picture,
                WidthRequest = 500,

            };

            Label titleDesc = new Label
            {
                Text = "Description : ",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
                FontSize = 15,
                WidthRequest = 100,
                TextColor = Color.Black
            };
			Label contentDesc = new Label
			{
                Text = b.Description,
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Start,
                HorizontalTextAlignment = TextAlignment.Start,
				FontSize = 15,
				TextColor = Color.Black
			};

			StackLayout desc = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				Children =
				{
                    titleDesc,
					contentDesc
				}
			};

            Label content = new Label
            {
                Text = "Content :",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 15,
                TextColor = Color.Black
            };
            StackLayout items = new StackLayout { };
            for (int i = 0; i < b.Items.Count;i++){
                items.Children.Add(AddItem(b.Items[i]));
            }
            StackLayout grid = new StackLayout
            {
                TranslationY = 70,
                Spacing = 10,
                Padding = new Thickness(30,0),
                Children =
                {
                    //im,
                    desc,
                    content,
                    items
                }
            };
            return grid;
        }
		private static StackLayout AddItem(Item i)
		{

			Label item = new Label
			{
				Text = i.Name,
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 15,
				TextColor = Color.Black,
				HorizontalTextAlignment = TextAlignment.Start,
				VerticalTextAlignment = TextAlignment.Center,
				WidthRequest = 250,
				BackgroundColor = Color.Lavender,
			};
			Label image = new Label
			{
				Text = "Picture",
				HorizontalOptions = LayoutOptions.End,
				BackgroundColor = Color.Lavender,
				HorizontalTextAlignment = TextAlignment.Start,
				VerticalTextAlignment = TextAlignment.Center,
				TextColor = Color.Black,
				FontSize = 15,

			};
			StackLayout lign = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				TranslationX = 20,
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					item,
					image
				}
			};
			return lign;
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
        /*private void btnDetailBox_Clicked(object sender, EventArgs e)
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