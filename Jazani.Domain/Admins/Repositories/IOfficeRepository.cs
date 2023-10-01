using Jazani.Domain.Admins.Models;
using System;

namespace Jazani.Domain.Admins.Repositories
{
    //Definiendo el contrato de la Interfaz
    public interface IOfficeRepository
    {
        Task<IReadOnlyList<Office>> FindAllAsync();
        Task<Office?> FindByIdAsync(int id);
    }
}
