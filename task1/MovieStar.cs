using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;


namespace ConsoleUI
{
    [Serializable]
    public class MovieStar
    {
        public DateTime? dateOfBirth { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Sex { get; set; }
        public string? Nationality { get; set; }

        public int? CalculateAge()
        {
            DateTime current = DateTime.Now;
            DateTime StarAge = Convert.ToDateTime(this.dateOfBirth);
            return (DateTime.Now.Year - StarAge.Year);


        }
        public void PrintStar()
        {
            Console.WriteLine(this.Name + this.Surname + "\n" + this.Sex + "\n" + this.Nationality + "\n" + this.CalculateAge());
        }
    }
}