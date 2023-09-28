using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Employee:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TaxId { get; set; }
        public string? DateOfBirth { get; set; }
        public string? DateJoined { get; set; }
    }
}
