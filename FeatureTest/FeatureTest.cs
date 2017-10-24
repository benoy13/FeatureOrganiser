using FeatureMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FeatureTest
{
    [TestClass]
    public class FeatureTest
    {
        [TestMethod]
        public void TestCreateFeature()
        {
           Feature feature =new Feature();
           Assert.IsInstanceOfType(feature,typeof(Feature));
        }

        [TestMethod]
        public void TestFeatureName()
        {
            Feature feature = new Feature();
            Assert.IsInstanceOfType(feature, typeof(Feature));
        }
    }
}
