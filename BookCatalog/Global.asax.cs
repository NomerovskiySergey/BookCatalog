﻿using System.Web.Mvc;
using System.Web.Routing;
using BookCatalog.Initializer.MapperInitializer;

namespace BookCatalog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ModelMapper.Init();
        }
    }
}
