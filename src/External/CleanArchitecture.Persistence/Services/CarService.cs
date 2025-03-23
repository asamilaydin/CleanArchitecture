using CleanArchitecture.Application.Car.Command.CreateCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Persistence.Context;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistence.Services;

public class CarService : ICarService
{
    private readonly AppDbContext _context;

    public CarService(AppDbContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(CreateCarCommand command, CancellationToken cancellationToken)
    {
        Car car = new()
        {
            Name = command.Name
        };
        await _context.Set<Car>().AddAsync(car, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}