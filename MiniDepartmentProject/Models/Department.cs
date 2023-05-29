using System.ComponentModel.DataAnnotations;

namespace MiniDepartmentProject.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Personel> Personels { get; set; }
    }
}
