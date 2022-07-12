namespace Fiss.Enums;

/// <summary>
/// Коллекции ценных бумаг входящие в группу ценных бумаг
/// </summary>
public enum SecurityCollection
{
    /// <summary>
    /// Индексы.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexAll = 72,

    /// <summary>
    /// Основные индексы акций.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexShares = 213,

    /// <summary>
    /// Отраслевые индексы акций.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexSharesSectoral = 210,

    /// <summary>
    /// Индексы акций полной доходности.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexTotalReturn = 249,

    /// <summary>
    /// Тематические индексы акций.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexSharesThematic = 211,

    /// <summary>
    /// Основные индексы облигаций.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexBonds = 207,

    /// <summary>
    /// Индексы государственных облигаций.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexBondsState = 214,

    /// <summary>
    /// Индексы корпоративных облигаций.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexBondsCorporate = 208,

    /// <summary>
    /// Индексы муниципальных облигаций.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexBondsMunicipal = 212,

    /// <summary>
    /// Индексы активов пенсионных накоплений.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexBondsRetiring = 209,

    /// <summary>
    /// Индексы еврооблигаций.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexEurobonds = 328,

    /// <summary>
    /// Российские индексы волатильности.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexVolatility = 215,

    /// <summary>
    /// INAV.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexInav = 259,

    /// <summary>
    /// Индикаторы ставок РЕПО.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexRepo = 115,

    /// <summary>
    /// Money market index.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexMmix = 295,

    /// <summary>
    /// Облигационные индексы котировальных листов.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexQuotationlistBond = 229,

    /// <summary>
    /// Товарные индексы.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexCommodity = 324,

    /// <summary>
    /// Индексы СПФИ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexSdfi = 323,

    /// <summary>
    /// Заказные индексы.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockIndex"/>.
    /// </para>
    /// </summary>
    StockIndexCustom = 327,

    /// <summary>
    /// Все акции.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockShares"/>.
    /// </para>
    /// </summary>
    StockSharesAll = 3,

    /// <summary>
    /// Уровень 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockShares"/>.
    /// </para>
    /// </summary>
    StockSharesOne = 160,

    /// <summary>
    /// Уровень 2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockShares"/>.
    /// </para>
    /// </summary>
    StockSharesTwo = 161,

    /// <summary>
    /// Уровень 3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockShares"/>.
    /// </para>
    /// </summary>
    StockSharesThree = 162,

    /// <summary>
    /// Все облигации.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsAll = 7,

    /// <summary>
    /// Все облигации уровеня 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsOne = 163,

    /// <summary>
    /// Все облигации уровеня 2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsTwo = 164,

    /// <summary>
    /// Все облигации уровеня 3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsThree = 165,

    /// <summary>
    /// Все корпоративные облигации.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsCorpAll = 189,

    /// <summary>
    /// Корпоративные облигации уровеня 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsCorpOne = 202,

    /// <summary>
    /// Корпоративные облигации уровеня 2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsCorpTwo = 194,

    /// <summary>
    /// Корпоративные облигации уровеня 3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsCorpThree = 188,

    /// <summary>
    /// Все биржевые облигации.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsExchangeAll = 200,

    /// <summary>
    /// Биржевые облигации уровеня 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockExchangeCorpOne = 185,

    /// <summary>
    /// Биржевые облигации уровеня 2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsExchangeTwo = 195,

    /// <summary>
    /// Биржевые облигации уровеня 3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsExchangeThree = 190,

    /// <summary>
    /// Все муниципальные облигации.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsMunicipalAll = 205,

    /// <summary>
    /// Муниципальные облигации уровеня 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsMunicipalOne = 201,

    /// <summary>
    /// Муниципальные облигации уровеня 2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsMunicipalTwo = 191,

    /// <summary>
    /// Муниципальные облигации уровеня 3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsMunicipalThree = 203,

    /// <summary>
    /// Все облигации субъектов РФ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsSubfederalAll = 198,

    /// <summary>
    /// Облигации Субъектов РФ уровеня 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsSubfederalOne = 206,

    /// <summary>
    /// Облигации Субъектов РФ уровеня 2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsSubfederalTwo = 204,

