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
    /// Extension methods for Csuamporderreminderses.
    /// </summary>
    public static partial class CsuamporderremindersesExtensions
    {
            /// <summary>
            /// Get entities from csu_amporderreminderses
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
            public static MicrosoftDynamicsCRMcsuAmporderremindersCollection Get(this ICsuamporderreminderses operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from csu_amporderreminderses
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
            public static async Task<MicrosoftDynamicsCRMcsuAmporderremindersCollection> GetAsync(this ICsuamporderreminderses operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from csu_amporderreminderses
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuAmporderremindersCollection> GetWithHttpMessages(this ICsuamporderreminderses operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to csu_amporderreminderses
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
            public static MicrosoftDynamicsCRMcsuAmporderreminders Create(this ICsuamporderreminderses operations, MicrosoftDynamicsCRMcsuAmporderreminders body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to csu_amporderreminderses
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
            public static async Task<MicrosoftDynamicsCRMcsuAmporderreminders> CreateAsync(this ICsuamporderreminderses operations, MicrosoftDynamicsCRMcsuAmporderreminders body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to csu_amporderreminderses
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuAmporderreminders> CreateWithHttpMessages(this ICsuamporderreminderses operations, MicrosoftDynamicsCRMcsuAmporderreminders body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from csu_amporderreminderses by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMcsuAmporderreminders AmporderremindersesByKey(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.AmporderremindersesByKeyAsync(csuAmporderremindersid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from csu_amporderreminderses by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
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
            public static async Task<MicrosoftDynamicsCRMcsuAmporderreminders> AmporderremindersesByKeyAsync(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AmporderremindersesByKeyWithHttpMessagesAsync(csuAmporderremindersid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from csu_amporderreminderses by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuAmporderreminders> AmporderremindersesByKeyWithHttpMessages(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.AmporderremindersesByKeyWithHttpMessagesAsync(csuAmporderremindersid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in csu_amporderreminderses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void AmporderremindersesByKey1(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, MicrosoftDynamicsCRMcsuAmporderreminders body)
            {
                operations.AmporderremindersesByKey1Async(csuAmporderremindersid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in csu_amporderreminderses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AmporderremindersesByKey1Async(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, MicrosoftDynamicsCRMcsuAmporderreminders body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AmporderremindersesByKey1WithHttpMessagesAsync(csuAmporderremindersid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in csu_amporderreminderses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse AmporderremindersesByKey1WithHttpMessages(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, MicrosoftDynamicsCRMcsuAmporderreminders body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.AmporderremindersesByKey1WithHttpMessagesAsync(csuAmporderremindersid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from csu_amporderreminderses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void AmporderremindersesByKey2(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, string ifMatch = default(string))
            {
                operations.AmporderremindersesByKey2Async(csuAmporderremindersid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from csu_amporderreminderses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AmporderremindersesByKey2Async(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AmporderremindersesByKey2WithHttpMessagesAsync(csuAmporderremindersid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from csu_amporderreminderses
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuAmporderremindersid'>
            /// key: csu_amporderremindersid of csu_amporderreminders
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse AmporderremindersesByKey2WithHttpMessages(this ICsuamporderreminderses operations, System.Guid csuAmporderremindersid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.AmporderremindersesByKey2WithHttpMessagesAsync(csuAmporderremindersid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
