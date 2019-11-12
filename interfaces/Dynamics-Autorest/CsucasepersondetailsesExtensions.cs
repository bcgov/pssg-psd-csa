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
    /// Extension methods for Csucasepersondetailses.
    /// </summary>
    public static partial class CsucasepersondetailsesExtensions
    {
            /// <summary>
            /// Get entities from csu_casepersondetailses
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
            public static MicrosoftDynamicsCRMcsuCasepersondetailsCollection Get(this ICsucasepersondetailses operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from csu_casepersondetailses
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
            public static async Task<MicrosoftDynamicsCRMcsuCasepersondetailsCollection> GetAsync(this ICsucasepersondetailses operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from csu_casepersondetailses
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuCasepersondetailsCollection> GetWithHttpMessages(this ICsucasepersondetailses operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to csu_casepersondetailses
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
            public static MicrosoftDynamicsCRMcsuCasepersondetails Create(this ICsucasepersondetailses operations, MicrosoftDynamicsCRMcsuCasepersondetails body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to csu_casepersondetailses
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
            public static async Task<MicrosoftDynamicsCRMcsuCasepersondetails> CreateAsync(this ICsucasepersondetailses operations, MicrosoftDynamicsCRMcsuCasepersondetails body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to csu_casepersondetailses
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuCasepersondetails> CreateWithHttpMessages(this ICsucasepersondetailses operations, MicrosoftDynamicsCRMcsuCasepersondetails body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from csu_casepersondetailses by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMcsuCasepersondetails CasepersondetailsesByKey(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.CasepersondetailsesByKeyAsync(csuCasepersondetailsid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from csu_casepersondetailses by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
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
            public static async Task<MicrosoftDynamicsCRMcsuCasepersondetails> CasepersondetailsesByKeyAsync(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CasepersondetailsesByKeyWithHttpMessagesAsync(csuCasepersondetailsid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from csu_casepersondetailses by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuCasepersondetails> CasepersondetailsesByKeyWithHttpMessages(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CasepersondetailsesByKeyWithHttpMessagesAsync(csuCasepersondetailsid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in csu_casepersondetailses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void CasepersondetailsesByKey1(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, MicrosoftDynamicsCRMcsuCasepersondetails body)
            {
                operations.CasepersondetailsesByKey1Async(csuCasepersondetailsid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in csu_casepersondetailses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CasepersondetailsesByKey1Async(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, MicrosoftDynamicsCRMcsuCasepersondetails body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CasepersondetailsesByKey1WithHttpMessagesAsync(csuCasepersondetailsid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in csu_casepersondetailses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse CasepersondetailsesByKey1WithHttpMessages(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, MicrosoftDynamicsCRMcsuCasepersondetails body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CasepersondetailsesByKey1WithHttpMessagesAsync(csuCasepersondetailsid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from csu_casepersondetailses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void CasepersondetailsesByKey2(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, string ifMatch = default(string))
            {
                operations.CasepersondetailsesByKey2Async(csuCasepersondetailsid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from csu_casepersondetailses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CasepersondetailsesByKey2Async(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CasepersondetailsesByKey2WithHttpMessagesAsync(csuCasepersondetailsid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from csu_casepersondetailses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuCasepersondetailsid'>
            /// key: csu_casepersondetailsid of csu_casepersondetails
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse CasepersondetailsesByKey2WithHttpMessages(this ICsucasepersondetailses operations, System.Guid csuCasepersondetailsid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CasepersondetailsesByKey2WithHttpMessagesAsync(csuCasepersondetailsid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
