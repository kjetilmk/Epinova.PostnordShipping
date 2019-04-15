﻿using System.Threading.Tasks;

namespace Epinova.PostnordShipping
{
    public interface IDeliveryService
    {
        Task<ServicePointInformation[]> FindServicePointsAsync(
            ClientInfo clientInfo,
            double latitude,
            double longitude,
            int maxResults = 0);

        double GetDistanceFromLatLonInKm(double lat1, double lon1, double lat2, double lon2);

        Task<ServicePointInformation> GetServicePointAsync(ClientInfo clientInfo, string pickupPointId, bool forceCacheRefresh = false);
    }
}