// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace FreeCourse.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
              
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("catalog_fullpermission","Catalog API için full erişim"),
                new ApiScope("photo_stock_fullpermission","Photo Stock API için full erişim"),
                new ApiScope(,"Photo Stock API için full erişim"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
               
            };
    }
}