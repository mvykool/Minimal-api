using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Post       //change to public touse it in other layers
    {
        public int Id { get; set; }

        public string? Content { get; set; }   //the ? mark makes it nullable

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }
    }
}
