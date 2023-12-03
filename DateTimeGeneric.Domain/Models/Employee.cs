using DateTimeGeneric.Domain.Models.Common;


namespace DateTimeGeneric.Domain.Models
{
    public class Employee:BaseEntitiy
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            
        }

        public Employee(DateTime birthday)
        {
            Birthday = birthday;
        }
    }
}
