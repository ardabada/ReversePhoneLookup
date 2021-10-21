using System;
using System.Collections.Generic;
using System.Text;
using ReversePhoneLookup.Api.Services;
using ReversePhoneLookup.Api.UnitTests.Shared;
using Xunit;

namespace ReversePhoneLookup.Api.UnitTests.Services
{
    public class PhoneServiceTests
    {
        [Theory]
        [InlineAutoMoqData("+37360123456")]
        [InlineAutoMoqData("+37361123456")]
        [InlineAutoMoqData("+37362123456")]
        [InlineAutoMoqData("+37367123456")]
        [InlineAutoMoqData("+37368123456")]
        [InlineAutoMoqData("+37369123456")]
        [InlineAutoMoqData("+37376712345")]
        [InlineAutoMoqData("+37377412345")]
        [InlineAutoMoqData("+37377512345")]
        [InlineAutoMoqData("+37377712345")]
        [InlineAutoMoqData("+37377812345")]
        [InlineAutoMoqData("+37377912345")]
        [InlineAutoMoqData("+37378123456")]
        [InlineAutoMoqData("+37379123456")]
        public void IsPhoneNumber_ReturnsTrue_OnValidPhone(string phone, PhoneService sut)
        {
            var result = sut.IsPhoneNumber(phone);

            Assert.True(result);
        }

        [Theory]
        [InlineAutoMoqData("69123456", "+37369123456")]
        [InlineAutoMoqData("069123456", "+37369123456")]
        [InlineAutoMoqData("0069123456", "+37369123456")]
        [InlineAutoMoqData("37369123456", "+37369123456")]
        [InlineAutoMoqData("373069123456", "+37369123456")]
        [InlineAutoMoqData("+37369123456", "+37369123456")]
        [InlineAutoMoqData("+373069123456", "+37369123456")]
        public void TryFormatPhoneNumber_ShouldFormatToInternationalFormat(string source, string expected, PhoneService sut)
        {
            var result = sut.TryFormatPhoneNumber(source);

            Assert.Equal(expected, result);
        }
    }
}
