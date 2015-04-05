using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineCV.Models
{
    public class OnlineCvContext :DbContext
    {
        public OnlineCvContext()
            : base("name=OnlineCvContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<VendorCertification> VendorCertifications { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<ProjectWork> ProjectWorks { get; set; }
        public DbSet<ExtraWork> ExtraWorks { get; set; }
    }
}