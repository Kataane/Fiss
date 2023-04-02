namespace Fiss;

/// <summary>
///     Represents the number of items to display on a page.
/// </summary>
public enum PageSize : byte
{
    /// <summary>
    ///     Displays one item per page.
    /// </summary>
    One = 1,

    /// <summary>
    ///     Displays five items per page.
    /// </summary>
    Five = 5,

    /// <summary>
    ///     Displays ten items per page.
    /// </summary>
    Ten = 10,

    /// <summary>
    ///     Displays twenty items per page.
    /// </summary>
    Twenty = 20,

    /// <summary>
    ///     Displays fifty items per page.
    /// </summary>
    Fifty = 50,

    /// <summary>
    ///     Displays one hundred items per page.
    /// </summary>
    Hundred = 100
}