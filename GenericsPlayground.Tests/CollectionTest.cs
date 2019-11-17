using GenericsPlayground.Modules;
using System;
using Xunit;

namespace GenericsPlayground.Tests
{
    public class CollectionTest
    {
        [Fact]
        public void PassParametersByValue()
        {
            //Arrange
            var collection = new Collection();
            var baseArray = collection.employees;
        }

        [Fact]
        public void PassParametersByReferences()
        {

        }
    }
}
