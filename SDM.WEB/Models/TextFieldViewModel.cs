using System.ComponentModel.DataAnnotations;

namespace SDM.WEB.Models;

public class TextFieldViewModel : BaseViewModel
{
	[Required]
	public string CodeWord { get; set; }

	[Display(Name = "Название страницы (заголовок)")]
	public override string Title { get; set; }

	[Display(Name = "Cодержание страницы")]
	public override string Text { get; set; }
}
