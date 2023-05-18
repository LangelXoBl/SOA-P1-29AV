using Domain.Entitys;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAO
{
    public class PersonDao
    {
        private readonly ApplicationDbContext _context;
        public PersonDao( ApplicationDbContext context) { 
        _context= context;
        }

        public List<Person> GetList() { 
            List<Person> list = new List<Person>();
            DateTime date = new DateTime(2002,01,15);
            //list.Add(new Person(){ Id=1,Name="Luis", LastName="xool", CURP="IKYKY651", RFC="EF8E98G4T", Birthday=date});
            //list.Add(new Person(){ Id=2,Name="carlos", LastName="esquivel", CURP="WF1EW513W5EF", RFC="GE46GR51G3R", Birthday=date});
            //list.Add(new Person(){ Id=3,Name="ismael", LastName="hernandez", CURP="F5WER4F5W5F12", RFC="F54EW5FWE4", Birthday=date});

            list = _context.Persons.ToList();
            return list;
        }
    }
}
