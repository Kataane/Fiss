namespace Fiss.Enums;

/// <summary>
///     Рынок ГЦБ торговой системы
/// </summary>
public enum StateMarket
{
    /// <summary>
    ///     Индексы ГКО/ОФЗ
    ///     <para>
    ///         Принадлежит к следующей торговой системе <see cref="Engine.State" />.
    ///     </para>
    /// </summary>
    Index = 9,

    /// <summary>
    ///     Облигации ГЦБ
    ///     <para>
    ///         Принадлежит к следующей торговой системе <see cref="Engine.State" />.
    ///     </para>
    /// </summary>
    Bonds = 6,

    /// <summary>
    ///     Междилерское РЕПО
    ///     <para>
    ///         Принадлежит к следующей торговой системе <see cref="Engine.State" />.
    ///     </para>
    /// </summary>
    Repo = 7,

    /// <summary>
    ///     Внесистемные сделки
    ///     <para>
    ///         Принадлежит к следующей торговой системе <see cref="Engine.State" />.
    ///     </para>
    /// </summary>
    Ndm = 8
}