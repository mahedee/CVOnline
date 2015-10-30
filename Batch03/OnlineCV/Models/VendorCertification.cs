using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineCV.Models
{
    public class VendorCertification
    {
        public Int32 Id { get; set; }
        public String Vendor { get; set; }
        public DateTime AchievementDate { get; set; }
        public Int32 UserId { get; set; }
        public Int32 CertificationId { get; set; }
        [ForeignKey("CertificationId")]
        public Certification Certifications { get; set; }
    }
}