using Microsoft.EntityFrameworkCore;
using TrainStationsAPI.Database;
using TrainStationsAPI.DataObjects;
using TrainStationsAPI.Exceptions;
using TrainStationsAPI.Models;

namespace TrainStationsAPI.Services;

public class TrainStationService : ITrainStationService
{
    private readonly TrainStationsContext _context;

    public TrainStationService(TrainStationsContext context)
    {
        _context = context;
    }

    public IEnumerable<TrainStation> ListAllStations()
    {
        return _context.TrainStations;
    }

    public IEnumerable<TrainStation> ListAllLineStations(int lineNumber)
    {
        return _context.TrainStations
            .Where(station => station.Lines.Select(line => line.LineNumber).Contains(lineNumber))
            .ToList();
    }

    public async Task AdicionarEstacao(int lineNumber, StationDto station)
    {
        Line? stationLine = await _context.Lines.FirstOrDefaultAsync(line => line.LineNumber.Equals(lineNumber));

        if (stationLine == null)
        {
            throw new LineNotFoundException(lineNumber);
        }

        string latStr = station.Latitude!.Replace(".", ",");
        string longitudeStr = station.Longitude!.Replace(".", ",");


        Address address = new()
        {
            PublicPlace = station.PublicPlace,
            Neighbourhood = station.Neighbourhood,
            Zipcode = station.ZipCode,
            AddressNumber = station.AddressNumber,
            Uf = station.Uf,
            City = station.City
        };


        TrainStation trainStation = new TrainStation
        {
            Name = station.Name,
            Latitude = double.Parse(latStr),
            Longitude = double.Parse(longitudeStr),
            StationAddress = address,
            OpeningYear = station.OpeningYear,
            Lines = { stationLine }
        };


        await _context.TrainStations.AddAsync(trainStation);
        await _context.SaveChangesAsync();
    }

    public async Task DesativarEstacao(int lineNumber, string stationCode)
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