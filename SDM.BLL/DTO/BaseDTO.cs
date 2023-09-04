using System.ComponentModel.DataAnnotations;

namespace SDM.BLL.DTO;

public class BaseDTO
{
	public Guid Id { get; set; }
	public virtual string Title { get; set; }
	public virtual string? Subtitle { get; set; }
	public virtual string Text { get; set; }
	public virtual string? TitleImagePath { get; set; }
	public virtual string? MetaTitle { get; set; }
	public virtual string? MetaDescription { get; set; }
	public virtual string? MetaKeywords { get; set; }
	public DateTime DateAdded { get; set; }
}
