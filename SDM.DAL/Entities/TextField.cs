namespace SDM.DAL.Entities;

public class TextField : EntityBase
{
	public string CodeWord { get; set; }
	public override string Title { get; set; } = "Информационная страница";
	public override string Text { get; set; } = "Содержание заполняется администратором";
}
