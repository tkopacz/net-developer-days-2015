﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Pltkw3msApiUI2.ApiShipping;

namespace Pltkw3msApiUI2.ApiShipping
{
    public static partial class ShippingExtensions
    {
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static object DeleteById(this IShipping operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IShipping)s).DeleteByIdAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> DeleteByIdAsync(this IShipping operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.DeleteByIdWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        public static IList<string> Get(this IShipping operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IShipping)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<string>> GetAsync(this IShipping operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<string>> result = await operations.GetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static string GetById(this IShipping operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IShipping)s).GetByIdAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> GetByIdAsync(this IShipping operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.GetByIdWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        public static object PostByValue(this IShipping operations, string value)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IShipping)s).PostByValueAsync(value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PostByValueAsync(this IShipping operations, string value, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PostByValueWithOperationResponseAsync(value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        public static object PutByIdAndValue(this IShipping operations, int id, string value)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IShipping)s).PutByIdAndValueAsync(id, value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Pltkw3msApiUI2.ApiShipping.IShipping.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutByIdAndValueAsync(this IShipping operations, int id, string value, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutByIdAndValueWithOperationResponseAsync(id, value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
