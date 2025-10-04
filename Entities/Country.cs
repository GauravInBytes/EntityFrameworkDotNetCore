using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Entities
{

    /// <summary>
    /// Domain Model for Country
    /// </summary>
    public class Country
    {
        [Key]
        public Guid CountryID { get; set; }

        public string? CountryName { get; set; }
    }
}
