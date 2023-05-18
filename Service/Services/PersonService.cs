using Domain.Entitys;
using Microsoft.Extensions.Logging;
using Repository.Context;
using Repository.DAO;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PersonService: IPerson
    {
        private readonly ILogger<PersonService> _logger;
        private readonly PersonDao personDao;

        public PersonService(ILogger<PersonService> logger, ApplicationDbContext context)
        {
            _logger = logger;
            personDao = new PersonDao(context);
        }
        public List<Person> GetPeople() { 

            List<Person> list = new List<Person>();
            try {
                list = personDao.GetList();
            } catch (Exception e) {
                _logger.LogError(e.Message);
            }

            return list;
        }
    }
}
