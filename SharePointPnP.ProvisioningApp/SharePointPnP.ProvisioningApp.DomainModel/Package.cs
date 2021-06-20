﻿//
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointPnP.ProvisioningApp.DomainModel
{
    /// <summary>
    /// The main Provisioning Package
    /// </summary>
    public class Package: BaseModel<Guid>
    {
        /// <summary>
        /// The Author of the Package
        /// </summary>
        [StringLength(200)]
        public String Author { get; set; }

        /// <summary>
        /// The URL link on GitHub to the Author of the Package
        /// </summary>
        [StringLength(1000)]
        public String AuthorLink { get; set; }

        /// <summary>
        /// The version of the Package
        /// </summary>
        [StringLength(50)]
        [Required]
        public String Version { get; set; }

        /// <summary>
        /// The DisplayName of the Package
        /// </summary>
        [StringLength(200)]
        [Required]
        public String DisplayName { get; set; }

        /// <summary>
        /// The Abstract of the Package
        /// </summary>
        [Required]
        public String Abstract { get; set; }

        /// <summary>
        /// The Description of the Package
        /// </summary>
        [Required]
        public String Description { get; set; }

        /// <summary>
        /// The URL of the Image Preview for the Package
        /// </summary>
        [StringLength(400)]
        [Required]
        public String ImagePreviewUrl { get; set; }

        /// <summary>
        /// The Categories of the Package (many to many)
        /// </summary>
        public List<Category> Categories { get; set; } = new List<Category>();

        /// <summary>
        /// The Type of the Package (SiteCollection or Tenant)
        /// </summary>
        public PackageType PackageType { get; set; }

        /// <summary>
        /// The URL of the Package in the persistence storage
        /// </summary>
        [StringLength(400)]
        [Required]
        public String PackageUrl { get; set; }

        /// <summary>
        /// Declares whether the Package is Promoted or not
        /// </summary>
        [DefaultValue(false)]
        public Boolean Promoted { get; set; }

        /// <summary>
        /// Declares whether the Package is under Preview or not
        /// </summary>
        [DefaultValue(false)]
        public bool Preview { get; set; }

        /// <summary>
        /// Keeps track of the number of times the Package was applied (popularity)
        /// </summary>
        [DefaultValue(0)]
        public Int64 TimesApplied { get; set; }

        /// <summary>
        /// Holds the metadata (id, label, description, etc.) of properties for the Package as a JSON string
        /// </summary>
        public String PropertiesMetadata { get; set; }

        /// <summary>
        /// Property to hold special instructions for the current package
        /// </summary>
        public String Instructions { get; set; }

        /// <summary>
        /// Defines the text to show when the "confirm provisioning" page is shown
        /// </summary>
        public String ProvisionRecap { get; set; }

        /// <summary>
        /// Defines the sort order of the package when shown in the list
        /// </summary>
        public Int32 SortOrder { get; set; }

        /// <summary>
        /// Defines the sort order of the package when shown in the promoted list
        /// </summary>
        public Int32 SortOrderPromoted { get; set; }

        /// <summary>
        /// Defines the relative URL of the package in the source repository
        /// </summary>
        public String RepositoryRelativeUrl { get; set; }

        /// <summary>
        /// Defines a matching base template ID for the target site, if any
        /// </summary>
        public String MatchingSiteBaseTemplateId { get; set; }

        /// <summary>
        /// Defines whether the package should be deployed on new site collections only
        /// </summary>
        public Boolean ForceNewSite { get; set; }

        /// <summary>
        /// Defines whether the package should be deployed on an already existing site collections only
        /// </summary>
        public Boolean ForceExistingSite { get; set; }

        /// <summary>
        /// Defines whether the package should be visible on the public web site or not
        /// </summary>
        public Boolean Visible { get; set; } = true;

        /// <summary>
        /// Defines the parameters of the underlying template as a JSON string
        /// </summary>
        public String PackageProperties { get; set; }

        /// <summary>
        /// Defines the ID of the Page Template to use for rendering the current package in the UI
        /// </summary>
        public String PageTemplateId { get; set; }

        /// <summary>
        /// The Target Platforms for the Package (many to many)
        /// </summary>
        public List<Platform> TargetPlatforms { get; set; } = new List<Platform>();
    }

    /// <summary>
    /// The list of available Package types
    /// </summary>
    public enum PackageType
    {
        /// <summary>
        /// The Package targets a Site Collection and requires a Site Collection Administrator user to be applied
        /// </summary>
        SiteCollection,
        /// <summary>
        /// The Package targets the whole Tenant and requires a Tenant Administrator user to be applied
        /// </summary>
        Tenant,
    }
}
