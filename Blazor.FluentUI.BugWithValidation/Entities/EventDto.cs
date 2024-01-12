namespace Blazor.FluentUI.BugWithValidation.Entities
{
    public class EventDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public MyDictionaryItemDto MyDictionaryItem { get; set; }
    }
}
