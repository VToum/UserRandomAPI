using System.ComponentModel.DataAnnotations;

namespace UserRandomAPI.Entity
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}