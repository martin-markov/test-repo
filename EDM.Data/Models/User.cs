﻿namespace EDM.Data.Models
{
    public class User
    {

        public int UserId { get; set; }
        public string UserName { get; set; } = default!;

        public string Password { get; set; } = default!;

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Phone { get; set; } = default!;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;  

        public int CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public Guid UserIdentifier { get; set; }    
    }
}
