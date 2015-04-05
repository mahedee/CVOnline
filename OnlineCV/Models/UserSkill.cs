using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineCV.Models
{
    public class UserSkill
    {
        public Int32 Id { get; set; }
        public Int32 SkillId { get; set; }
        [ForeignKey("SkillId")]
        public Skill Skill { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public Int32 UserId { get; set; }
    }
}