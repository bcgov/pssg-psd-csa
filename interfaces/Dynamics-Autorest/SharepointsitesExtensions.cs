// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Pssg.Csa.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Sharepointsites.
    /// </summary>
    public static partial class SharepointsitesExtensions
    {
            /// <summary>
            /// Get entities from sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMsharepointsiteCollection Get(this ISharepointsites operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMsharepointsiteCollection> GetAsync(this ISharepointsites operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMsharepointsiteCollection> GetWithHttpMessages(this ISharepointsites operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMsharepointsite Create(this ISharepointsites operations, MicrosoftDynamicsCRMsharepointsite body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMsharepointsite> CreateAsync(this ISharepointsites operations, MicrosoftDynamicsCRMsharepointsite body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMsharepointsite> CreateWithHttpMessages(this ISharepointsites operations, MicrosoftDynamicsCRMsharepointsite body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from sharepointsites by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMsharepointsite GetByKeysharepointsitesByKey(this ISharepointsites operations, System.Guid sharepointsiteid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeysharepointsitesByKeyAsync(sharepointsiteid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from sharepointsites by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMsharepointsite> GetByKeysharepointsitesByKeyAsync(this ISharepointsites operations, System.Guid sharepointsiteid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeysharepointsitesByKeyWithHttpMessagesAsync(sharepointsiteid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from sharepointsites by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMsharepointsite> GetByKeysharepointsitesByKeyWithHttpMessages(this ISharepointsites operations, System.Guid sharepointsiteid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetByKeysharepointsitesByKeyWithHttpMessagesAsync(sharepointsiteid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void UpdatesharepointsitesByKey(this ISharepointsites operations, System.Guid sharepointsiteid, MicrosoftDynamicsCRMsharepointsite body)
            {
                operations.UpdatesharepointsitesByKeyAsync(sharepointsiteid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatesharepointsitesByKeyAsync(this ISharepointsites operations, System.Guid sharepointsiteid, MicrosoftDynamicsCRMsharepointsite body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdatesharepointsitesByKeyWithHttpMessagesAsync(sharepointsiteid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse UpdatesharepointsitesByKeyWithHttpMessages(this ISharepointsites operations, System.Guid sharepointsiteid, MicrosoftDynamicsCRMsharepointsite body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.UpdatesharepointsitesByKeyWithHttpMessagesAsync(sharepointsiteid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void DeletesharepointsitesByKey(this ISharepointsites operations, System.Guid sharepointsiteid, string ifMatch = default(string))
            {
                operations.DeletesharepointsitesByKeyAsync(sharepointsiteid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeletesharepointsitesByKeyAsync(this ISharepointsites operations, System.Guid sharepointsiteid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeletesharepointsitesByKeyWithHttpMessagesAsync(sharepointsiteid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from sharepointsites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid of sharepointsite
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse DeletesharepointsitesByKeyWithHttpMessages(this ISharepointsites operations, System.Guid sharepointsiteid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeletesharepointsitesByKeyWithHttpMessagesAsync(sharepointsiteid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
