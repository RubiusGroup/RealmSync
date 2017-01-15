﻿using System.Linq;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using RealmTst.Controllers;

[assembly: OwinStartupAttribute(typeof(RealmTst.Startup))]
namespace RealmTst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR("/signalr", new HubConfiguration()
            {
                EnableDetailedErrors = true,

            });

            WarmUpDatabase();
        }

        private void WarmUpDatabase()
        {
            var db = new SyncDbContext();
            var count = db.ChatMessages.Count();
        }
    }
}
