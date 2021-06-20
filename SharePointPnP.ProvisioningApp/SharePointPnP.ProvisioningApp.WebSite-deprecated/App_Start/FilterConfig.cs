﻿//
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
//
using System.Web;
using System.Web.Mvc;

namespace SharePointPnP.ProvisioningApp.WebSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
