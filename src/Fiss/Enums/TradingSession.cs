namespace Fiss;

/// <summary>
/// Represents the trading sessions of a market.
/// </summary>
public enum TradingSession : byte
{
    /// <summary>
    /// Morning trading session.
    /// </summary>
    Morning,

    /// <summary>
    /// Main trading session.
    /// </summary>
    Main,

    /// <summary>
    /// Evening trading session.
    /// </summary>
    Evening,

    /// <summary>
    /// Represents the total trading session for the day.
    /// </summary>
    Total
}