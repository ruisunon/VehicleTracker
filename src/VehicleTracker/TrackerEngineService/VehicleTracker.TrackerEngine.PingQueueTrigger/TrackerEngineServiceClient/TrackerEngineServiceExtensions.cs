// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Threading;
using System.Threading.Tasks;
using VehicleTracker.TrackerEngine.PingQueueTrigger.TrackerEngineServiceClient.Models;

namespace VehicleTracker.TrackerEngine.PingQueueTrigger.TrackerEngineServiceClient
{
    /// <summary>
    /// Extension methods for TrackerEngineService.
    /// </summary>
    public static partial class TrackerEngineServiceExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='vehiclePingViewModel'>
            /// </param>
            public static void ReceivePing(this ITrackerEngineService operations, string version, VehiclePingViewModel vehiclePingViewModel = default(VehiclePingViewModel))
            {
                operations.ReceivePingAsync(version, vehiclePingViewModel).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='vehiclePingViewModel'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ReceivePingAsync(this ITrackerEngineService operations, string version, VehiclePingViewModel vehiclePingViewModel = default(VehiclePingViewModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ReceivePingWithHttpMessagesAsync(version, vehiclePingViewModel, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='version'>
            /// </param>
            public static object GetVehiclePingHistory(this ITrackerEngineService operations, System.Guid id, string version)
            {
                return operations.GetVehiclePingHistoryAsync(id, version).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetVehiclePingHistoryAsync(this ITrackerEngineService operations, System.Guid id, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVehiclePingHistoryWithHttpMessagesAsync(id, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
