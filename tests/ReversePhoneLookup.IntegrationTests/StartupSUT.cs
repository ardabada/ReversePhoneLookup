using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using ReversePhoneLookup.Web;

namespace ReversePhoneLookup.IntegrationTests
{
    public class StartupSUT : Startup
    {
        public StartupSUT(IConfiguration configuration) : base(configuration) { }
    }
}
