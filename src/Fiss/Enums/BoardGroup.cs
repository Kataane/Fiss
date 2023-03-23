namespace Fiss;

/// <summary>
/// Список групп режимов торгов
/// </summary>
public enum BoardGroup
{
    /// <summary>
    /// Индексы
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Index"/>. 
    /// </para> 
    /// </summary>
    StockIndex = 9,

    /// <summary>
    /// INAV
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Index"/>. 
    /// </para> 
    /// </summary>
    StockIndexInav = 104,

    /// <summary>
    /// Money Market IndeX
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Index"/>. 
    /// </para> 
    /// </summary>
    StockIndexMmix = 155,

    /// <summary>
    /// Индексы СПФИ
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Index"/>. 
    /// </para> 
    /// </summary>
    StockIndexSdfi = 287,

    /// <summary>
    /// Т+: Основной режим - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockSharesTplus = 57,

    /// <summary>
    /// Т+: Основной режим (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockSharesTplusUsd = 156,

    /// <summary>
    /// Т0: Основной режим - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockShares = 6,

    /// <summary>
    /// Поставка по СК
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockSharesSettle = 125,

    /// <summary>
    /// Неполные лоты - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockSharesSm = 21,

    /// <summary>
    /// Крупные пакеты - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockSharesDarkpool = 42,

    /// <summary>
    /// Т0 ETF (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockEtfUsd = 99,

    /// <summary>
    /// Т+: Основной режим (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockSharesTplusEur = 157,

    /// <summary>
    /// Т0 ETF (расч. в EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockSharesEtfEur = 159,

    /// <summary>
    /// ЦК - Режим основных торгов - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Shares"/>. 
    /// </para> 
    /// </summary>
    StockSharesCc = 30,

    /// <summary>
    /// Т+: Основной режим - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsTplus = 58,

    /// <summary>
    /// Т+: Основной режим (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsTplusUsd = 193,

    /// <summary>
    /// Т+: Основной режим (ЕТС) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockEtcTplus = 68,

    /// <summary>
    /// Т0: Основной режим - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBonds = 7,

    /// <summary>
    /// Поставка по СК
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsSettle = 105,

    /// <summary>
    /// Т0: Основной режим (ЕТС) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockEtc = 69,

    /// <summary>
    /// Т0: Основной режим (Еврооблигации) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsEuro = 67,

    /// <summary>
    /// Выкуп - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsBuyback = 122,

    /// <summary>
    /// Размещение - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsDistribution = 123,

    /// <summary>
    /// Крупные пакеты - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsDarkpools = 77,

    /// <summary>
    /// Т+: Облигации (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsTplusEur = 207,

    /// <summary>
    /// Крупные пакеты – Облигации (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsDarkpoolsUsd = 167,

    /// <summary>
    /// Т+: Облигации (CNY) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsTplusCny = 245,

    /// <summary>
    /// Аукцион: адресные заявки
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    StockBondsAuctPact = 257,

    /// <summary>
    /// Т+: РПС с ЦК - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmTplus = 59,

    /// <summary>
    /// РПС (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmUsd = 74,

    /// <summary>
    /// РПС - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdm = 8,

    /// <summary>
    /// РПС: В валюте - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmCurrency = 106,

    /// <summary>
    /// РПС: Размещение - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmIssuance = 107,

    /// <summary>
    /// РПС: Выкуп - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmBuyback = 108,

    /// <summary>
    /// РПС: Выкуп (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmBuybackEur = 121,

    /// <summary>
    /// Анонимный РПС - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmAnonymous = 126,

    /// <summary>
    /// Анонимный РПС (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmAnonymousUsd = 203,

    /// <summary>
    /// Анонимный РПС (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmAnonymousEur = 205,

    /// <summary>
    /// Т+: РПС с ЦК (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmTplusUsd = 73,

    /// <summary>
    /// РПС: Выкуп (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmBuybackUsd = 124,

    /// <summary>
    /// РПС с ЦК: Облигации (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmCcpBondsEur = 209,

    /// <summary>
    /// РПС (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmEur = 160,

    /// <summary>
    /// Т+: РПС с ЦК (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmTplusEur = 163,

    /// <summary>
    /// РПС с ЦК: Облигации - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmCcpBonds = 282,

