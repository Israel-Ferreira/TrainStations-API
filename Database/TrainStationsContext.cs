using Microsoft.EntityFrameworkCore;
using TrainStationsAPI.Models;

namespace TrainStationsAPI.Database;

public class TrainStationsContext : DbContext
{
    public TrainStationsContext(DbContextOptions<TrainStationsContext> options) : base(options)
    {
    }

    public DbSet<TrainStation> TrainStations { get; set; } = null!;

    public DbSet<Line?> Lines { get; set; } = null!;
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Line>().HasData(
            new Line(1, "Azul", 20.2, 1.6000, "Metrô SP") { LineId = 1},
            new Line(2, "Verde", 14.7, 1.6000, "Metrô SP") {LineId = 2},
            new Line(3, "Vermelha", 22.0, 1.6000, "Metrô SP") { LineId = 3},
            new Line(4, "Amarela", 12.8, 1.435, "Via Quatro") { LineId = 4},
            new Line(5, "Lilas", 20, 1.435, "Via Mobilidade") { LineId = 5},
            new Line(7, "Rubi", 60, 1.6000, "CPTM") { LineId =  6},
            new Line(8, "Diamante", 41.6, 1.6000, "Via Mobilidade") { LineId = 7 },
            new Line(9, "Esmeralda", 37.3, 1.6000, "Via Mobilidade") { LineId = 8 },
            new Line(10, "Turquesa", 38.3,  1.6000, "CPTM") { LineId = 9},
            new Line(11, "Coral", 50.5, 1.6000, "CPTM") { LineId = 10},
            new Line(12, "Safira", 39,  1.6000, "CPTM") { LineId = 11},
            new Line(13, "Jade", 12.2,  1.6000, "CPTM") { LineId = 12},
            new Line(15, "Prata", 14.4, 0, "Metrô SP") {LineId = 13}
        );
        
        base.OnModelCreating(modelBuilder);
    }
}