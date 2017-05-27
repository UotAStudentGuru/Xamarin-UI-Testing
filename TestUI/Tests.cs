using NUnit.Framework;
using System.Linq;
using Xamarin.UITest;

namespace TestUI
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
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
        public void check()
        {
            app.EnterText("EntryId","@.");
            app.Tap("ButtonID");
            var appRes = app.Query("LabelID").First(result=>result.Text=="Confirmed");
            Assert.IsTrue(appRes != null, "Not right");
        }
    }
}

