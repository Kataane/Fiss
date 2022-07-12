namespace Fiss.Enums.Markets;

/// <summary>
/// Валютный рынок торговой системы
/// </summary>
public enum CurrencyMarket
{
    /// <summary>
    /// Бивалютная корзина
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// </summary>
    Basket = 21,

    /// <summary>
    /// Биржевые сделки с ЦК
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// </summary>
    Selt = 10,

    /// <summary>
    /// Поставочные фьючерсы
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// </summary>
    Futures = 34,

    /// <summary>
    /// Валютный фиксинг
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// </summary>
    Index = 41,

    /// <summary>
    /// Внебиржевой
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// </summary>
    Otc = 45,
}
