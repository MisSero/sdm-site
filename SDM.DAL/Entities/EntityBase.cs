using System.ComponentModel.DataAnnotations;

namespace SDM.DAL.Entities;

public abstract class EntityBase
{
	protected EntityBase() => DateAdded = DateTime.UtcNow;

	public Guid Id { get; set; }
	public virtual string Title { get; set; }
	public virtual string? Subtitle { get; set; }
	public virtual string Text { get; set; }
	public virtual string? TitleImagePath { get; set; }
	public virtual string MetaTitle { get; set; } = "Метатег не установлен";
	public virtual string MetaDescription { get; set; } = "Метатег не установлен";
	public virtual string MetaKeywords { get; set; } = "Метатег не установлен";
	public DateTime DateAdded { get; set; }
}
