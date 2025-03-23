using CleanArchitecture.Application.Car.Command.CreateCar;

namespace CleanArchitecture.Application.Services;

public interface ICarService
{
    Task CreateAsync(CreateCarCommand command, CancellationToken cancellationToken );
}