namespace OnlineCV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonalInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        MotherName = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.String(),
                        MarritalStatus = c.String(nullable: false),
                        Nationality = c.String(nullable: false, maxLength: 50),
                        PersonalContact = c.String(nullable: false, maxLength: 20),
                        HomeContact = c.String(nullable: false, maxLength: 20),
                        PresentAddress = c.String(nullable: false, maxLength: 150),
                        PermanentAddress = c.String(nullable: false, maxLength: 150),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DegreeId = c.Int(nullable: false),
                        DegreeName = c.String(),
                        PassingYear = c.Int(nullable: false),
                        ResultId = c.Int(nullable: false),
                        GPA = c.Double(),
                        Scale = c.Double(),
                        Institution = c.String(),
                        BoardUniversity = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Degrees", t => t.DegreeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.DegreeId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Degrees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SortOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        Department = c.String(),
                        Employer = c.String(),
                        Responsibility = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Institute = c.String(),
                        Duration = c.String(),
                        CompletionDate = c.DateTime(nullable: false),
                        Location = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ProfessionalQualifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Degree = c.String(),
                        Institute = c.String(),
                        PassingYear = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.VendorCertifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vendor = c.String(),
                        AchievementDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        CertificationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Certifications", t => t.CertificationId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CertificationId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Certifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        VendorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.References",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Designation = c.String(),
                        Institute = c.String(),
                        ContactNumber = c.String(),
                        Email = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ProjectWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ClientName = c.String(),
                        Desciption = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserSkills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillId = c.Int(nullable: false),
                        Description = c.String(maxLength: 250),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.SkillId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        SortOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExtraWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Desciption = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ExtraWorks", new[] { "UserId" });
            DropIndex("dbo.UserSkills", new[] { "UserId" });
            DropIndex("dbo.UserSkills", new[] { "SkillId" });
            DropIndex("dbo.ProjectWorks", new[] { "UserId" });
            DropIndex("dbo.References", new[] { "UserId" });
            DropIndex("dbo.VendorCertifications", new[] { "UserId" });
            DropIndex("dbo.VendorCertifications", new[] { "CertificationId" });
            DropIndex("dbo.ProfessionalQualifications", new[] { "UserId" });
            DropIndex("dbo.Trainings", new[] { "UserId" });
            DropIndex("dbo.Experiences", new[] { "UserId" });
            DropIndex("dbo.Educations", new[] { "UserId" });
            DropIndex("dbo.Educations", new[] { "DegreeId" });
            DropIndex("dbo.PersonalInformations", new[] { "UserId" });
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropForeignKey("dbo.ExtraWorks", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserSkills", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserSkills", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.ProjectWorks", "UserId", "dbo.Users");
            DropForeignKey("dbo.References", "UserId", "dbo.Users");
            DropForeignKey("dbo.VendorCertifications", "UserId", "dbo.Users");
            DropForeignKey("dbo.VendorCertifications", "CertificationId", "dbo.Certifications");
            DropForeignKey("dbo.ProfessionalQualifications", "UserId", "dbo.Users");
            DropForeignKey("dbo.Trainings", "UserId", "dbo.Users");
            DropForeignKey("dbo.Experiences", "UserId", "dbo.Users");
            DropForeignKey("dbo.Educations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Educations", "DegreeId", "dbo.Degrees");
            DropForeignKey("dbo.PersonalInformations", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropTable("dbo.ExtraWorks");
            DropTable("dbo.Skills");
            DropTable("dbo.UserSkills");
            DropTable("dbo.ProjectWorks");
            DropTable("dbo.References");
            DropTable("dbo.Certifications");
            DropTable("dbo.VendorCertifications");
            DropTable("dbo.ProfessionalQualifications");
            DropTable("dbo.Trainings");
            DropTable("dbo.Experiences");
            DropTable("dbo.Degrees");
            DropTable("dbo.Educations");
            DropTable("dbo.PersonalInformations");
            DropTable("dbo.Roles");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
        }
    }
}
