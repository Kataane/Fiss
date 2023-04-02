namespace Fiss;

/// <summary>
///     Trading systems.
/// </summary>
/// <remarks>
///     Do not convert to number. Only as the string path will work.
/// </remarks>
public enum Engine : byte
{
    /// <summary>
    ///     Stock market and deposit market.
    /// </summary>
    Stock = 1,

    /// <summary>
    ///     Government securities market (placement).
    /// </summary>
    State = 2,

    /// <summary>
    ///     Currency market.
    /// </summary>
    Currency = 3,

    /// <summary>
    ///     Futures market.
    /// </summary>
    Futures = 4,

    /// <summary>
    ///     Commodity market.
    /// </summary>
    Commodity = 5,

    /// <summary>
    ///     Commodity interventions.
    /// </summary>
    Interventions = 6,

    /// <summary>
    ///     Over-the-counter system.
    /// </summary>
    Offboard = 7,

    /// <summary>
    ///     Agricultural market.
    /// </summary>
    Agro = 9
}
