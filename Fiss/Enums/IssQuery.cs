using System.ComponentModel;

namespace Fiss.Enums;

public enum IssQuery
{
    /// <summary>
    ///     /statistics/engines/stock/markets/bonds/bondization/[security]
    /// </summary>
    [Description("statistics/engines/stock/markets/bonds/bondization/[security]")]
    Bondization = -1,

    /// <summary>
    ///     /securities
    /// </summary>
    [Description("securities")] ListOfSecurities = 5,

    /// <summary>
    ///     /securities/[security]
    /// </summary>
    [Description("securities/[security]")] SecuritiesSpecification = 13,

    /// <summary>
    ///     /securities/[security]/indices
    /// </summary>
    [Description("securities/[security]/indices")]
    IndexesIncludeSecurities = 160,

    /// <summary>
    ///     /turnovers
    /// </summary>
    [Description("turnovers")] ConsolidatedTurnovers = 24,

    /// <summary>
    ///     /engines
    /// </summary>
    [Description("engines")] ListOfEngines = 40,

    /// <summary>
    ///     securities/[security]/aggregates
    /// </summary>
    [Description("securities/[security]/aggregates")]
    Ssa = 214,

    /// <summary>
    ///     engines/[engine]/markets/[market]/secstats
    /// </summary>
    [Description("engines/[engine]/markets/[market]/secstats")]
    Eemms = 823,

    /// <summary>
    ///     turnovers/columns
    /// </summary>
    [Description("turnovers/columns")] Tc = 100,

    /// <summary>
    ///     engines/[engine]/turnovers
    /// </summary>
    [Description("engines/[engine]/turnovers")]
    Eet = 95,

    /// <summary>
    ///     engines/[engine]/markets/[market]/turnovers
    /// </summary>
    [Description("engines/[engine]/markets/[market]/turnovers")]
    Eemmt = 96,

    /// <summary>
    ///     engines/[engine]/markets/zcyc
    /// </summary>
    [Description("engines/[engine]/markets/zcyc")]
    Eemz = 89,

    /// <summary>
    ///     engines/[engine]/zcyc
    /// </summary>
    [Description("engines/[engine]/zcyc")] Eez = 634,

    /// <summary>
    ///     index
    /// </summary>
    [Description("index")] Index = 28,

    /// <summary>
    ///     history/otc/providers/nsd/markets
    /// </summary>
    [Description("history/otc/providers/nsd/markets")]
    Hopnm = 833,

    /// <summary>
    ///     history/otc/providers/nsd/markets/[market]/daily
    /// </summary>
    [Description("history/otc/providers/nsd/markets/[market]/daily")]
    Hopnmmd = 835,

    /// <summary>
    ///     history/otc/providers/nsd/markets/[market]/monthly
    /// </summary>
    [Description("history/otc/providers/nsd/markets/[market]/monthly")]
    Hopnmmm = 837,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/.*?listing/columns
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/.*?listing/columns")]
    Heemmlc = 117,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/listing
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/listing")]
    Heemml = 118,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boards/[board]/listing
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boards/[board]/listing")]
    Heemmbblisting = 119,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/listing
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/listing")]
    Heemmboardgroupsblisting = 120,

    /// <summary>
    ///     engines/[engine]
    /// </summary>
    [Description("engines/[engine]")] Ee = 41,

    /// <summary>
    ///     engines/[engine]/markets/[market]/.*?orderbook/columns
    /// </summary>
    [Description("engines/[engine]/markets/[market]/.*?orderbook/columns")]
    Eemmoc = 98,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/sessions
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/sessions")]
    Heemms = 811,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/sessions/[session]/securities
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/sessions/[session]/securities")]
    Heemmsss = 813,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/sessions/[session]/securities/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/sessions/[session]/securities/[security]")]
    Heemmssss = 817,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/session/[session]/boardgroups/[boardgroup]/securities
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/session/[session]/boardgroups/[boardgroup]/securities")]
    Heemmssbbs = 825,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/sessions/[session]/boardgroups/[boardgroup]/securities/[security]
    /// </summary>
    [Description(
        "history/engines/[engine]/markets/[market]/sessions/[session]/boardgroups/[boardgroup]/securities/[security]")]
    Heemmssbbss = 819,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/sessions/[session]/boards/[board]/securities
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/sessions/[session]/boards/[board]/securities")]
    Heemmssbbsecurities = 821,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/sessions/[session]/boards/[board]/securities/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/sessions/[session]/boards/[board]/securities/[security]")]
    Heemmssbbssecurity = 815,

