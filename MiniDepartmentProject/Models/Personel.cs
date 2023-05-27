using System.ComponentModel.DataAnnotations;

namespace MiniDepartmentProject.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
