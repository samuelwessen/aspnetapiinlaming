using System;
using System.Collections.Generic;
using System.Text;


namespace SharedLibrary.Entities
{
    public partial class ErrandIssue
    {
        public int Id { get; set; }
        public string CustomersName { get; set; }
        public int ServiceWorkerId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Changed { get; set; }
        public string ErrandStatus { get; set; }
        public string Description { get; set; }

        public virtual ServiceWorker ServiceWorker { get; set; }
    }
}