    /// <summary>
    /// Облигации Субъектов РФ уровеня 3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsSubfederalThree = 192,

    /// <summary>
    /// Все облигации федерального займа.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsOfzAll = 186,

    /// <summary>
    /// Все облигации Банка России.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsCbAll = 193,

    /// <summary>
    /// Все облигации иностранных эмитентов.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsIfiAll = 197,

    /// <summary>
    /// Облигации иностранных эмитентов уровеня 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsIfiOne = 199,

    /// <summary>
    /// Облигации иностранных эмитентов уровеня  2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsIfiTwo = 187,

    /// <summary>
    /// Облигации иностранных эмитентов уровеня  3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    StockBondsIfiThree = 196,

    /// <summary>
    /// Все коммерческие облигации.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockBonds"/>.
    /// </para>
    /// </summary>
    OffboardBondsAll = 303,

    /// <summary>
    /// Все валюты СПОТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltAllSpot = 177,

    /// <summary>
    /// Все валюты СВОП.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltAllSwap = 170,

    /// <summary>
    /// USD/RUB СПОТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltUsdSpot = 173,

    /// <summary>
    /// USD/RUB СВОП.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltUsdSwap = 174,

    /// <summary>
    /// EUR/RUB СПОТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltEurSpot = 172,

    /// <summary>
    /// EUR/RUB СВОП.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltEurSwap = 179,

    /// <summary>
    /// CNY/RUB СПОТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltCnySpot = 181,

    /// <summary>
    /// CNY/RUB СВОП.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltCnySwap = 176,

    /// <summary>
    /// EUR/USD СПОТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltEurusdSpot = 178,

    /// <summary>
    /// EUR/USD СВОП.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltEurusdSwap = 180,

    /// <summary>
    /// Другие валюты СПОТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltOtherSpot = 171,

    /// <summary>
    /// Другие валюты СВОП.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencySelt"/>.
    /// </para>
    /// </summary>
    CurrencySeltOtherSwap = 175,

    /// <summary>
    /// Все фьючерсы.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesForts"/>.
    /// </para>
    /// </summary>
    FuturesFortsAll = 227,

    /// <summary>
    /// Фьючерсы на индексы.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesForts"/>.
    /// </para>
    /// </summary>
    FuturesFortsIndex = 226,

    /// <summary>
    /// Фьючерсы на акции.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesForts"/>.
    /// </para>
    /// </summary>
    FuturesFortsShares = 224,

    /// <summary>
    /// Фьючерсы на валюты.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesForts"/>.
    /// </para>
    /// </summary>
    FuturesFortsCurrency = 225,

    /// <summary>
    /// Фьючерсы на процентные ставки.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesForts"/>.
    /// </para>
    /// </summary>
    FuturesFortsInterest = 228,

    /// <summary>
    /// Фьючерсы на товарные контракты.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesForts"/>.
    /// </para>
    /// </summary>
    FuturesFortsCommodity = 223,

    /// <summary>
    /// Фьючерсы на ОФЗ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesForts"/>.
    /// </para>
    /// </summary>
    FuturesFortsOfz = 260,

    /// <summary>
    /// Все опционы.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesOptions"/>.
    /// </para>
    /// </summary>
    FuturesOptionsAll = 218,

    /// <summary>
    /// Опционы ф. на индекс.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesOptions"/>.
    /// </para>
    /// </summary>
    FuturesOptionsIndex = 222,

    /// <summary>
    /// Опционы ф. на акции.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesOptions"/>.
    /// </para>
    /// </summary>
    FuturesOptionsShares = 221,

    /// <summary>
    /// Опционы ф. на валюты.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesOptions"/>.
    /// </para>
    /// </summary>
    FuturesOptionsCurrency = 220,

    /// <summary>
    /// Опционы ф. на товарные контракты.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.FuturesOptions"/>.
    /// </para>
    /// </summary>
    FuturesOptionsCommodity = 219,

    /// <summary>
    /// Все ДР.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockDr"/>.
    /// </para>
    /// </summary>
    StockDrAll = 130,

