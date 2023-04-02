namespace Fiss;

/// <summary>
///     Market of the trading system of government securities. Belongs to the following trading system <see cref="Engine.State" />.
/// </summary>
/// <remarks>
///     Do not convert to number. Only as the string path will work.
/// </remarks>
public enum StateMarket : byte
{
    /// <summary>
    ///     Government Short-Term Commitments/Federal Loan Obligations indices.
    /// </summary>
    Index = 9,

    /// <summary>
    ///     Government bonds.
    /// </summary>
    Bonds = 6,

    /// <summary>
    ///     Interdealer repo.
    /// </summary>
    Repo = 7,

    /// <summary>
    ///     Off-exchange trades.
    /// </summary>
    Ndm = 8
}
