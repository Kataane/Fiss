namespace Fiss;

/// <summary>
///     Durations of intervals.
/// </summary>
public enum Duration : byte
{
    /// <summary>
    ///     One minute.
    /// </summary>
    Minute = 1,

    /// <summary>
    ///     Ten minutes.
    /// </summary>
    TenMinutes = 10,

    /// <summary>
    ///     One hour.
    /// </summary>
    Hour = 60,

    /// <summary>
    ///     One day.
    /// </summary>
    Day = 24,

    /// <summary>
    ///     One week.
    /// </summary>
    Week = 7,

    /// <summary>
    ///     One month.
    /// </summary>
    Month = 31,

    /// <summary>
    ///     One quarter (three months).
    /// </summary>
    Quarter = 4
}