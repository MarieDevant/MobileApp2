using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace MobileApp2.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void MenuTest()
        {
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Create a Room"));
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Create a Box"));
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Create a Item"));
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Move Box/Item"));
            app.Tap(x => x.Class("ImageButton"));
            app.Tap(x => x.Text("Remove Box/Item"));
            app.Tap(x => x.Class("ImageButton"));
            app.Tap(x => x.Text("Find Others Boxes"));
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Class("ImageButton"));
            app.Tap(x => x.Text("Create a box"));
        }

        [Test]
        public void CreateRoomInputTest()
        {
            app.ScrollDown();
            app.ScrollDown();
            app.Tap(x => x.Text("+").Index(4));
            app.Tap(x => x.Text("+").Index(3));
            app.ScrollUp();
            app.ScrollUpTo("Menu");
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Create a Room"));
            app.Tap(x => x.Text("Room Name"));
            app.ClearText(x => x.Class("EntryEditText").Text("Room Name"));
            app.EnterText(x => x.Class("EntryEditText"), "room");
            app.PressEnter();
            app.Tap(x => x.Text("Box Name"));
            app.ClearText(x => x.Class("EntryEditText").Text("Box Name"));
            app.EnterText(x => x.Class("EntryEditText").Text("Box Name"), "Box 12");
            app.PressEnter();
            app.Tap(x => x.Text("+").Index(5));
            app.Tap(x => x.Text("Garage"));
        }

        [Test]
        public void CreateItemInputTest()
        {
            app.Tap(x => x.Text("Create a Item"));
            app.Tap(x => x.Text("Item Name"));
            app.ClearText(x => x.Class("EntryEditText").Text("Item Name"));
            app.EnterText(x => x.Class("EntryEditText").Text("Item Name"), "Item 34");
            app.PressEnter();
            app.Tap(x => x.Text("Add Item to Box"));
            app.ClearText(x => x.Class("EntryEditText").Text("Add Item to Box"));
            app.EnterText(x => x.Class("EntryEditText").Text("Add Item to Box"), "Add d");
            app.PressEnter();
            app.Tap(x => x.Text("+").Index(5));
            app.Tap(x => x.Text("+").Index(4));
            app.Tap(x => x.Class("ImageButton"));
        }

        [Test]
        public void MoveandRemoveSliderandInputTest()
        {
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Move Box/Item"));
            app.Tap(x => x.Class("SwitchCompat"));
            app.Tap(x => x.Text("Box name"));
            app.ClearText(x => x.Class("EntryEditText").Text("Box name"));
            app.EnterText(x => x.Class("EntryEditText").Text("Box name"), "Box");
            app.PressEnter();
            app.Tap(x => x.Text("Destination"));
            app.ClearText(x => x.Class("EntryEditText").Text("Destination"));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "c");
            app.PressEnter();
            app.Tap(x => x.Text("Move"));
            app.Tap(x => x.Class("ImageButton"));
            app.Tap(x => x.Text("Remove Box/Item"));
            app.Tap(x => x.Class("SwitchCompat"));
            app.Tap(x => x.Text("Box name"));
            app.ClearText(x => x.Class("EntryEditText").Text("Box name"));
            app.EnterText(x => x.Class("EntryEditText"), "tttt");
            app.PressEnter();
            app.Tap(x => x.Text("Remove"));
        }



    }
}

