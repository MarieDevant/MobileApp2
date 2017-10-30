using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace MobileApp2.UITest1
{
    [TestFixture(Platform.Android)]
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
        public void AddRoom()
        {
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Create a Room"));
            app.SwipeRightToLeft();
            app.SwipeRightToLeft();
            app.Tap(x => x.Class("EntryEditText").Index(4));
            app.EnterText(x => x.Class("EntryEditText").Index(4), "room 2");
            app.PressEnter();
            app.Tap(x => x.Text("Add Room"));
        }

        [Test]
        public void MenuNavigation()
        {
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Create a Room"));
            app.Tap(x => x.Class("ListView"));
            app.SwipeRightToLeft();
            app.Tap(x => x.Class("ListView"));
            app.SwipeLeftToRight();
            app.SwipeLeftToRight();
            app.SwipeLeftToRight();
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Move Box/Item"));
            app.Tap(x => x.Class("SwitchCompat"));
            app.Tap(x => x.Class("SwitchCompat"));
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Remove Box/Item"));
            app.Tap(x => x.Class("SwitchCompat").Index(1));
            app.Tap(x => x.Class("SwitchCompat").Index(1));
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Class("AppCompatButton"));
        }

        [Test]
        public void TestValidRoom()
        {
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Create a Room"));
            app.SwipeRightToLeft();
            app.Tap(x => x.Class("ListView"));
            app.Tap(x => x.Class("ListView"));
            app.Tap(x => x.Class("EntryEditText").Index(4));
            app.EnterText(x => x.Class("EntryEditText").Index(4), "roomk");
            app.PressEnter();
            app.Tap(x => x.Text("Add Room"));
            app.SwipeLeftToRight();
            app.SwipeLeftToRight();
            app.Tap(x => x.Class("EntryEditText").Index(4));
            app.EnterText(x => x.Class("EntryEditText").Index(4), "boxx");
            app.PressEnter();
            app.Tap(x => x.Class("EntryEditText").Index(5));
            app.EnterText(x => x.Class("EntryEditText").Index(5), "etc");
            app.PressEnter();
            app.ScrollDown();
            app.Tap(x => x.Class("EntryEditText").Index(6));
            app.EnterText(x => x.Class("EntryEditText").Index(6), "roomk");
            app.PressEnter();
            app.Tap(x => x.Text("Add Box"));
        }

        [Test]
        public void AddingRoomBox()
        {
            app.Tap(x => x.Text("Menu"));
            app.Tap(x => x.Text("Create a Room"));
            app.SwipeRightToLeft();
            app.SwipeRightToLeft();
            app.SwipeRightToLeft();
            app.Tap(x => x.Class("EntryEditText").Index(4));
            app.EnterText(x => x.Class("EntryEditText").Index(4), "room one");
            app.PressEnter();
            app.ScrollDownTo("Add Room");
            app.Tap(x => x.Text("Add Room"));
            app.SwipeLeftToRight();
            app.SwipeLeftToRight();
            app.Tap(x => x.Class("EntryEditText").Index(4));
            app.EnterText(x => x.Class("EntryEditText").Index(4), "box n");
            app.PressEnter();
            app.ScrollDownTo("Add Box");
            app.Tap(x => x.Text("Add Box"));
            app.Tap(x => x.Class("EntryEditText").Index(6));
            app.EnterText(x => x.Class("EntryEditText").Index(6), "room one");
            app.PressEnter();
            app.Tap(x => x.Text("Add Box"));
            app.Tap(x => x.Text("Add an Item (Optional)"));
            app.Tap(x => x.Class("ListView"));
            app.ScrollUp();
            app.Tap(x => x.Class("EntryEditText").Index(5));
            app.EnterText(x => x.Class("EntryEditText").Index(5), "ant");
            app.PressEnter();
            app.ScrollDownTo("room one");
            app.ScrollDownTo("Add Box");
            app.Tap(x => x.Text("Add Box"));
            app.Tap(x => x.Text("room one"));
            app.ClearText(x => x.Class("EntryEditText").Text("room one"));
            app.EnterText(x => x.Class("EntryEditText").Text("room one"), "room1");
            app.PressEnter();
            app.Tap(x => x.Text("Add Box"));
        }



    }
}