    /// <summary>
    /// РПС с ЦК: Облигации (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmCcpBondsUsd = 283,

    /// <summary>
    /// РПС: Облигации - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmBonds = 284,

    /// <summary>
    /// РПС: Облигации (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmBondsUsd = 285,

    /// <summary>
    /// РПС: Облигации (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmBondsEur = 286,

    /// <summary>
    /// РПС: Облигации (CNY) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmBondsCny = 247,

    /// <summary>
    /// РПС с ЦК: Облигации (CNY) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmCcpBondsCny = 249,

    /// <summary>
    /// ЦК - РПС - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StockNdmCc = 32,

    /// <summary>
    /// Внебиржевые сделки
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Otc"/>. 
    /// </para> 
    /// </summary>
    StockOtc = 71,

    /// <summary>
    /// РЕПО с ЦК 1 день (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpDUsd = 92,

    /// <summary>
    /// РЕПО с ЦК 1 день (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpDEur = 93,

    /// <summary>
    /// РЕПО с ЦК 7 дней (RUB) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpW = 76,

    /// <summary>
    /// РЕПО с ЦК 7 дней (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpWUsd = 78,

    /// <summary>
    /// РЕПО с ЦК 7 дней (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpWEur = 79,

    /// <summary>
    /// РЕПО с ЦК 1 день (RUB) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcp = 50,

    /// <summary>
    /// РЕПО с ЦК 1 мес.(RUB) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpM = 142,

    /// <summary>
    /// РЕПО с ЦК 1 мес. (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpMUsd = 143,

    /// <summary>
    /// РЕПО с ЦК 1 мес. (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpMEur = 144,

    /// <summary>
    /// РЕПО с ЦК 3 мес. (RUB) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcp3M = 145,

    /// <summary>
    /// РЕПО с ЦК 3 мес. (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcp3MUsd = 146,

    /// <summary>
    /// РЕПО с ЦК 3 мес. (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcp3MEur = 147,

    /// <summary>
    /// РЕПО с ЦК: Урегулирование - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpLiq = 148,

    /// <summary>
    /// РЕПО с ЦК 1 день (CNY) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpDCny = 152,

    /// <summary>
    /// РЕПО с ЦК (CNY) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpNdmCny = 153,

    /// <summary>
    /// РЕПО с ЦК (RUB) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpNdm = 65,

    /// <summary>
    /// РЕПО с ЦК (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpNdmUsd = 91,

    /// <summary>
    /// РЕПО с ЦК (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpNdmEur = 96,

    /// <summary>
    /// Аукцион с ЦК 1 день - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFkD = 169,

    /// <summary>
    /// Аукцион с ЦК 1 неделя - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFk2 = 171,

    /// <summary>
    /// Аукцион с ЦК 2 недели - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFk2W = 173,

    /// <summary>
    /// Аукцион с ЦК 5 недель - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFk5W = 281,

    /// <summary>
    /// Аукцион с ЦК 1 месяц - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFkM = 175,

    /// <summary>
    /// Аукцион с ЦК 2 месяца - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFk2M = 177,

    /// <summary>
    /// Аукцион с ЦК 3 месяца - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFk3M = 179,

    /// <summary>
    /// Аукцион с ЦК 6 месяцев - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFk6 = 181,

    /// <summary>
    /// Аукцион с ЦК 1 год - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFk1Y = 183,

    /// <summary>
    /// Аукцион РЕПО с ЦК 1 день - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFrRepo1D = 288,

    /// <summary>
    /// Аукцион РЕПО с ЦК 1 неделя - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFrRepo1W = 289,

    /// <summary>
    /// Аукцион РЕПО с ЦК 2 недели - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFrRepo2W = 296,

    /// <summary>
    /// Аукцион РЕПО с ЦК 5 недель - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFrRepo5W = 297,

    /// <summary>
    /// Аукцион РЕПО с ЦК 1 месяц - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFrRepo1M = 290,

    /// <summary>
    /// Аукцион РЕПО с ЦК 3 месяца - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Ccp"/>. 
    /// </para> 
    /// </summary>
    StockCcpFrRepo3M = 291,

    /// <summary>
    /// Депозиты с ЦК - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Deposit"/>. 
    /// </para> 
    /// </summary>
    StockDepositOrder = 97,

    /// <summary>
    /// Депозиты с ЦК - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Deposit"/>. 
    /// </para> 
    /// </summary>
    StockDepositOffOrder = 98,

