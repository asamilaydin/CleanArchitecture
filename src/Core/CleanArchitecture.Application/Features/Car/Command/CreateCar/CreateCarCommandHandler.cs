using CleanArchitecture.Application.Services;
using MediatR;
using CleanArchitecture.Domain.Dtos;
namespace CleanArchitecture.Application.Car.Command.CreateCar;

public sealed class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, MessageResponse>
{
    private readonly ICarService _carService;

    public CreateCarCommandHandler(ICarService carService)
    {
        _carService = carService;
    }
    
    public async Task<MessageResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        await _carService.CreateAsync(request, CancellationToken.None);
        return new("başarıyla oluşturuldu");
    }
}