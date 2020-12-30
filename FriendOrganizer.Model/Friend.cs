using System.ComponentModel.DataAnnotations;

namespace FriendOrganizer.Model
{
    public class Friend
    {
        [Key]
        public int Id { get; set; }

        [Required]
        //[MaxLength(50)]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
