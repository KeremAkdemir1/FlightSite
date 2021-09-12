using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationSite3.Models.Data
{
    public class Accounts
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountPass { get; set; }
    }
}
