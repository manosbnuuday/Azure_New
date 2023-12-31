﻿// --------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License.
// --------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.IdentityProviders;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.Models;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.API.Clients.Abstractions
{
    public interface IIdentityProviderClient
    {
        Task<List<IdentityProviderResource>> GetAllAsync(ExtractorParameters extractorParameters);

        Task<IdentityProviderSecret> ListIdentityProviderSecrets(string identityProviderName, ExtractorParameters extractorParameters);
    }
}
