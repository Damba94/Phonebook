﻿using Phonebook.Server.Models;
using Phonebook.Shared;

namespace Phonebook.Server.Services.PersonServices
{
    public interface IPersonService
    {
        Task<ServiceResponse<List<Person>>> GetPersons();
        Task<ServiceResponse<List<Person>>> GetPersonsbyId(int id);
    }
}
