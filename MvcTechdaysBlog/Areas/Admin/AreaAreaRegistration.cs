﻿using System.Web.Mvc;

namespace MvcTechdaysBlog.Areas.Admin
{
    public class AreaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {controller="Article", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
