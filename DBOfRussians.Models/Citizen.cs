using System;
using System.Collections.Generic;
using System.Text;

namespace DBOfRussians.Models
{
    public class Citizen
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surnames { get; set; }
        public string Patronymic { get; set; }
        public long SNILS { get; set; }

        public long INN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
    }
}
