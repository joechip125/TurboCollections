using System.ComponentModel;
using NUnit.Framework;

namespace TurboCollections.Test
{
    public class TurboListTests
    {
        [Test]
        public void NewListIsEmpty()
        {
            var list = new TurboList<float>();
            Assert.Zero(list.Count);
        }

        [Test]
        public void AddingElementIncreasesCountToOne()
        {
            var list = new TurboList<float>();
            list.Add(5);
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void AddElementCanBeGet()
        {
            
        }
    }
}