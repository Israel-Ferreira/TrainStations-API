using TrainStationsAPI.DataObjects;
using TrainStationsAPI.Models;

namespace TrainStationsAPI.Services;

public interface ITrainStationService {
    IEnumerable<TrainStation> ListAllStations();
    IEnumerable<TrainStation> ListAllLineStations(int lineNumber);
    Task AdicionarEstacao(int lineNumber, StationDto station);
    Task DesativarEstacao(int lineNumber, string stationCode);
    
    TrainStation GetStationByCode(string stationCode);
    TrainStation GetStationsById(long id);
}