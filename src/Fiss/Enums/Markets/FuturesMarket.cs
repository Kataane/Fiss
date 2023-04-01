namespace Fiss;

/// <summary>
///     Futures market of the trading system. Belongs to the following trading system: <see cref="Engine.Futures" />.
/// </summary>
/// <remarks>
///     Do not convert to number. Only as the string path will work.
/// </remarks>
public enum FuturesMarket : byte
{
    /// <summary>
    ///     Futures instruments.
    /// </summary>
    Main = 12,

    /// <summary>
    ///     FORTS.
    /// </summary>
    Forts = 22,

    /// <summary>
    ///     FORTS options.
    /// </summary>
    Options = 24,

    /// <summary>
    ///     IQS futures.
    /// </summary>
    FortsIQS = 37,

    /// <summary>
    ///     IQS options.
    /// </summary>
    OptionsIQS = 38
}
