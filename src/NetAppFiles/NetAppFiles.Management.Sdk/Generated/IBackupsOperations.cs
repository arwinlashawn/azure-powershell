// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// BackupsOperations operations.
    /// </summary>
    public partial interface IBackupsOperations
    {
        /// <summary>
        /// Get the status of the restore for a volume
        /// </summary>
        /// <remarks>
        /// Get the status of the restore for a volume
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<RestoreStatus>> GetVolumeRestoreStatusWithHttpMessagesAsync(string resourceGroupName, string accountName, string poolName, string volumeName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}