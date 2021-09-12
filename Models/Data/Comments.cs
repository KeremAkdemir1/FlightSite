using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationSite3.Models.Data
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        public string Commenter { get; set; }
        public string Comment { get; set; }
    }
}
