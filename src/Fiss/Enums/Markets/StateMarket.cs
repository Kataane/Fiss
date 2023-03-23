namespace Fiss;

/// <summary>
///     Market of the trading system of government securities
/// </summary>
public enum StateMarket
{
    /// <summary>
    ///     Government Short-Term Commitments/Federal Loan Obligations indices
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.State" />.
    ///     </para>
    /// </summary>
    Index = 9,

    /// <summary>
    ///     Government bonds
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.State" />.
    ///     </para>
    /// </summary>
    Bonds = 6,

    /// <summary>
    ///     Interdealer repo
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.State" />.
    ///     </para>
    /// </summary>
    Repo = 7,

    /// <summary>
    ///     Off-exchange trades
    ///     <para>
    ///         Belongs to the following trading system <see cref="Engine.State" />.
    ///     </para>
    /// </summary>
    Ndm = 8
}