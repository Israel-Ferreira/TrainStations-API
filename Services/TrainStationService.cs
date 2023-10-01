using TrainStationsAPI.DataObjects;
using TrainStationsAPI.Models;

namespace TrainStationsAPI.Services;


public class TrainStationService : ITrainStationService
{
    public IEnumerable<TrainStation> ListAllStations()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TrainStation> ListAllLineStations(int lineNumber)
    {
        throw new NotImplementedException();
    }

    public void AdicionarEstacao(int lineNumber, StationDto station)
    {
        throw new NotImplementedException();
    }

    public void DesativarEstacao(int lineNumber, string stationCode)
    {
        throw new NotImplementedException();
    }

    public TrainStation GetStationByCode(string stationCode)
    {
        throw new NotImplementedException();
    }

    public TrainStation GetStationsById(long id)
    {
        throw new NotImplementedException();
    }
}