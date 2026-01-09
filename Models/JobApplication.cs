//  Logo -> Link with Company Website 
//         - Company Website
//     Company Name
//     Role - Postion

//     Location
//     Reference Link (Where Applied)

//     Applied Date - Time
//     Last Update Date - Time

//     Action
//     - Status 
//     - Next Action - Pending 

//     Utils
//     - Archive (Soft Delete)
//     - Edit

using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Job_Application_Tracker.Models
{



    public enum StatusList
    {
        NoHope,
        Submitted,

        Interviewed,
        Rejected,
        Accepted,
        Offer,


    }

    public enum NextActionList
    {
        NoHope,
        Pending,
        FollowUp,
        Waiting,
        PrepInterview,
        SendEmail,
        Decide,
    }


    public class JobApplication
    {
        public Guid Id { get; set; } = Guid.NewGuid();
       
        [Required(ErrorMessage = "Cannot leave COMPANY NAME blank")]
        public string CompanyName { get; set; }  = string.Empty; //

        [Required(ErrorMessage = "Cannot leave ROLE name blank")]

        public string Role { get; set; }  = string.Empty; //
        [Required(ErrorMessage = "Cannot leave POSITION blank")]
 
        public string Position { get; set; }  = string.Empty; // 
        public string Location { get; set; }  = string.Empty; // 
        public DateTime? DateApplied { get; set; } = DateTime.Now;//
        public DateTime? DateUpdate { get; set; } = DateTime.Now;
        public StatusList CurrentStatus { get; set; } = StatusList.Submitted;
        public NextActionList NextAction { get; set; } = NextActionList.Pending;
        public string Link { get; set; } = string.Empty;
        public string Name { get; set; }  = string.Empty; //
        public string Email { get; set; }  = string.Empty; //
        public string Number { get; set; }  = string.Empty; //

        public string LogoImgLink { get; set; }  = string.Empty; // 
        [Required(ErrorMessage = "Cannot leave APPLIED LINK blank")]
        public string AppliedLink { get; set; }  = string.Empty; //

    }

}