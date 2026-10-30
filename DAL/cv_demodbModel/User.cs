using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Religion { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Status { get; set; }
        public string? MobileNo { get; set; }
        public int? ProfileCreatedby { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Cast { get; set; }
        public string? Height { get; set; }
        public string? Education { get; set; }
        public int? City { get; set; }
        public string? Occupation { get; set; }
        public bool? Terms { get; set; }
        public int? RoleId { get; set; }
        public string? UserImage { get; set; }
        public int? Age { get; set; }
        public string? UserKaTaruf { get; set; }
        public string? UserDiWohtiKaTaruf { get; set; }
        public string? CallStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
