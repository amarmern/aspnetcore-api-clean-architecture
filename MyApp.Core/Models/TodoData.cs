using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Models
{
    public class TodoData
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool Completed { get; set; }
    }
}
