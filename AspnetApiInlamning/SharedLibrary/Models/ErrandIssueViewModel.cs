using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Models
{
    public class ErrandIssueViewModel
    {
        public int Id { get; set; }
        public string CustomersName { get; set; }
        public int ServiceWorkerId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Changed { get; set; }
        public string ErrandStatus { get; set; }
        public string Description { get; set; }
    }
}
