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
    public partial class DisplaySearchResult : ContentPage
    {
		private List<string> source = new List<string>()
		{
			"Room 1","Room2"
		};
        public DisplaySearchResult(string ToFind)
        {
			InitializeComponent();

			Label header = new Label
			{
				Text = "Search Results for",
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 30,
				TextColor = Color.Black,
			};
			Label subTitle = new Label
			{
				Text = ToFind,
				HorizontalOptions = LayoutOptions.Center,
				FontSize = 20,
				TextColor = Color.Black,
			};

			StackLayout details = DisplayResult(ToFind);

			// add the title
			Textlayout.Children.Add(header);
			Textlayout.Children.Add(subTitle);
			Textlayout.Children.Add(details);

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
			// Navigation.PushAsync(new SearchResult());
		}



		// when the main menu button is clicked this action will play
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
				Button6.IsVisible = false;
				Button7.IsVisible = false;
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
				Button6.IsVisible = true;
				Button7.IsVisible = true;

			}
		}
        private StackLayout DisplayResult(string ToFind){
			MyDatabase db = new MyDatabase();
			List<ToDoItem> items = db.GetAllItems();
            List<ToDoItem> result = Sortage.FindObject(ToFind, items);
			StackLayout grid = new StackLayout
			{
				Margin = new Thickness(0, 10),
				TranslationY = 20,
			};
            foreach(ToDoItem obj in result){
				Label name = new Label
				{
					Text = obj.Name,
					HorizontalOptions = LayoutOptions.Center,
					FontSize = 20,
					TextColor = Color.Black,
					HorizontalTextAlignment = TextAlignment.Start,
					VerticalTextAlignment = TextAlignment.Center,
					WidthRequest = 300,
					BackgroundColor = Color.Lavender,
				};
				Label type = new Label
				{
					Text = obj.ObjectType,
					HorizontalOptions = LayoutOptions.End,
					FontSize = 20,
					TextColor = Color.Black,
					HorizontalTextAlignment = TextAlignment.Start,
					VerticalTextAlignment = TextAlignment.Center,
					BackgroundColor = Color.Lavender,
				};
				StackLayout lign = new StackLayout
				{
					Orientation = StackOrientation.Horizontal,
					HeightRequest = 40,
					VerticalOptions = LayoutOptions.Center,
					Children =
									{
										name,
										type
									}
				};
                grid.Children.Add(lign);
            }
            return grid;
		}

		private void mySearchBar_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (string.IsNullOrEmpty(e.NewTextValue.ToString()))
				myListView.ItemsSource = source; //return default
			else
			{
				string searchText = mySearchBar.Text.ToLower();
				IEnumerable<string> result = source.Where(x => x.ToLower().Contains(searchText));
				if (result.Count() > 0)
					myListView.ItemsSource = result;
				else
					myListView.ItemsSource = new List<string>() { "Not found" };
			}
		}
		private void mySearchBar_ButtonPressed(object sender, EventArgs e)
		{
			string searchText = mySearchBar.Text.ToLower();
			IEnumerable<string> result = source.Where(x => x.ToLower().Contains(searchText));
			if (result.Count() > 0)
				myListView.ItemsSource = result;
			else
				myListView.ItemsSource = new List<string>() { "Not found" };
		}
    }
}