    /// <summary>
    /// Депозиты с ЦК (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Deposit"/>. 
    /// </para> 
    /// </summary>
    StockDepositOffOrderUsd = 109,

    /// <summary>
    /// Депозиты с ЦК (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Deposit"/>. 
    /// </para> 
    /// </summary>
    StockDepositOffOrderEur = 136,

    /// <summary>
    /// Депозиты с ЦК (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Deposit"/>. 
    /// </para> 
    /// </summary>
    StockDepositOrderUsd = 110,

    /// <summary>
    /// Депозиты с ЦК (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Deposit"/>. 
    /// </para> 
    /// </summary>
    StockDepositOrderEur = 137,

    /// <summary>
    /// Депозиты с ЦК - Аукцион
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Deposit"/>. 
    /// </para> 
    /// </summary>
    StockDepositCloseAuct = 185,

    /// <summary>
    /// РЕПО-М - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Repo"/>. 
    /// </para> 
    /// </summary>
    StockRepoInterdealerM = 201,

    /// <summary>
    /// РЕПО с акциями - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Repo"/>. 
    /// </para> 
    /// </summary>
    StockSharesRepo = 1,

    /// <summary>
    /// Междилерское РЕПО (RUB) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Repo"/>. 
    /// </para> 
    /// </summary>
    StockRepoInterdealerRub = 95,

    /// <summary>
    /// Междилерское РЕПО (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Repo"/>. 
    /// </para> 
    /// </summary>
    StockRepoInterdealerUsd = 94,

    /// <summary>
    /// Междилерское РЕПО (EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Repo"/>. 
    /// </para> 
    /// </summary>
    StockRepoInterdealerEur = 90,

    /// <summary>
    /// РЕПО с облигациями - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Repo"/>. 
    /// </para> 
    /// </summary>
    StockBondRepo = 2,

    /// <summary>
    /// ЦК - РЕПО - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Repo"/>. 
    /// </para> 
    /// </summary>
    StockRepoCc = 31,

    /// <summary>
    /// Т+: Для квал. инвесторов - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Qnv"/>. 
    /// </para> 
    /// </summary>
    StockQnvTplus = 63,

    /// <summary>
    /// Т0: Квал. инвесторы - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Qnv"/>. 
    /// </para> 
    /// </summary>
    StockQnvMain = 60,

    /// <summary>
    /// РПС: Для квал. инвесторов - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Qnv"/>. 
    /// </para> 
    /// </summary>
    StockQnvNdm = 61,

    /// <summary>
    /// РПС с ЦК: Для квал. инвесторов - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Qnv"/>. 
    /// </para> 
    /// </summary>
    StockQnvNdmTplus = 64,

    /// <summary>
    /// РЕПО: Для квал. инвесторов - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Qnv"/>. 
    /// </para> 
    /// </summary>
    StockQnvRepo = 62,

    /// <summary>
    /// Т+: Для квал. инвесторов (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Qnv"/>. 
    /// </para> 
    /// </summary>
    StockQnvTplusUsd = 87,

    /// <summary>
    /// Безадресные сделки с ЦК
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Mamc"/>. 
    /// </para> 
    /// </summary>
    StockMamcLiq = 120,

    /// <summary>
    /// Т+ Ин.Акции и ДР - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.ForeignShares"/>. 
    /// </para> 
    /// </summary>
    StockForeignShares = 265,

    /// <summary>
    /// Т+: Ин.Акции и ДР (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.ForeignShares"/>. 
    /// </para> 
    /// </summary>
    StockForeignsharesTplusUsd = 292,

    /// <summary>
    /// Т+: РПС с ЦК: Ин.Акции и ДР (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.ForeignNdm"/>. 
    /// </para> 
    /// </summary>
    StockForeignndmCcpUsd = 293,

    /// <summary>
    /// РПС: Ин.Акции (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.ForeignNdm"/>. 
    /// </para> 
    /// </summary>
    StockForeignndmUsd = 294,

    /// <summary>
    /// РПС с ЦК: Ин.Акции и ДР - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.ForeignNdm"/>. 
    /// </para> 
    /// </summary>
    StockForeignCcp = 267,

    /// <summary>
    /// РПС: Ин.Акции - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.ForeignNdm"/>. 
    /// </para> 
    /// </summary>
    StockForeignNdm = 269,

