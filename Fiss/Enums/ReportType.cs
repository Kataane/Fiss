namespace Fiss.Enums;

/// <summary>
///     Reports on currency derivatives
/// </summary>
public enum ReportType
{
    /// <summary>
    ///     Information on the number of contracts on instruments that are derivative financial instruments
    /// </summary>
    NumTrades,

    /// <summary>
    ///     Information on the number of persons having open positions on instruments that are derivative financial instruments
    /// </summary>
    Participants,

    /// <summary>
    ///     Information on open positions in instruments that are derivative financial instruments
    /// </summary>
    OpenPositions,

    /// <summary>
    ///     Information on the number of persons having open positions under the contracts which are derivative financial instruments
    /// </summary>
    ExpirationParticipants,

    /// <summary>
    ///     Information on the volume of open positions under the contracts which are derivative financial instruments
    /// </summary>
    ExpirationOpenPositions
}