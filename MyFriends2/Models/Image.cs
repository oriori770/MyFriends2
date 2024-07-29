using System.ComponentModel.DataAnnotations;

namespace MyFriends2.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public int FriendId { get; set; }
        public Friend Friend { get; set; }

        [Display(Name = "תמונה")]
        // New property for image data
        public byte[] ImageData { get; set; }




    }
}