    /// <summary>
    ///     engines/[engine]/markets/[market]/.*?securities/columns
    /// </summary>
    [Description("engines/[engine]/markets/[market]/.*?securities/columns")]
    Eemmsc = 99,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/.*?securities/columns
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/.*?securities/columns")]
    Heemmsc = 101,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/.*?[securities]/columns
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/.*?[securities]/columns")]
    Heemmscolumns = 789,

    /// <summary>
    ///     engines/[engine]/markets
    /// </summary>
    [Description("engines/[engine]/markets")]
    Eem = 42,

    /// <summary>
    ///     engines/[engine]/markets/[market]/.*?trades/columns
    /// </summary>
    [Description("engines/[engine]/markets/[market]/.*?trades/columns")]
    Eemmtc = 97,

    /// <summary>
    ///     engines/[engine]/markets/[market]
    /// </summary>
    [Description("engines/[engine]/markets/[market]")]
    Eemm = 44,

    /// <summary>
    ///     engines/[engine]/markets/[market]/securities
    /// </summary>
    [Description("engines/[engine]/markets/[market]/securities")]
    ListSecuritiesInMarket = 33,

    /// <summary>
    ///     engines/[engine]/markets/[market]/securities/[security]
    /// </summary>
    [Description("engines/[engine]/markets/[market]/securities/[security]")]
    Eemmss = 52,

    /// <summary>
    ///     statistics/engines/stock/securitieslisting
    /// </summary>
    [Description("statistics/engines/stock/securitieslisting")]
    Sess = 841,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics/columns
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics/columns")]
    Sesmiac = 205,

    /// <summary>
    ///     engines/[engine]/markets/[market]/securities/[security]/trades
    /// </summary>
    [Description("engines/[engine]/markets/[market]/securities/[security]/trades")]
    Eemmsst = 55,

    /// <summary>
    ///     statistics/engines/stock/markets/index/bulletins
    /// </summary>
    [Description("statistics/engines/stock/markets/index/bulletins")]
    Sesmib = 839,

    /// <summary>
    ///     statistics/engines/stock/markets/index/rusfar
    /// </summary>
    [Description("statistics/engines/stock/markets/index/rusfar")]
    Sesmir = 843,

    /// <summary>
    ///     engines/[engine]/markets/[market]/securities/[security]/orderbook
    /// </summary>
    [Description("engines/[engine]/markets/[market]/securities/[security]/orderbook")]
    Eemmsso = 54,

    /// <summary>
    ///     engines/[engine]/markets/[market]/trades
    /// </summary>
    [Description("engines/[engine]/markets/[market]/trades")]
    Eemmtrades = 35,