    /// <summary>
    /// Иностранные ц.б..
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockForeignShares"/>.
    /// </para>
    /// </summary>
    StockForeignSharesAll = 301,

    /// <summary>
    /// Все еврооблигации.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockEurobond"/>.
    /// </para>
    /// </summary>
    StockEurobondAll = 60,

    /// <summary>
    /// Все еврооблигации уровеня 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockEurobond"/>.
    /// </para>
    /// </summary>
    StockEurobondOne = 184,

    /// <summary>
    /// Все еврооблигации уровеня 2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockEurobond"/>.
    /// </para>
    /// </summary>
    StockEurobondTwo = 182,

    /// <summary>
    /// Все еврооблигации уровеня 3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockEurobond"/>.
    /// </para>
    /// </summary>
    StockEurobondThree = 183,

    /// <summary>
    /// Все ПИФы.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.5"/>.
    /// </para>
    /// </summary>
    StockPpifAll = 59,

    /// <summary>
    /// Все ПИФы уровеня 1.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.5"/>.
    /// </para>
    /// </summary>
    StockPpifOne = 166,

    /// <summary>
    /// Все ПИФы уровеня 2.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.5"/>.
    /// </para>
    /// </summary>
    StockPpifTwo = 167,

    /// <summary>
    /// Все ПИФы уровеня 3.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.5"/>.
    /// </para>
    /// </summary>
    StockPpifThree = 168,

    /// <summary>
    /// Все паи иностранных фондов.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.20"/>.
    /// </para>
    /// </summary>
    StockEtfAll = 151,

    /// <summary>
    /// Золото.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.2StockShares"/>.
    /// </para>
    /// </summary>
    CurrencyMetalGold = 216,

    /// <summary>
    /// Серебро.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.2StockShares"/>.
    /// </para>
    /// </summary>
    CurrencyMetalSilver = 217,

    /// <summary>
    /// Ценные бумаги для квал. инвесторов
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockQnv"/>.
    /// </para>
    /// </summary>
    StockQnvAll = 152,

    /// <summary>
    /// Клиринговые сертификаты участия.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockGcc"/>.
    /// </para>
    /// </summary>
    StockGccAll = 230,

    /// <summary>
    /// Депозиты с ЦК.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.StockDeposit"/>.
    /// </para>
    /// </summary>
    StockDepositAll = 258,

    /// <summary>
    /// Бивалютная корзина.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyBasket"/>.
    /// </para>
    /// </summary>
    CurrencyBasketAll = 116,

    /// <summary>
    /// Валюты поставочные СВОП КОНТРАКТЫ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesSwapAll = 286,

    /// <summary>
    /// Валюты поставочные ФЬЮЧЕРСЫ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesDeliveryAll = 254,

    /// <summary>
    /// USD/RUB поставочный СВОП КОНТРАКТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesSwapUsd = 287,

    /// <summary>
    /// USD/RUB поставочный ФЬЮЧЕРС.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesDeliveryUsd = 252,

    /// <summary>
    /// EUR/RUB поставочный СВОП КОНТРАКТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesSwapEur = 288,

    /// <summary>
    /// EUR/RUB поставочный ФЬЮЧЕРС.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesDeliveryEur = 255,

    /// <summary>
    /// CNY/RUB поставочный СВОП КОНТРАКТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesSwapCny = 289,

    /// <summary>
    /// CNY/RUB поставочный ФЬЮЧЕРС.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesDeliveryCny = 250,

    /// <summary>
    /// Другие валюты поставочный СВОП КОНТРАКТ.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesSwapOther = 292,

    /// <summary>
    /// Другие валюты поставочный ФЬЮЧЕРС.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyFutures"/>.
    /// </para>
    /// </summary>
    CurrencyFuturesDeliveryOthers = 293,

    /// <summary>
    /// Валютные фиксинги.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.CurrencyIndices"/>.
    /// </para>
    /// </summary>
    CurrencyIndicesAll = 297,

    /// <summary>
    /// Товарные активы - Сахар.
    /// <para>
    /// Входит в группу ценных бумаг <see cref="SecurityGroup.AgroSugar"/>.
    /// </para>
    /// </summary>
    AgroSugarAll = 325,
}
