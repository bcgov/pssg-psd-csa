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
    /// Extension methods for Csuprovincestatecodes.
    /// </summary>
    public static partial class CsuprovincestatecodesExtensions
    {
            /// <summary>
            /// Get entities from csu_provincestatecodes
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
            public static MicrosoftDynamicsCRMcsuProvincestatecodeCollection Get(this ICsuprovincestatecodes operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from csu_provincestatecodes
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
            public static async Task<MicrosoftDynamicsCRMcsuProvincestatecodeCollection> GetAsync(this ICsuprovincestatecodes operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from csu_provincestatecodes
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuProvincestatecodeCollection> GetWithHttpMessages(this ICsuprovincestatecodes operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to csu_provincestatecodes
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
            public static MicrosoftDynamicsCRMcsuProvincestatecode Create(this ICsuprovincestatecodes operations, MicrosoftDynamicsCRMcsuProvincestatecode body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to csu_provincestatecodes
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
            public static async Task<MicrosoftDynamicsCRMcsuProvincestatecode> CreateAsync(this ICsuprovincestatecodes operations, MicrosoftDynamicsCRMcsuProvincestatecode body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to csu_provincestatecodes
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuProvincestatecode> CreateWithHttpMessages(this ICsuprovincestatecodes operations, MicrosoftDynamicsCRMcsuProvincestatecode body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from csu_provincestatecodes by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMcsuProvincestatecode ProvincestatecodesByKey(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.ProvincestatecodesByKeyAsync(csuProvincestatecodeid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from csu_provincestatecodes by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
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
            public static async Task<MicrosoftDynamicsCRMcsuProvincestatecode> ProvincestatecodesByKeyAsync(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ProvincestatecodesByKeyWithHttpMessagesAsync(csuProvincestatecodeid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from csu_provincestatecodes by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMcsuProvincestatecode> ProvincestatecodesByKeyWithHttpMessages(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ProvincestatecodesByKeyWithHttpMessagesAsync(csuProvincestatecodeid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in csu_provincestatecodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void ProvincestatecodesByKey1(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, MicrosoftDynamicsCRMcsuProvincestatecode body)
            {
                operations.ProvincestatecodesByKey1Async(csuProvincestatecodeid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in csu_provincestatecodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ProvincestatecodesByKey1Async(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, MicrosoftDynamicsCRMcsuProvincestatecode body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ProvincestatecodesByKey1WithHttpMessagesAsync(csuProvincestatecodeid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in csu_provincestatecodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse ProvincestatecodesByKey1WithHttpMessages(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, MicrosoftDynamicsCRMcsuProvincestatecode body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ProvincestatecodesByKey1WithHttpMessagesAsync(csuProvincestatecodeid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from csu_provincestatecodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void ProvincestatecodesByKey2(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, string ifMatch = default(string))
            {
                operations.ProvincestatecodesByKey2Async(csuProvincestatecodeid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from csu_provincestatecodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ProvincestatecodesByKey2Async(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ProvincestatecodesByKey2WithHttpMessagesAsync(csuProvincestatecodeid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from csu_provincestatecodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='csuProvincestatecodeid'>
            /// key: csu_provincestatecodeid of csu_provincestatecode
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse ProvincestatecodesByKey2WithHttpMessages(this ICsuprovincestatecodes operations, System.Guid csuProvincestatecodeid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ProvincestatecodesByKey2WithHttpMessagesAsync(csuProvincestatecodeid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
