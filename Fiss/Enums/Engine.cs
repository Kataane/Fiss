namespace Fiss.Enums;

/// <summary>
/// Торговые системы
/// </summary>
public enum Engine
{
    /// <summary>
    /// Фондовый рынок и рынок депозитов
    /// </summary>
    Stock = 1,

    /// <summary>
    /// Рынок ГЦБ (размещение)
    /// </summary>
    State = 2,

    /// <summary>
    /// Валютный рынок
    /// </summary>
    Currency = 3,

    /// <summary>
    /// Срочный рынок
    /// </summary>
    Futures = 4,

    /// <summary>
    /// Товарный рынок
    /// </summary>
    Commodity = 5,

    /// <summary>
    /// Товарные интервенции
    /// </summary>
    Interventions = 6,

    /// <summary>
    /// ОТС-система
    /// </summary>
    Offboard = 7,

    /// <summary>
    /// Агро
    /// </summary>
    Agro = 9,
}
