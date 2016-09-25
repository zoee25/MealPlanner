using MealPlanner.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MealPlannerTests
{
    [TestClass]
    public class MainPageViewModelTests
    {
        MainPageViewModel _vm;

        [TestInitialize]
        public void TestSetup()
        {
            _vm = new MainPageViewModel();
        }

        [TestCleanup]
        public void TestTearDown()
        {

        }

        [TestMethod]
        public void MainPageViewModelEmitsINotifyPropertyChangedOnValueChange()
        {
            int timesChanged = 0;
            _vm.PropertyChanged += (s, e) => timesChanged++;

            _vm.Value = "Test";

            Assert.AreEqual(timesChanged, 1);

        }
    }
}
