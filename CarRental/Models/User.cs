using System;

namespace CarRental.Models {
    public enum LoginRole {
        Admin,
        Employee,
        Client,
    }

    public class User {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime CreationDate { get; set; }
        public LoginRole Role { get; set; }
    }
}