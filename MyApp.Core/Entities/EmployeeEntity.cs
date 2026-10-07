using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Entities
{
    public class EmployeeEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; } = null!;

        public string? Phone { get; set; }
    }
}
