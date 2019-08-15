using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models
{
    public class WeddingGuest
    {
        [Key]
        public int WeddingGuestId{get;set;}
        public int UserId{get;set;}
        public int WeddingId{get;set;}

        public User AssociatedAttendee{get;set;}
        public Wedding AssociatedWedding{get;set;}
    }
}