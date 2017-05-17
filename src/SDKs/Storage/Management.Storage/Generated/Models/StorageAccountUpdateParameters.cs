// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Azure;
    using Management;
    using Storage;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters that can be provided when updating the storage account
    /// properties.
    /// </summary>
    [JsonTransformation]
    public partial class StorageAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountUpdateParameters
        /// class.
        /// </summary>
        public StorageAccountUpdateParameters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountUpdateParameters
        /// class.
        /// </summary>
        /// <param name="sku">Gets or sets the SKU name. Note that the SKU name
        /// cannot be updated to Standard_ZRS or Premium_LRS, nor can accounts
        /// of those sku names be updated to any other value.</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used in viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key no
        /// greater in length than 128 characters and a value no greater in
        /// length than 256 characters.</param>
        /// <param name="customDomain">Custom domain assigned to the storage
        /// account by the user. Name is the CNAME source. Only one custom
        /// domain is supported per storage account at this time. To clear the
        /// existing custom domain, use an empty string for the custom domain
        /// name property.</param>
        /// <param name="encryption">Provides the encryption settings on the
        /// account. The default setting is unencrypted.</param>
        /// <param name="accessTier">Required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'</param>
        /// <param name="enableHttpsTrafficOnly">Allows https traffic only to
        /// storage service if sets to true.</param>
        public StorageAccountUpdateParameters(Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>), CustomDomain customDomain = default(CustomDomain), Encryption encryption = default(Encryption), AccessTier? accessTier = default(AccessTier?), bool? enableHttpsTrafficOnly = default(bool?))
        {
            Sku = sku;
            Tags = tags;
            CustomDomain = customDomain;
            Encryption = encryption;
            AccessTier = accessTier;
            EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
        }

        /// <summary>
        /// Gets or sets the SKU name. Note that the SKU name cannot be updated
        /// to Standard_ZRS or Premium_LRS, nor can accounts of those sku names
        /// be updated to any other value.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used in viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key no greater in length than 128
        /// characters and a value no greater in length than 256 characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets custom domain assigned to the storage account by the
        /// user. Name is the CNAME source. Only one custom domain is supported
        /// per storage account at this time. To clear the existing custom
        /// domain, use an empty string for the custom domain name property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; set; }

        /// <summary>
        /// Gets or sets provides the encryption settings on the account. The
        /// default setting is unencrypted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTier")]
        public AccessTier? AccessTier { get; set; }

        /// <summary>
        /// Gets or sets allows https traffic only to storage service if sets
        /// to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsHttpsTrafficOnly")]
        public bool? EnableHttpsTrafficOnly { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (CustomDomain != null)
            {
                CustomDomain.Validate();
            }
        }
    }
}
