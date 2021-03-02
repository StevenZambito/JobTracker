
namespace JobTracker.Models
{

    public class Company
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Technology { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public bool Remote { get; set; }
        public int ContactCount { get; set; }
        public string CompanyName { get; set; }
        public int Salary { get; set; }
        public bool Benefits { get; set; }
        public string CompanyLogo { get; set; }


    }
}