    /// <summary>
    /// MOEX Board
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Moexboard"/>. 
    /// </para> 
    /// </summary>
    StockMoexboard = 72,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 день - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccD = 86,

    /// <summary>
    /// РЕПО с ЦК с КСУ 7 дн. - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccW = 83,

    /// <summary>
    /// РЕПО с ЦК с КСУ 14 дн. - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc2W = 80,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 месяц - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccM = 84,

    /// <summary>
    /// РЕПО с ЦК с КСУ 2 месяца - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc2M = 81,

    /// <summary>
    /// РЕПО с ЦК с КСУ 3 месяца - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc3M = 85,

    /// <summary>
    /// РЕПО с ЦК с КСУ 6 мес. - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc6M = 103,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 год - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc1Y = 102,

    /// <summary>
    /// РЕПО с ЦК с КСУ - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccNdm = 82,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 день (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccDUsd = 111,

    /// <summary>
    /// РЕПО с ЦК с КСУ 7 дн. (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccWUsd = 112,

    /// <summary>
    /// РЕПО с ЦК с КСУ 14 дн. (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc2WUsd = 113,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 месяц (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccMUsd = 114,

    /// <summary>
    /// РЕПО с ЦК с КСУ 2 месяца (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc2MUsd = 115,

    /// <summary>
    /// РЕПО с ЦК с КСУ 3 месяца (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc3MUsd = 116,

    /// <summary>
    /// РЕПО с ЦК с КСУ 6 месяцев (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc6MUsd = 117,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 год (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc1YUsd = 118,

    /// <summary>
    /// РЕПО с ЦК с КСУ (USD) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccNdmUsd = 119,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 день (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccDEur = 127,

    /// <summary>
    /// РЕПО с ЦК с КСУ 7 дн. (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccWEur = 128,

    /// <summary>
    /// РЕПО с ЦК с КСУ 14 дн. (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc2WEur = 129,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 месяц (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccMEur = 130,

    /// <summary>
    /// РЕПО с ЦК с КСУ 2 месяца (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc2MEur = 131,

    /// <summary>
    /// РЕПО с ЦК с КСУ 3 месяца (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc3MEur = 132,

    /// <summary>
    /// РЕПО с ЦК с КСУ 6 месяцев (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc6MEur = 133,

    /// <summary>
    /// РЕПО с ЦК с КСУ 1 год (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGcc1YEur = 134,

    /// <summary>
    /// РЕПО с ЦК с КСУ адресн.(EUR) - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockGccNdmEur = 135,

    /// <summary>
    /// РЕПО с ЦК с КСУ 9 месяцев - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockCcp9M = 187,

    /// <summary>
    /// РЕПО с ЦК с КСУ 9 мес. (USD) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockCcp9MUsd = 189,

    /// <summary>
    /// РЕПО с ЦК с КСУ 9 мес. (EUR) - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Gcc"/>. 
    /// </para> 
    /// </summary>
    StockCcp9MEur = 191,

    /// <summary>
    /// Кредиты RUB - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Credit"/>. 
    /// </para> 
    /// </summary>
    StockCreditRub = 275,

    /// <summary>
    /// Кредиты USD - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Credit"/>. 
    /// </para> 
    /// </summary>
    StockCreditUsd = 277,

    /// <summary>
    /// Кредиты EUR - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Credit"/>. 
    /// </para> 
    /// </summary>
    StockCreditEur = 279,

    /// <summary>
    /// Standard - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Standard"/>. 
    /// </para> 
    /// </summary>
    StockStandard = 36,

    /// <summary>
    /// Standard - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Standard"/>. 
    /// </para> 
    /// </summary>
    StandardNdm = 41,

    /// <summary>
    /// Standard: РЕПО - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Standard"/>. 
    /// </para> 
    /// </summary>
    StockStandardRepo = 40,

    /// <summary>
    /// Classica - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Classica"/>. 
    /// </para> 
    /// </summary>
    StockClassica = 43,

    /// <summary>
    /// Classica - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Stock"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StockMarket.Classica"/>. 
    /// </para> 
    /// </summary>
    StockClassicaNdm = 44,

    /// <summary>
    /// Индексы ГКО/ОФЗ
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.State"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StateMarket.Index"/>. 
    /// </para> 
    /// </summary>
    StateIndex = 12,

