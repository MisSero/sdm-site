﻿using System.ComponentModel.DataAnnotations;

namespace SDM.WEB.Models;

public class ServiceItemViewModel : BaseViewModel
{
	[Required(ErrorMessage = "Заполните название услуги")]
	[Display(Name = "Название услуги")]
	public override string Title { get; set; }

	[Display(Name = "Краткое описание услуги")]
	public override string? Subtitle { get; set; }

	[Display(Name = "Полное описание услуги")]
	public override string Text { get; set; }
}
