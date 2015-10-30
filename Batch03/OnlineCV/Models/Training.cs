using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineCV.Models
{
    public class Training
    {
        public Int32 Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Institute { get; set; }
        public string Duration { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Location { get; set; }
        public Int32 UserId { get; set; }
    }
}