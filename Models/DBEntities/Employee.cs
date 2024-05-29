using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCRUD_App.Models.DBEntities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName= "varchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
    }
}
