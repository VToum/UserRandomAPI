using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using UserRandomAPI.Models;

namespace UserRandomAPI.Entity
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string gender { get; set; }

        public int NameId { get; set; }
        [ForeignKey("NameId")]
        public Name name { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location location { get; set; }

        public string email { get; set; }

        public int LoginId { get; set; }
        [ForeignKey("LoginId")]
        public Login login { get; set; }

        public string phone { get; set; }
        public string cell { get; set; }

        public int UidId { get; set; }
        [ForeignKey("UidId")]
        public Uid id { get; set; }

        public string nat { get; set; }
    }

}
