using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniDepartmentProject.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[Column(TypeName = "Varchar(20)")]
		public string Username { get; set; }

		[Required]
		[Column(TypeName = "Varchar(20)")]
		public string Password { get; set; }
	}
}
