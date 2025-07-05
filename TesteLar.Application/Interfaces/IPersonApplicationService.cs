using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLar.Application.DTO;

namespace TesteLar.Application.Interfaces
{
    public interface IPersonApplicationService: IDisposable
    {
        /// <summary>
        /// Gets a person by their ID.
        /// </summary>
        /// <param name="id">The ID of the person.</param>
        /// <returns>A task that represents the asynchronous operation, containing the person data.</returns>
        Task<PersonDTO> GetPersonByIdAsync(int id);

        /// <summary>
        /// Adds a new person.
        /// </summary>
        /// <param name="person">The person data to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task<bool> AddPersonAsync(PersonDTO person);

        /// <summary>
        /// Updates an existing person.
        /// </summary>
        /// <param name="person">The updated person data.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task<bool> UpdatePersonAsync(PersonDTO person);

        /// <summary>
        /// Deletes a person by their ID.
        /// </summary>
        /// <param name="id">The ID of the person to delete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task<bool> DeletePersonAsync(int id);

        /// <summary>
        /// Gets all people.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation, containing all people.</returns>
        Task<IList<PersonDTO>> GetAllPeopleAsync();
    }
}
