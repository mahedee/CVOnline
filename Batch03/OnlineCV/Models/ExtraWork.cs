using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCV.Models
{
    public class ExtraWork
    {
        public Int32 Id { get; set; }
        public string Title { get; set; }
        public string Desciption { get; set; }
        public Int32 UserId { get; set; }
    }
}