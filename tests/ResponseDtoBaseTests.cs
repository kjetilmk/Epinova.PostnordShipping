﻿using Epinova.PostnordShipping;
using Xunit;

namespace Epinova.PostnordShippingTests
{
    public class ResponseDtoBaseTests
    {
        [Fact]
        public void HasError_ErrorMessageIsNotEmpty_ReturnsTrue()
        {
            var dto = new TestableResponseDtoBase { ErrorMessage = Factory.GetString() };
            Assert.True(dto.HasError);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void HasError_ErrorMessageIsNullOrEmptyOrWhite_ReturnsFalse(string errorMessage)
        {
            var dto = new TestableResponseDtoBase { ErrorMessage = errorMessage };
            Assert.False(dto.HasError);
        }

        private class TestableResponseDtoBase : ResponseDtoBase
        {
        }
    }
}
