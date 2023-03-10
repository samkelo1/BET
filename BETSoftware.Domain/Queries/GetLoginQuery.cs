using BETSoftware.Domain.Models;
using MediatR;

namespace BETSoftware.Domain.Queries
{
    public record GetLoginQuery(Login Login) : IRequest<Login>;
}
