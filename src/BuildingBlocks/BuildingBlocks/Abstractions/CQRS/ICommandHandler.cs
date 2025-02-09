﻿using MediatR;

namespace BuildingBlocks.Abstractions.CQRS
{
    public interface ICommandHandler <in TCommand> 
        : ICommandHandler<TCommand,Unit> 
        where TCommand : ICommand
    {
    }
    public interface ICommandHandler <in TCommand,TResponse> 
        : IRequestHandler<TCommand,TResponse> 
        where TCommand : ICommand<TResponse> 
        where TResponse : notnull
    {
    }
}
