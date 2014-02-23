using Framework.Common;
using NUnit.Framework;

namespace FrameWork.Common.Tests
{

    public class EnumHelperTests
    {
        [SetUp]
        public void Setup()
        { }

        [TearDown]
        public void Teardown()
        { }

        [Test]
        public void EnumHelper_Parse_ReturnCorrectNamedConstant()
        {
            // Act
            var enumResult = EnumHelper.Parse<Days>("monday", true);

            // Assert
            Assert.AreEqual(enumResult, Days.Monday);
        }

        [Test]
        public void EnumHelper_EnumToString_ReturnsNamedConstantAsString()
        {
            // Act
            var day = EnumHelper.EnumToString<Days>(2);

            // Assert
            Assert.AreEqual(day, "Wednesday");
        }

        [Test]
        public void EnumHelper_GetEnumDescription_CorrectConstantDescription()
        {
            // Act
            var desc = EnumHelper.GetEnumDescription(Days.Monday);

            // Assert
            Assert.AreEqual("First day of week", desc);
        }

        [Test]
        public void EnumHelper_GetValues_ArrayOfNamedConstants()
        {
            //  Arrange
            var days = new Days[7] {
            Days.Monday,
            Days.Tuesday,
            Days.Wednesday,
            Days.Thursday,
            Days.Friday,
            Days.Saturday,
            Days.Sunday
        };

            // Act
            var enumDays = EnumHelper.GetValues<Days>();

            // Assert
            CollectionAssert.AreEqual(days, enumDays);
        }
    }
}
