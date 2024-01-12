namespace Blazor.FluentUI.BugWithValidation.Entities
{
    public class MyDictionaryItemDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
    }

    public static class MyDictionaryItemDtoFakeDatabase
    {
        private static List<MyDictionaryItemDto> _fakeItemsFromServer =
        [
            new MyDictionaryItemDto { Id = 1, Code = "ITEM_CODE_1", Name = "ITEM_NAME_1" },
            new MyDictionaryItemDto { Id = 2, Code = "ITEM_CODE_2", Name = "ITEM_NAME_2" },
            new MyDictionaryItemDto { Id = 3, Code = "ITEM_CODE_3", Name = "ITEM_NAME_3" },
            new MyDictionaryItemDto { Id = 4, Code = "ITEM_CODE_4", Name = "ITEM_NAME_4" },
            new MyDictionaryItemDto { Id = 5, Code = "ITEM_CODE_5", Name = "ITEM_NAME_5" },
            new MyDictionaryItemDto { Id = 6, Code = "ITEM_CODE_6", Name = "ITEM_NAME_6" },
            new MyDictionaryItemDto { Id = 7, Code = "ITEM_CODE_7", Name = "ITEM_NAME_7" },
            new MyDictionaryItemDto { Id = 8, Code = "ITEM_CODE_8", Name = "ITEM_NAME_8" },
            new MyDictionaryItemDto { Id = 9, Code = "ITEM_CODE_9", Name = "ITEM_NAME_9" },
            new MyDictionaryItemDto { Id = 10, Code = "ITEM_CODE_10", Name = "ITEM_NAME_10" },
            new MyDictionaryItemDto { Id = 11, Code = "ITEM_CODE_11", Name = "ITEM_NAME_11" },
            new MyDictionaryItemDto { Id = 12, Code = "ITEM_CODE_12", Name = "ITEM_NAME_12" },
            new MyDictionaryItemDto { Id = 13, Code = "ITEM_CODE_13", Name = "ITEM_NAME_13" },
            new MyDictionaryItemDto { Id = 14, Code = "ITEM_CODE_14", Name = "ITEM_NAME_14" },
            new MyDictionaryItemDto { Id = 15, Code = "ITEM_CODE_15", Name = "ITEM_NAME_15" },
            new MyDictionaryItemDto { Id = 16, Code = "ITEM_CODE_16", Name = "ITEM_NAME_16" },
            new MyDictionaryItemDto { Id = 17, Code = "ITEM_CODE_17", Name = "ITEM_NAME_17" },
            new MyDictionaryItemDto { Id = 18, Code = "ITEM_CODE_18", Name = "ITEM_NAME_18" },
            new MyDictionaryItemDto { Id = 19, Code = "ITEM_CODE_19", Name = "ITEM_NAME_19" },
            new MyDictionaryItemDto { Id = 20, Code = "ITEM_CODE_20", Name = "ITEM_NAME_20" },
            new MyDictionaryItemDto { Id = 21, Code = "ITEM_CODE_21", Name = "ITEM_NAME_21" },
        ];

        public static List<MyDictionaryItemDto> GetAll()
        {
            return _fakeItemsFromServer;
        }
    }
}
