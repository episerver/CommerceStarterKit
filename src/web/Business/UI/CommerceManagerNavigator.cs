﻿/*
Commerce Starter Kit for EPiServer

All rights reserved. See LICENSE.txt in project root.

Copyright (C) 2013-2015 Oxx AS
Copyright (C) 2013-2015 BV Network AS

*/
using System.Collections.Generic;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.PageExtensions;

namespace OxxCommerceStarterKit.Web.Business.UI
{
    [ServiceConfiguration(ServiceType = typeof(IQuickNavigatorItemProvider))]
    public class CommerceManagerQuickNavigator : IQuickNavigatorItemProvider
    {
        private int _sortOrder = 50;

        public IDictionary<string, QuickNavigatorMenuItem> GetMenuItems(ContentReference currentContent)
        {
            string commerceManagerLink = System.Configuration.ConfigurationManager.AppSettings["CommerceManagerLink"];
            if (commerceManagerLink == null)
                return null;

            var menuItems = new Dictionary<string, QuickNavigatorMenuItem>();
            menuItems.Add("qn-commerce-manager", new QuickNavigatorMenuItem("Commerce Manager", commerceManagerLink, null, null, null));
            return menuItems;
        }

        public int SortOrder
        {
            get { return _sortOrder; }
            private set { _sortOrder = value; }
        }
    }
}