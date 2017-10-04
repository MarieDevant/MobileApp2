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
			InitializeComponent ();
            AddHeader();
		}
        public StackLayout AddHeader()
        {
            Label title = new Label
            {
                Text = b.Name,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TranslationY = 70,
                FontSize = 30,
                TextColor = Color.Black
            };
            Image im = new Image
            {
                Source = b.Image,
                WidthRequest = 500,

            };
            Label desc = new Label
            {
                Text = "Description" + b.Description,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 15,
                TextColor = Color.Black
            };
            Label content = new Label
            {
                Text = "Content",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 15,
                TextColor = Color.Black
            };
            StackLayout grid = new StackLayout
            {
                Children =
                {
                    title,
                    im,
                    desc,
                    content
                }
            };
            return grid;
        }

	}
}