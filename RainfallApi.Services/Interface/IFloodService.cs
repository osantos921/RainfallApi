using RainfallApi.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallApi.Services.Interface;
public interface IFloodService
{
    Task<FloodCollection> GetAllFlood(CancellationToken cancellationToken);
    Task<ReadingsCollection> GetStationId(string stationID, CancellationToken cancellationToken);
}

