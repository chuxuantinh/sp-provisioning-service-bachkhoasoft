﻿//
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
//
using SharePointPnP.ProvisioningApp.Infrastructure.DomainModel.Provisioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SharePointPnP.ProvisioningApp.WebApp.Models
{
    /// <summary>
    /// Defines a dynamic template parameter
    /// </summary>
    public class TemplateParameterModel
    {
        /// <summary>
        /// The Index of the current parameter
        /// </summary>
        public Int32 Index { get; set; }

        /// <summary>
        /// The Key of the parameter
        /// </summary>
        public String ParameterKey { get; set; }

        /// <summary>
        /// The Value of the parameter
        /// </summary>
        public String ParameterValue { get; set; }

        /// <summary>
        /// The Metadata Property for the parameter
        /// </summary>
        public MetadataProperty MetadataProperty { get; set; }

        /// <summary>
        /// Optionally provides the URL of the SPO Root Site
        /// </summary>
        public String SPORootSiteUrl { get; set; }

        /// <summary>
        /// Optionally provides the Correlation ID for the current provisioning action
        /// </summary>
        public String CorrelationId { get; set; }
    }
}