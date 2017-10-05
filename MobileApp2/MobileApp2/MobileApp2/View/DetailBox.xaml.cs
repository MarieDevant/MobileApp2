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
	public partial class DetailBox : ContentPage
	{
        private Box b;
		public DetailBox ()
		{
			//Fake database
			User me = new User("me", "pwd");
			MoveOut vacance = new MoveOut("vacances", me);
			Room r1 = new Room("Living Room", ConsoleColor.Red, vacance);
			Box b11 = new Box("B1LR", r1);
			Item it111 = new Item("Lamp", b11);
			Item it112 = new Item("Pillow", b11);

            b = b11;
			InitializeComponent ();
            this.Content = AddHeader();

		}
        public StackLayout AddHeader()
        {
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
            /*Image im = new Image
            {
                Source = b.Image,
                WidthRequest = 500,

            };*/

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
            for (int i = 0; i < b.CountItems;i++){
                items.Children.Add(AddItem(b.Items[i]));
            }
            StackLayout grid = new StackLayout
            {
                TranslationY = 70,
                Spacing = 10,
                Padding = new Thickness(30,0),
                Children =
                {
                    title,
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

	}
}