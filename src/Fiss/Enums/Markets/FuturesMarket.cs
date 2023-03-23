namespace Fiss;

/// <summary>
///     Futures market of the trading system
/// </summary>
public enum FuturesMarket
{
    /// <summary>
    ///     Futures instruments
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Futures" />.
    ///     </para>
    /// </summary>
    Main = 12,

    /// <summary>
    ///     FORTS
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Futures" />.
    ///     </para>
    /// </summary>
    Forts = 22,

    /// <summary>
    ///     FORTS options
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Futures" />.
    ///     </para>
    /// </summary>
    Options = 24,

    /// <summary>
    ///     IQS futures
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Futures" />.
    ///     </para>
    /// </summary>
    FortsIQS = 37,

    /// <summary>
    ///     IQS options
    ///     <para>
    ///         Belongs to the following trading system: <see cref="Engine.Futures" />.
    ///     </para>
    /// </summary>
    OptionsIQS = 38
}