using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineCV.Models
{
    public class Skill
    {
        public Int32 Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public Int32 SortOrder { get; set; }
    }
}