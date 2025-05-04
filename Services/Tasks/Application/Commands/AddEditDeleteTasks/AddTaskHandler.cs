using MediatR;

namespace GlobalOutsourcingServices.Services.Tasks.Application.Command.AddEditDeleteTasks
{
    public class AddTaskHandler : IRequestHandler<AddTaskCommandDTO, string>
    {
        Task<string> IRequestHandler<AddTaskCommandDTO, string>.Handle(AddTaskCommandDTO request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
