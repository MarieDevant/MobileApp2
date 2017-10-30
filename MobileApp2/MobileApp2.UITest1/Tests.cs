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
    }
}

