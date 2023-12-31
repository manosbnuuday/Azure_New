﻿// --------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License.
// --------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Extensions;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.ApiManagementService
{
    public class ApiManagementServiceResources: ITemplateResources
    {
        public List<ApiManagementServiceResource> ApiManagementServices{ get; set; } = new();

        public TemplateResource[] BuildTemplateResources()
        {
            return this.ApiManagementServices.ToArray();
        }

        public bool HasContent()
        {
            return !this.ApiManagementServices.IsNullOrEmpty();
        }
    }
}
