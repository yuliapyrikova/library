using pyrikova.Domain;
using pyrikova.Repository;
using Microsoft.AspNetCore.Mvc;

namespace pyrikova.Controllers
{
    [ApiController]
    [Route("/personalData")]
    public class PersonalDataController : ControllerBase
    {
        [HttpPut]
        public PersonalData Create(PersonalData personalData)
        {
            Storage.PersonalDataStorage.Create(personalData);
            return personalData;
        }

        [HttpGet]
        public PersonalData Read(int personalDataId)
        {
            return Storage.PersonalDataStorage.Read(personalDataId);
        }
    }
}