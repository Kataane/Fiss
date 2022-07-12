namespace Fiss.Enums;

/// <summary>
/// Группа ценных бумаг
/// </summary>
public enum SecurityGroup
{
    /// <summary>
    /// Индексы
    /// </summary>
    StockIndex = 12,

    /// <summary>
    /// Акции
    /// </summary>
    StockShares = 4,

    /// <summary>
    /// Облигации
    /// </summary>
    StockBonds = 3,

    /// <summary>
    /// Валюта
    /// </summary>
    CurrencySelt = 9,

    /// <summary>
    /// Фьючерсы
    /// </summary>
    FuturesForts = 10,

    /// <summary>
    /// Опционы
    /// </summary>
    FuturesOptions = 26,

    /// <summary>
    /// Депозитарные расписки
    /// </summary>
    StockDr = 18,

    /// <summary>
    /// Иностранные ц.б.
    /// </summary>
    StockForeignShares = 33,

    /// <summary>
    /// Еврооблигации
    /// </summary>
    StockEurobond = 6,

    /// <summary>
    /// Паи ПИФов
    /// </summary>
    StockPpif = 5,

    /// <summary>
    /// Биржевые фонды
    /// </summary>
    StockEtf = 20,

    /// <summary>
    /// Драгоценные металлы
    /// </summary>
    CurrencyMetal = 24,

    /// <summary>
    /// Квал. инвесторы
    /// </summary>
    StockQnv = 21,

    /// <summary>
    /// Клиринговые сертификаты участия
    /// </summary>
    StockGcc = 27,

    /// <summary>
    /// Депозиты с ЦК
    /// </summary>
    StockDeposit = 29,

    /// <summary>
    /// Бивалютная корзина
    /// </summary>
    CurrencyBasket = 17,

    /// <summary>
    /// Валютный фьючерс
    /// </summary>
    CurrencyFutures = 28,

    /// <summary>
    /// Валютные фиксинги
    /// </summary>
    CurrencyIndices = 31,

    /// <summary>
    /// Товарные активы
    /// </summary>
    AgroCommodities = 40,

    /// <summary>
    /// Ипотечный сертификат
    /// </summary>
    StockMortgage = 22
}
