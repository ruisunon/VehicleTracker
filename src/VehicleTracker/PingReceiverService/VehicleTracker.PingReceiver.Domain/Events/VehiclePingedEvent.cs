﻿using System;
using VehicleTracker.Abstract.Domain.Core.Events;

namespace VehicleTracker.PingReceiver.Domain.Events
{
    public class VehiclePingedEvent : Event
    {
        public VehiclePingedEvent(Guid id, string vehicleId, DateTime pingTime)
        {
            VehicleId = vehicleId;
            PingTime = pingTime;
            AggregateId = id;
        }
        public string VehicleId { get; protected set; }

        public DateTime PingTime { get; protected set; }
    }
}