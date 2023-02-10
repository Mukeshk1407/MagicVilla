using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNO { get; set; }

        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }

        public VillaDTO Villa { get; set; }
    }
}
