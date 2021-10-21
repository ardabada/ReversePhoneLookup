using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ReversePhoneLookup.Models;
using ReversePhoneLookup.Models.Exceptions;
using Xunit;

namespace ReversePhoneLookup.Api.UnitTests.Shared
{
    public static class AssertExtensions
    {
        public static void ThrowsWithCode(Action action, StatusCode statusCode)
        {
            var ex = Assert.Throws<ApiException>(action);

            Assert.Equal(statusCode, ex.Code);
        }

        public static async Task ThrowsWithCodeAsync(Func<Task> action, StatusCode statusCode)
        {
            var ex = await Assert.ThrowsAsync<ApiException>(action);

            Assert.Equal(statusCode, ex.Code);
        }
    }
}
