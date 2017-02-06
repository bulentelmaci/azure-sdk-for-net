// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for PolicyAssignmentsOperations.
    /// </summary>
    public static partial class PolicyAssignmentsOperationsExtensions
    {
            /// <summary>
            /// Delete policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            public static PolicyAssignment Delete(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).DeleteAsync(scope, policyAssignmentName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PolicyAssignment> DeleteAsync(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(scope, policyAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='parameters'>
            /// Policy assignment.
            /// </param>
            public static PolicyAssignment Create(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, PolicyAssignment parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).CreateAsync(scope, policyAssignmentName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='parameters'>
            /// Policy assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PolicyAssignment> CreateAsync(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, PolicyAssignment parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(scope, policyAssignmentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get single policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            public static PolicyAssignment Get(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).GetAsync(scope, policyAssignmentName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get single policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the policy assignment.
            /// </param>
            /// <param name='policyAssignmentName'>
            /// Policy assignment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PolicyAssignment> GetAsync(this IPolicyAssignmentsOperations operations, string scope, string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, policyAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PolicyAssignment> ListForResourceGroup(this IPolicyAssignmentsOperations operations, string resourceGroupName, string filter = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForResourceGroupAsync(resourceGroupName, filter), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PolicyAssignment>> ListForResourceGroupAsync(this IPolicyAssignmentsOperations operations, string resourceGroupName, string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupWithHttpMessagesAsync(resourceGroupName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The resource provider namespace.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource path.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type.
            /// </param>
            /// <param name='resourceName'>
            /// The resource name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PolicyAssignment> ListForResource(this IPolicyAssignmentsOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, Microsoft.Rest.Azure.OData.ODataQuery<PolicyAssignment> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<PolicyAssignment>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForResourceAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The resource provider namespace.
            /// </param>
            /// <param name='parentResourcePath'>
            /// The parent resource path.
            /// </param>
            /// <param name='resourceType'>
            /// The resource type.
            /// </param>
            /// <param name='resourceName'>
            /// The resource name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PolicyAssignment>> ListForResourceAsync(this IPolicyAssignmentsOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, Microsoft.Rest.Azure.OData.ODataQuery<PolicyAssignment> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<PolicyAssignment>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListForResourceWithHttpMessagesAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the policy assignments of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PolicyAssignment> List(this IPolicyAssignmentsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<PolicyAssignment> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<PolicyAssignment>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListAsync(odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the policy assignments of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PolicyAssignment>> ListAsync(this IPolicyAssignmentsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<PolicyAssignment> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<PolicyAssignment>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            public static PolicyAssignment DeleteById(this IPolicyAssignmentsOperations operations, string policyAssignmentId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).DeleteByIdAsync(policyAssignmentId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PolicyAssignment> DeleteByIdAsync(this IPolicyAssignmentsOperations operations, string policyAssignmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteByIdWithHttpMessagesAsync(policyAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create policy assignment by Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            /// <param name='parameters'>
            /// Policy assignment.
            /// </param>
            public static PolicyAssignment CreateById(this IPolicyAssignmentsOperations operations, string policyAssignmentId, PolicyAssignment parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).CreateByIdAsync(policyAssignmentId, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create policy assignment by Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            /// <param name='parameters'>
            /// Policy assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PolicyAssignment> CreateByIdAsync(this IPolicyAssignmentsOperations operations, string policyAssignmentId, PolicyAssignment parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateByIdWithHttpMessagesAsync(policyAssignmentId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get single policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            public static PolicyAssignment GetById(this IPolicyAssignmentsOperations operations, string policyAssignmentId)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).GetByIdAsync(policyAssignmentId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get single policy assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyAssignmentId'>
            /// Policy assignment Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PolicyAssignment> GetByIdAsync(this IPolicyAssignmentsOperations operations, string policyAssignmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(policyAssignmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PolicyAssignment> ListForResourceGroupNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForResourceGroupNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PolicyAssignment>> ListForResourceGroupNextAsync(this IPolicyAssignmentsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets policy assignments of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PolicyAssignment> ListForResourceNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListForResourceNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets policy assignments of the resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PolicyAssignment>> ListForResourceNextAsync(this IPolicyAssignmentsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListForResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the policy assignments of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PolicyAssignment> ListNext(this IPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyAssignmentsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the policy assignments of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PolicyAssignment>> ListNextAsync(this IPolicyAssignmentsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}