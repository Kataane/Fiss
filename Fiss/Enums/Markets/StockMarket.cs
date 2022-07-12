namespace Fiss.Enums.Markets;

/// <summary>
/// Фондовый и Депозитарный рынок торговой системы
/// </summary>
public enum StockMarket
{
	/// <summary>
	/// Индексы фондового рынка
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Index = 5,

	/// <summary>
	/// Рынок акций
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Shares = 1,

	/// <summary>
	/// Рынок облигаций
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Bonds = 2,

	/// <summary>
	/// Режим переговорных сделок
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Ndm = 4,

	/// <summary>
	/// ОТС
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Otc = 29,

	/// <summary>
	/// РЕПО с ЦК
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Ccp = 27,

	/// <summary>
	/// Депозиты с ЦК
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Deposit = 35,

	/// <summary>
	/// Рынок сделок РЕПО
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Repo = 3,

	/// <summary>
	/// Квал. инвесторы
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Qnv = 28,

	/// <summary>
	/// Мультивалютный рынок смешанных активов
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Mamc = 36,

	/// <summary>
	/// Иностранные ц.б.
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Foreignshares = 47,

	/// <summary>
	/// Иностранные ц.б. РПС
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Foreignndm = 49,

	/// <summary>
	/// MOEX Board
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Moexboard = 33,

	/// <summary>
	/// РЕПО с ЦК с КСУ
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Gcc = 46,

	/// <summary>
	/// Рынок кредитов
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Credit = 54,

	/// <summary>
	/// Standard
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Standard = 23,

	/// <summary>
	/// Classica
	/// <para> 
	/// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
	/// </para> 
	/// </summary>
	Classica = 25,
}