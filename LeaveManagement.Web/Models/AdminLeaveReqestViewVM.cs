using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class AdminLeaveReqestViewVM
    {
        [Display(Name = "Total Number of Request")]
        public int TotalRequests { get; set; }
        [Display(Name = "Approved Request")]
        public int ApprovedRequests { get; set; }
        [Display(Name = "Pending Request")]
        public int PendingRequests { get; set; }
        [Display(Name = "Rejected Request")]
        public int RejectedRequests { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }

        public EmployeeListVM Employee { get; set; }
    }
}
