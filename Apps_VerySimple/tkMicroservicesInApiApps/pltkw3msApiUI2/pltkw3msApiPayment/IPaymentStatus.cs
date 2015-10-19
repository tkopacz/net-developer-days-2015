﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace Pltkw3msApiUI2.ApiPayment
{
    public partial interface IPaymentStatus
    {
        /// <param name='orderId'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> GetPaymentStatusByOrderidWithOperationResponseAsync(string orderId, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
