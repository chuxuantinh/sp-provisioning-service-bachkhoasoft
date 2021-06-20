﻿//
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointPnP.ProvisioningApp.Synchronization
{
    public interface ITemplatesProvider
    {
        Task<IEnumerable<ITemplateItem>> GetAsync(string path, Action<string> log);

        Task CloneAsync(ITemplatesProvider sourceProvider, Action<string> log, string exclusionRules = null);
    }
}
