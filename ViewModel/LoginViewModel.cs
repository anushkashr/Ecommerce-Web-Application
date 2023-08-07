using System.ComponentModel.DataAnnotations;

namespace Ecommerce_WebApp.ViewModel
{
	public class LoginViewModel
	{
		[EmailAddress]
		[Required]
		public string? Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string? Password { get; set; }

		public string RememberMe { get; set; }
	}
}