    /// <summary>
    /// Основной режим
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.State"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StateMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    State = 10,

    /// <summary>
    /// Сделки междилерского РЕПО
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.State"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StateMarket.Repo"/>. 
    /// </para> 
    /// </summary>
    DealerDealer = 3,

    /// <summary>
    /// Внесистемные сделки
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.State"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="StateMarket.Ndm"/>. 
    /// </para> 
    /// </summary>
    StateNdm = 11,

    /// <summary>
    /// Бивалютная корзина
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Basket"/>. 
    /// </para> 
    /// </summary>
    BKT = 26,

    /// <summary>
    /// Системные сделки - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    Currency = 13,

    /// <summary>
    /// Внесистемные сделки - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    CurrencyNdm = 46,

    /// <summary>
    /// Внесистемные сделки урегулирования - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    CurrencySeltLicu = 151,

    /// <summary>
    /// Фиксинг системный - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    CurrencyFixing = 100,

    /// <summary>
    /// Фиксинг внесистемный - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    CurrencyFixingNdm = 101,

    /// <summary>
    /// Системные средневзвешенные - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    CurrencySeltWaps = 149,

    /// <summary>
    /// Внесистемные средневзвешенные - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    CurrencySeltWapn = 150,

    /// <summary>
    /// Аукцион ЦБР - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    CurrencySeltCbr = 70,

    /// <summary>
    /// Поставка
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Selt"/>. 
    /// </para> 
    /// </summary>
    CurrencySeltSettle = 140,

    /// <summary>
    /// Системные фьючерсные контракты  - безадрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Futures"/>. 
    /// </para> 
    /// </summary>
    CurrencyFutures = 88,

    /// <summary>
    /// Внесистемные фьючерсные контракты - адрес.
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Futures"/>. 
    /// </para> 
    /// </summary>
    CurrencyFuturesNdm = 89,

    /// <summary>
    /// Валютный фиксинг
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Index"/>. 
    /// </para> 
    /// </summary>
    CurrencyIndex = 165,

    /// <summary>
    /// Рынок OTC
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Otc"/>. 
    /// </para> 
    /// </summary>
    CurrencyOtcLiquidity = 261,

    /// <summary>
    /// Рынок OTC крупные сделки
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Currency"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CurrencyMarket.Otc"/>. 
    /// </para> 
    /// </summary>
    CurrencyOtcDarkpools = 263,

    /// <summary>
    /// Срочные инструменты
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="FuturesMarket.Main"/>. 
    /// </para> 
    /// </summary>
    Futures = 15,

    /// <summary>
    /// Фьючерсы
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="FuturesMarket.Forts"/>. 
    /// </para> 
    /// </summary>
    FuturesForts = 45,

    /// <summary>
    /// Опционы
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="FuturesMarket.Options"/>. 
    /// </para> 
    /// </summary>
    FuturesOptions = 35,

    /// <summary>
    /// Фьючерсы IQS
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="FuturesMarket.Fortsiqs"/>. 
    /// </para> 
    /// </summary>
    FuturesFortsiqs = 138,

    /// <summary>
    /// Опционы IQS
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Futures"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="FuturesMarket.Optionsiqs"/>. 
    /// </para> 
    /// </summary>
    FuturesOptionsiqs = 139,

    /// <summary>
    /// Стандартные контракты АО НТБ
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Commodity"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="CommodityMarket.Futures"/>. 
    /// </para> 
    /// </summary>
    CommodityFutures = 20,

    /// <summary>
    /// Интервенции по продаже зерна
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Interventions"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="InterventionsMarket.Grain"/>. 
    /// </para> 
    /// </summary>
    InterventionsGrain = 24,

    /// <summary>
    /// ОТС-система: облигации
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Offboard"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="OffboardMarket.Bonds"/>. 
    /// </para> 
    /// </summary>
    OffboardBondAll = 141,

    /// <summary>
    /// Агро: Сахар
    /// <para> 
    /// Принадлежит к следующей торговой системе <see cref="Engine.Agro"/>. 
    /// </para> 
    /// <para> 
    /// Принадлежит к следующему рынку торговой системы <see cref="AgroMarket.Sugar"/>. 
    /// </para> 
    /// </summary>
    AgroSugarAll = 271,
}
