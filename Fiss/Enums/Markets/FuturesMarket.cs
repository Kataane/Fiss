namespace Fiss.Enums.Markets;

/// <summary>
/// Срочный рынок торговой системы
/// </summary>
public enum FuturesMarket
{
	/// <summary>
	/// Срочные инструменты
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
	/// </para> 
	/// </summary>
	Main = 12,

	/// <summary>
	/// ФОРТС
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
	/// </para> 
	/// </summary>
	Forts = 22,

	/// <summary>
	/// Опционы ФОРТС
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
	/// </para> 
	/// </summary>
	Options = 24,

    /// <summary>
    /// Фьючерсы IQS
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
    /// </para> 
    /// </summary>
    FortsIQS = 37,

    /// <summary>
    /// Опционы IQS
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
    /// </para> 
    /// </summary>
    OptionsIQS = 38,
}