using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dinTour.Models
{
    public class Deltager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeltagerNr { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Tlf { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Parkering> Parkering { get; set; }
        public Deltager(string name, string tlf, string email, string userName, string password)
        {
            Name = name;
            Tlf = tlf;
            Email = email;
            UserName = userName;
            Password = password;
        }

        public Deltager()
        {
            
        }
    }
}