    /// <summary>
    ///     engines/[engine]/markets/[market]/orderbook
    /// </summary>
    [Description("engines/[engine]/markets/[market]/orderbook")]
    Eemmo = 36,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards")]
    Eemmb = 43,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]")]
    Eemmbb = 49,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]/securities
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]/securities")]
    Eemmbbs = 32,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]/securities/[security]
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]/securities/[security]")]
    Eemmbbss = 53,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]/securities/[security]/trades
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]/securities/[security]/trades")]
    Eemmbbsst = 56,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]/securities/[security]/orderbook
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]/securities/[security]/orderbook")]
    Eemmbbsso = 57,

    /// <summary>
    ///     engines/[engine]/markets/[market]/securities/[security]/candles
    /// </summary>
    [Description("engines/[engine]/markets/[market]/securities/[security]/candles")]
    Eemmssc = 155,

    /// <summary>
    ///     engines/[engine]/markets/[market]/securities/[security]/candleborders
    /// </summary>
    [Description("engines/[engine]/markets/[market]/securities/[security]/candleborders")]
    Eemmsscandleborders = 156,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/candleborders
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/candleborders")]
    Eemmbbssc = 158,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/candles
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/candles")]
    Eemmboardgroupsbsscandles = 157,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]/securities/[security]/candles
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]/securities/[security]/candles")]
    Eemmbbsscandles = 46,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]/securities/[security]/candleborders
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]/securities/[security]/candleborders")]
    Eemmbbsscandleborders = 48,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]/trades
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]/trades")]
    Eemmbbt = 34,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boards/[board]/orderbook
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boards/[board]/orderbook")]
    Eemmbbo = 39,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups")]
    Eemmboardgroups = 45,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]")]
    Eemmbboardgroup = 50,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities")]
    Eemmbbsecurities = 29,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]")]
    Eemmbbssecurity = 58,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/trades
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/trades")]
    Eemmbbsstrades = 60,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/orderbook
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/orderbook")]
    Eemmbbssorderbook = 59,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]/trades
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]/trades")]
    Eemmbbtrades = 37,

    /// <summary>
    ///     engines/[engine]/markets/[market]/boardgroups/[boardgroup]/orderbook
    /// </summary>
    [Description("engines/[engine]/markets/[market]/boardgroups/[boardgroup]/orderbook")]
    Eemmbborderbook = 38,

    /// <summary>
    ///     history/engines/stock/markets/shares/securities/changeover
    /// </summary>
    [Description("history/engines/stock/markets/shares/securities/changeover")]
    Hesmssc = 123,

    /// <summary>
    ///     history/engines/stock/zcyc
    /// </summary>
    [Description("history/engines/stock/zcyc")]
    Hesz = 783,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/securities
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/securities")]
    Heemmsecurities = 62,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/yields
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/yields")]
    Heemmy = 791,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/dates
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/dates")]
    Heemmd = 83,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/securities/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/securities/[security]")]
    Heemmss = 63,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/yields/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/yields/[security]")]
    Heemmys = 793,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/securities/[security]/dates
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/securities/[security]/dates")]
    Heemmssd = 61,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boards/[board]/dates
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boards/[board]/dates")]
    Heemmbbd = 26,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boards/[board]/securities
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boards/[board]/securities")]
    Heemmbbs = 64,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boards/[board]/yields
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boards/[board]/yields")]
    Heemmbby = 795,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boards/[board]/securities/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boards/[board]/securities/[security]")]
    Heemmbbss = 65,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boards/[board]/yields/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boards/[board]/yields/[security]")]
    Heemmbbys = 797,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boards/[board]/securities/[security]/dates
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boards/[board]/securities/[security]/dates")]
    Heemmbbssd = 66,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/dates
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/dates")]
    Heemmbbdates = 51,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities")]
    Heemmbbsecurities = 152,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]")]
    DarkpoolAuctionHistoryDateRange = 153,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities")]
    HeemmbbsByDate = 67,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/yields
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/yields")]
    Heemmbbyields = 799,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]")]
    Heemmbbssecurity = 68,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/yields/[security]
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/yields/[security]")]
    Heemmbbysecurity = 801,

    /// <summary>
    ///     history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/dates
    /// </summary>
    [Description("history/engines/[engine]/markets/[market]/boardgroups/[boardgroup]/securities/[security]/dates")]
    Heemmbbssdates = 69,

    /// <summary>
    ///     archives/engines/[engine]/markets/[market]/[datatype]/years
    /// </summary>
    [Description("archives/engines/[engine]/markets/[market]/[datatype]/years")]
    Aeemmdy = 114,

    /// <summary>
    ///     archives/engines/[engine]/markets/[market]/[datatype]/[period]
    /// </summary>
    [Description("archives/engines/[engine]/markets/[market]/[datatype]/[period]")]
    Aeemmdp = 116,

    /// <summary>
    ///     archives/engines/[engine]/markets/[market]/[datatype]/years/[year]/months
    /// </summary>
    [Description("archives/engines/[engine]/markets/[market]/[datatype]/years/[year]/months")]
    Aeemmdyym = 115,

    /// <summary>
    ///     securitygroups
    /// </summary>
    [Description("securitygroups")] Securitygroups = 127,

    /// <summary>
    ///     securitygroups/[securitygroup]
    /// </summary>
    [Description("securitygroups/[securitygroup]")]
    Ssecuritygroup = 128,

    /// <summary>
    ///     securitygroups/[securitygroup]/collections
    /// </summary>
    [Description("securitygroups/[securitygroup]/collections")]
    Ssc = 129,

    /// <summary>
    ///     securitygroups/[securitygroup]/collections/[collection]
    /// </summary>
    [Description("securitygroups/[securitygroup]/collections/[collection]")]
    Sscc = 130,

    /// <summary>
    ///     securitygroups/[securitygroup]/collections/[collection]/securities
    /// </summary>
    [Description("securitygroups/[securitygroup]/collections/[collection]/securities")]
    Ssccs = 131,

    /// <summary>
    ///     securitytypes
    /// </summary>
    [Description("securitytypes")] Securitytypes = 132,

    /// <summary>
    ///     securitytypes/[securitytype]
    /// </summary>
    [Description("securitytypes/[securitytype]")]
    Ssecuritytype = 133,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets")]
    Sefmoa = 873,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/[asset]
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/[asset]")]
    Sefmoaa = 877,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/[asset]/volumes
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/[asset]/volumes")]
    Sefmoaav = 879,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/[asset]/optionboard
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/[asset]/optionboard")]
    Sefmoaaoptionboard = 881,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/[asset]/openpositions
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/[asset]/openpositions")]
    Sefmoaaopenpositions = 883,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/[asset]/turnovers
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/[asset]/turnovers")]
    Sefmoaat = 885,

    /// <summary>
    ///     analyticalproducts/curves/securities
    /// </summary>
    [Description("analyticalproducts/curves/securities")]
    Acs = 859,

    /// <summary>
    ///     analyticalproducts/curves/securities/[security]
    /// </summary>
    [Description("analyticalproducts/curves/securities/[security]")]
    Acss = 861,

    /// <summary>
    ///     statistics/engines/stock/markets/shares/correlations
    /// </summary>
    [Description("statistics/engines/stock/markets/shares/correlations")]
    Sesmsc = 172,

    /// <summary>
    ///     statistics/engines/currency/markets/selt/rates
    /// </summary>
    [Description("statistics/engines/currency/markets/selt/rates")]
    Secmsr = 168,

    /// <summary>
    ///     statistics/engines/stock/splits
    /// </summary>
    [Description("statistics/engines/stock/splits")]
    Sessplits = 758,

    /// <summary>
    ///     statistics/engines/stock/splits/[security]
    /// </summary>
    [Description("statistics/engines/stock/splits/[security]")]
    Sesss = 759,

    /// <summary>
    ///     statistics/engines/state/markets/repo/mirp
    /// </summary>
    [Description("statistics/engines/state/markets/repo/mirp")]
    Sesmrm = 165,

    /// <summary>
    ///     statistics/engines/state/markets/repo/dealers
    /// </summary>
    [Description("statistics/engines/state/markets/repo/dealers")]
    Sesmrd = 166,

    /// <summary>
    ///     statistics/engines/state/markets/repo/cboper
    /// </summary>
    [Description("statistics/engines/state/markets/repo/cboper")]
    Sesmrc = 169,

    /// <summary>
    ///     statistics/engines/stock/deviationcoeffs
    /// </summary>
    [Description("statistics/engines/stock/deviationcoeffs")]
    Sesd = 134,

    /// <summary>
    ///     statistics/engines/stock/quotedsecurities
    /// </summary>
    [Description("statistics/engines/stock/quotedsecurities")]
    Sesq = 171,

    /// <summary>
    ///     statistics/engines/stock/currentprices
    /// </summary>
    [Description("statistics/engines/stock/currentprices")]
    Sesc = 649,

    /// <summary>
    ///     sitenews
    /// </summary>
    [Description("sitenews")] Sitenews = 191,

    /// <summary>
    ///     sitenews/[news_id]
    /// </summary>
    [Description("sitenews/[news_id]")] Sn = 192,

    /// <summary>
    ///     events
    /// </summary>
    [Description("events")] Events = 193,

    /// <summary>
    ///     events/[event_id]
    /// </summary>
    [Description("events/[event_id]")] Eei = 194,

    /// <summary>
    ///     statistics/engines/stock/markets/bonds/aggregates
    /// </summary>
    [Description("statistics/engines/stock/markets/bonds/aggregates")]
    Sesmba = 195,

    /// <summary>
    ///     statistics/engines/stock/markets/bonds/aggregates/columns
    /// </summary>
    [Description("statistics/engines/stock/markets/bonds/aggregates/columns")]
    Sesmbac = 196,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics")]
    Sesmia = 146,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics/[indexid]
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics/[indexid]")]
    Sesmiai = 147,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics/[indexid]/tickers
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics/[indexid]/tickers")]
    Sesmiait = 148,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics/[indexid]/tickers/[ticker]
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics/[indexid]/tickers/[ticker]")]
    Sesmiaitt = 149,

    /// <summary>
    ///     statistics/engines/stock/capitalization
    /// </summary>
    [Description("statistics/engines/stock/capitalization")]
    Sescapital = 159,

    /// <summary>
    ///     history/engines/stock/totals/boards
    /// </summary>
    [Description("history/engines/stock/totals/boards")]
    Hestb = 161,

    /// <summary>
    ///     history/engines/stock/totals/securities
    /// </summary>
    [Description("history/engines/stock/totals/securities")]
    Hests = 162,

    /// <summary>
    ///     history/engines/stock/totals/boards/[board]/securities
    /// </summary>
    [Description("history/engines/stock/totals/boards/[board]/securities")]
    Hestbbs = 163,

    /// <summary>
    ///     history/engines/stock/totals/boards/[board]/securities/[security]
    /// </summary>
    [Description("history/engines/stock/totals/boards/[board]/securities/[security]")]
    Hestbbss = 164,

    /// <summary>
    ///     rms/engines/[engine]/objects/irr
    /// </summary>
    [Description("rms/engines/[engine]/objects/irr")]
    Reeoi = 764,

    /// <summary>
    ///     rms/engines/[engine]/objects/irr/filters
    /// </summary>
    [Description("rms/engines/[engine]/objects/irr/filters")]
    Reeoif = 766,

    /// <summary>
    ///     statistics/engines/state/rates
    /// </summary>
    [Description("statistics/engines/state/rates")]
    Sesr = 178,

    /// <summary>
    ///     statistics/engines/state/rates/columns
    /// </summary>
    [Description("statistics/engines/state/rates/columns")]
    Sesrc = 179,

    /// <summary>
    ///     statistics/engines/[engine]/derivatives/[report_name]
    /// </summary>
    [Description("statistics/engines/[engine]/derivatives/[report_name]")]
    Seedr = 219,

    /// <summary>
    ///     statistics/engines/[engine]/monthly/[report_name]
    /// </summary>
    [Description("statistics/engines/[engine]/monthly/[report_name]")]
    Seemr = 220,

    /// <summary>
    ///     statistics/engines/currency/markets/fixing/[security]
    /// </summary>
    [Description("statistics/engines/currency/markets/fixing/[security]")]
    Secmfs = 715,

    /// <summary>
    ///     statistics/engines/futures/markets/indicativerates/securities
    /// </summary>
    [Description("statistics/engines/futures/markets/indicativerates/securities")]
    Sefmis = 711,

    /// <summary>
    ///     statistics/engines/futures/markets/indicativerates/securities/[security]
    /// </summary>
    [Description("statistics/engines/futures/markets/indicativerates/securities/[security]")]
    Sefmiss = 712,

    /// <summary>
    ///     statistics/engines/currency/markets/fixing
    /// </summary>
    [Description("statistics/engines/currency/markets/fixing")]
    Secmf = 716,

    /// <summary>
    ///     statistics/engines/[engine]/markets/[market]
    /// </summary>
    [Description("statistics/engines/[engine]/markets/[market]")]
    Seemm = 771,

    /// <summary>
    ///     statistics/engines/[engine]/markets/[market]/securities
    /// </summary>
    [Description("statistics/engines/[engine]/markets/[market]/securities")]
    Seemms = 773,

    /// <summary>
    ///     statistics/engines/[engine]/markets/[market]/securities/[security]
    /// </summary>
    [Description("statistics/engines/[engine]/markets/[market]/securities/[security]")]
    Seemmss = 775,

    /// <summary>
    ///     analyticalproducts/netflow2/securities
    /// </summary>
    [Description("analyticalproducts/netflow2/securities")]
    Ans = 767,

    /// <summary>
    ///     analyticalproducts/netflow2/securities/[security]
    /// </summary>
    [Description("analyticalproducts/netflow2/securities/[security]")]
    Anss = 769,

    /// <summary>
    ///     analyticalproducts/futoi/securities
    /// </summary>
    [Description("analyticalproducts/futoi/securities")]
    Afs = 807,

    /// <summary>
    ///     analyticalproducts/futoi/securities/[security]
    /// </summary>
    [Description("analyticalproducts/futoi/securities/[security]")]
    Afss = 809
}