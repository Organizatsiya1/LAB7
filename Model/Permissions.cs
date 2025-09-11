namespace Logic
{

    [Flags]
    public enum Permissions //Вот тут начинается бред: собрать для удобства полномочия? НЕЕЕЕЕЕТ! 3 класса меняют каждый свои стадии готовки заказа
    {
        None = 0,
        MarkPayed = 1,
        MarkDelivered = 2,
        MarkReady = 4,
        MarkGiven = 8,
        BookTable = 16,
        MakeOrder = 32,
        MarkCoockedFood = 64,
        MarkCoocked = 128,
        Register = 256,
        ShowInfo = 512,
        GiveBonus = 1024,
        ViewStats = 2048,
        All = MarkPayed|MarkDelivered|MarkReady|MarkGiven|BookTable|MakeOrder|MarkCoockedFood|Register|ShowInfo|GiveBonus|ViewStats
    }

}

