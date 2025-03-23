using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Car.Command.CreateCar;

public sealed record CreateCarCommand(
    string Name) : IRequest<MessageResponse>;
