﻿//
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
//
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointPnP.ProvisioningApp.Infrastructure.DomainModel.Graph
{
    public class UserRoles
    {
        [JsonProperty("value")]
        public List<UserRole> Roles { get; set; }
    }

    public class UserRole
    {
        [JsonProperty("@odata.type")]
        public String DataType { get; set; }
        public Guid Id { get; set; }
        public String DisplayName { get; set; }
    }
}
