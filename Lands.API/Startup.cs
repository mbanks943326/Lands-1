﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lands.API.Startup))]
namespace Lands.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
