using System.ComponentModel;

namespace Fiss;

/// <summary>
///     Market trading modes
/// </summary>
public enum IssQuery : byte
{
    /// <summary>
    ///     Moscow exchange securities list
    /// </summary>
    [Description("securities")]
    Securities,

    /// <summary>
    ///     Get security specifications. Example: https://iss.moex.com/iss/securities/IMOEX.xml?lang=en
    /// </summary>
    [Description("securities/{0}")]
    SS,

    /// <summary>
    ///     securities/{0}/indices
    /// </summary>
    [Description("securities/{0}/indices")]
    SSI,

    /// <summary>
    ///     securities/{0}/aggregates
    /// </summary>
    [Description("securities/{0}/aggregates")]
    SSA,

    /// <summary>
    ///     engines/{0}/markets/{1}/secstats
    /// </summary>
    [Description("engines/{0}/markets/{1}/secstats")]
    EEMMS,

    /// <summary>
    ///     Get current turnover on all the markets.Example: https://iss.moex.com/iss/turnovers.xml?lang=en
    /// </summary>
    [Description("turnovers")]
    Turnovers,

    /// <summary>
    ///     Get the description of columns in requests for market/engine turnover.Example: https://iss.moex.com/iss/engines/stock/turnovers/columns.xml?lang=en
    /// </summary>
    [Description("turnovers/columns")]
    TC,

    /// <summary>
    ///     Get current turnover for a trading engine
    /// </summary>
    [Description("engines/{0}/turnovers")]
    EET,

    /// <summary>
    ///     Get current turnover for a market
    /// </summary>
    [Description("engines/{0}/markets/{1}/turnovers")]
    EEMMT,

    /// <summary>
    ///     Get data for the zero-coupon yield curve.(Calculations stopped at 2018-01-03)
    /// </summary>
    [Description("engines/{0}/markets/zcyc")]
    EEMZ,

    /// <summary>
    ///     engines/{0}/zcyc
    /// </summary>
    [Description("engines/{0}/zcyc")]
    EEZ,

    /// <summary>
    ///     Get initial ISS reference.Example: https://iss.moex.com/iss/index.xml?lang=en
    /// </summary>
    [Description("index")]
    Index,

    /// <summary>
    ///     history/otc/providers/nsd/markets
    /// </summary>
    [Description("history/otc/providers/nsd/markets")]
    HOPNM,

    /// <summary>
    ///     history/otc/providers/nsd/markets/{0}/daily
    /// </summary>
    [Description("history/otc/providers/nsd/markets/{0}/daily")]
    HOPNMMD,

    /// <summary>
    ///     history/otc/providers/nsd/markets/{0}/monthly
    /// </summary>
    [Description("history/otc/providers/nsd/markets/{0}/monthly")]
    HOPNMMM,

    /// <summary>
    ///     Get available trading systems. Example: https://iss.moex.com/iss/engines.xml?lang=en
    /// </summary>
    [Description("engines")]
    Engines,

    /// <summary>
    ///     Get the description of columns for listing requests
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/listing/columns")]
    HEEMMLC,

    /// <summary>
    ///     Get information on when securities were traded on which boards
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/listing")]
    HEEMML,

    /// <summary>
    ///     Get security listing information for a given board
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boards/{2}/listing")]
    HEEMMBBL,

    /// <summary>
    ///     Get security listing information for a given boardgroup
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/listing")]
    HistoryEEMMBBL,

    /// <summary>
    ///     Get description and availability time of a trading system.Example: https://iss.moex.com/iss/engines/stock.xml
    /// </summary>
    [Description("engines/{0}")]
    EE,

    /// <summary>
    ///     Get the description of columns in requests for market orderbooks.Example: https://iss.moex.com/iss/engines/stock/markets/shares/boardgroups/6/orderbook/columns.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/orderbook/columns")]
    EEMMOC,

    /// <summary>
    ///     Available sessions list in history.For stock market only.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/sessions")]
    HEEMMS,

    /// <summary>
    ///     Get trade results for all the securities on the specified market on the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/sessions/{2}/securities")]
    HEEMMSSS,

    /// <summary>
    ///     Get trade results for one security for the specified date range.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/sessions/{2}/securities/{3}")]
    HEEMMSSSS,

    /// <summary>
    ///     Get trade results for all the securities on the specified board group for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/session/{2}/boardgroups/{3}/securities")]
    HEEMMSSBBS,

    /// <summary>
    ///     Get trade results for the specified security on the specified board group for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/sessions/{2}/boardgroups/{3}/securities/{4}")]
    HEEMMSSBBSS,

    /// <summary>
    ///     Get trade results for all the securities on the specified board for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/sessions/{2}/boards/{3}/securities")]
    HistoryEEMMSSBBS,

    /// <summary>
    ///     Get trade results for the specified security on the specified board for the specified date interval.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/sessions/{2}/boards/{3}/securities/{4}")]
    HistoryEEMMSSBBSS,

    /// <summary>
    ///     Get the description of columns in requests for securities.Example: https://iss.moex.com/iss/engines/stock/markets/shares/securities/columns.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/securities/columns")]
    EEMMSC,

    /// <summary>
    ///     Get the description of columns in requests for security historical data.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/{2}/columns")]
    HEEMMSC,

    /// <summary>
    ///     Get the list of markets for the trading system.Example: https://iss.moex.com/iss/engines/stock/markets.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets")]
    EEM,

    /// <summary>
    ///     Get the description of columns in requests for market tradesExample: https://iss.moex.com/iss/engines/stock/markets/shares/trades/columns.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/trades/columns")]
    EEMMTC,

    /// <summary>
    ///     Get the list of boards, board groups and metadata for all the table fields returned by other requests.Example: https://iss.moex.com/iss/engines/stock/markets/shares.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}")]
    EEMM,

    /// <summary>
    ///     Get metadata and market data for all the securities on the specified market.Example: https://iss.moex.com/iss/engines/stock/markets/shares/securities.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/securities")]
    EnginesEMMS,

    /// <summary>
    ///     Get metadata and market data for the specified security on the specified market.Example: https://iss.moex.com/iss/engines/stock/markets/shares/securities/AFLT.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/securities/{2}")]
    EEMMSS,

    /// <summary>
    ///     statistics/engines/stock/securitieslisting
    /// </summary>
    [Description("statistics/engines/stock/securitieslisting")]
    SESS,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics/columns
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics/columns")]
    SESMIAC,

    /// <summary>
    ///     Get all trades with the specified security on the specified market.Example: https://iss.moex.com/iss/engines/stock/markets/shares/securities/AFLT/trades.xml
    /// </summary>
    [Description("engines/{0}/markets/{1}/securities/{2}/trades")]
    EEMMSST,

    /// <summary>
    ///     statistics/engines/stock/markets/index/bulletins
    /// </summary>
    [Description("statistics/engines/stock/markets/index/bulletins")]
    SESMIB,

    /// <summary>
    ///     statistics/engines/stock/markets/index/rusfar
    /// </summary>
    [Description("statistics/engines/stock/markets/index/rusfar")]
    SESMIR,

    /// <summary>
    ///     Get orderbook for the specified security on the specified market.Example: https://iss.moex.com/iss/engines/stock/markets/shares/securities/AFLT/orderbook.xml
    /// </summary>
    [Description("engines/{0}/markets/{1}/securities/{2}/orderbook")]
    EEMMSSO,

    /// <summary>
    ///     Get all trades from the specified market.Example: https://iss.moex.com/iss/engines/stock/markets/shares/trades.xml
    /// </summary>
    [Description("engines/{0}/markets/{1}/trades")]
    EnginesEMMT,

    /// <summary>
    ///     Get orderbooks for all the securities on the specified market.Example: https://iss.moex.com/iss/engines/stock/markets/shares/orderbook.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/orderbook")]
    EEMMO,

    /// <summary>
    ///     Get the list of boards on the specified market.Example: https://iss.moex.com/iss/engines/stock/markets/shares/boards.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards")]
    EEMMB,

    /// <summary>
    ///     Get description of the specified board.Example: https://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}")]
    EEMMBB,

    /// <summary>
    ///     Get metadata and market data for the specified security traded on the specified board.Example: https://iss.moex.com/iss/engines/stock/markets/shares/boards/TQBR/securities.xml?lang=en
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}/securities")]
    EEMMBBS,

    /// <summary>
    ///     Get data for the specified security on the specified board.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}/securities/{3}")]
    EEMMBBSS,

    /// <summary>
    ///     Get all trades with the specified security on the specified board.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}/securities/{3}/trades")]
    EEMMBBSST,

    /// <summary>
    ///     Get the best quotes for the specified security on the specified board.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}/securities/{3}/orderbook")]
    EEMMBBSSO,

    /// <summary>
    ///     Get data for candlestick charts for the specified security.
    /// </summary>
    [Description("engines/{0}/markets/{1}/securities/{2}/candles")]
    EEMMSSC,

    /// <summary>
    ///     engines/{0}/markets/{1}/securities/{2}/candleborders
    /// </summary>
    [Description("engines/{0}/markets/{1}/securities/{2}/candleborders")]
    EnginesEMMSSC,

    /// <summary>
    ///     engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}/candleborders
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}/candleborders")]
    EEMMBBSSC,

    /// <summary>
    ///     Get data for candlestick charts for the specified security on the specified group of boards.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}/candles")]
    EnginesEMMBBSSC,

    /// <summary>
    ///     Get data for candlestick charts for the specified security on the specified board.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}/securities/{3}/candles")]
    EnginesEngineMMBBSSC,

    /// <summary>
    ///     Get available intervals and dates for candlestick charts.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}/securities/{3}/candleborders")]
    EnginesEngineMarketsMBBSSC,

    /// <summary>
    ///     Get all trades from the specified board.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}/trades")]
    EEMMBBT,

    /// <summary>
    ///     Get the best quotes for the specified board.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boards/{2}/orderbook")]
    EEMMBBO,

    /// <summary>
    ///     Get the list of board groups
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups")]
    EnginesEMMB,

    /// <summary>
    ///     Get description of the board group
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}")]
    EnginesEMMBB,

    /// <summary>
    ///     Get the list of all securities traded on the specified board group.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}/securities")]
    EnginesEMMBBS,

    /// <summary>
    ///     Get metadata and market data for the specified security traded on the specified board group.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}")]
    EnginesEMMBBSS,

    /// <summary>
    ///     Get all trades for the specified security traded on the specified board group.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}/trades")]
    EnginesEMMBBSST,

    /// <summary>
    ///     Get the best quotes for the specified security traded on the specified board group.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}/orderbook")]
    EnginesEMMBBSSO,

    /// <summary>
    ///     Get all trades from the specified board group.
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}/trades")]
    EnginesEMMBBT,

    /// <summary>
    ///     Get the best quotes for the specified board group
    /// </summary>
    [Description("engines/{0}/markets/{1}/boardgroups/{2}/orderbook")]
    EnginesEMMBBO,

    /// <summary>
    ///     Security ID change log
    /// </summary>
    [Description("history/engines/stock/markets/shares/securities/changeover")]
    HESMSSC,

    /// <summary>
    ///     history/engines/stock/zcyc
    /// </summary>
    [Description("history/engines/stock/zcyc")]
    HESZ,

    /// <summary>
    ///     Get trade results for all the securities on the specified market on the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/securities")]
    HistoryEEMMS,

    /// <summary>
    ///     Get trade yields for all the securities on the specified board for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/yields")]
    HEEMMY,

    /// <summary>
    ///     Get dates for which history on the specified market is available.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/dates")]
    HEEMMD,

    /// <summary>
    ///     Get trade results for one security for the specified date range.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/securities/{2}")]
    HEEMMSS,

    /// <summary>
    ///     Get trade yields for one security for the specified date range.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/yields/{2}")]
    HEEMMYS,

    /// <summary>
    ///     Get dates for which history for the specified security on the specified market is available.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/securities/{2}/dates")]
    HEEMMSSD,

    /// <summary>
    ///     Get dates for which history for the board is available.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boards/{2}/dates")]
    HEEMMBBD,

    /// <summary>
    ///     Get trade results for all the securities on the specified board for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boards/{2}/securities")]
    HEEMMBBS,

    /// <summary>
    ///     Get trade yields for all the securities on the specified board for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boards/{2}/yields")]
    HEEMMBBY,

    /// <summary>
    ///     Get trade results for the specified security on the specified board for the specified date interval.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boards/{2}/securities/{3}")]
    HEEMMBBSS,

    /// <summary>
    ///     Get trade yields for the specified security on the specified board for the specified date interval.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boards/{2}/yields/{3}")]
    HEEMMBBYS,

    /// <summary>
    ///     Get dates for which history for the specified security on the specified board is available.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boards/{2}/securities/{3}/dates")]
    HEEMMBBSSD,

    /// <summary>
    ///     Get dates for which history for the specified board group is available.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/dates")]
    HistoryEEMMBBD,

    /// <summary>
    ///     history/engines/{0}/markets/{1}/boardgroups/{2}/securities
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/securities")]
    HistoryEEMMBBS,

    /// <summary>
    ///     history/engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}")]
    HistoryEEMMBBSS,

    /// <summary>
    ///     Get trade results for all the securities on the specified board group for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/securities")]
    HistoryEnginesEMMBBS,

    /// <summary>
    ///     Get trade results for all the securities on the specified board group for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/yields")]
    HistoryEEMMBBY,

    /// <summary>
    ///     Get trade results for the specified security on the specified board group for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}")]
    HistoryEnginesEMMBBSS,

    /// <summary>
    ///     Get trade yields for the specified security on the specified board group for the specified date.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/yields/{3}")]
    HistoryEEMMBBYS,

    /// <summary>
    ///     Get dates for which history for the specified security on the specified board group is available.
    /// </summary>
    [Description("history/engines/{0}/markets/{1}/boardgroups/{2}/securities/{3}/dates")]
    HistoryEEMMBBSSD,

    /// <summary>
    ///     Get the list of years that have archives with trade lists and market data.datatype can be set to securities or trades. 
    /// </summary>
    [Description("archives/engines/{0}/markets/{1}/{2}/years")]
    AEEMMDY,

    /// <summary>
    ///     Get the list of links to the yearly/monthly/daily archives of trade lists and market data.datatype can be set to securities or trades. period can be set to yearly, monthly or daily.Daily data is stored for the last 30 days only.
    /// </summary>
    [Description("archives/engines/{0}/markets/{1}/{2}/{3}")]
    AEEMMDP,

    /// <summary>
    ///     Get the list of months in a given year that have archives with trade lists and market data.datatype can be set to securities or trades. 
    /// </summary>
    [Description("archives/engines/{0}/markets/{1}/{2}/years/{3}/months")]
    AEEMMDYYM,

    /// <summary>
    ///     Securities groups
    /// </summary>
    [Description("securitygroups")]
    Securitygroups,

    /// <summary>
    ///     Securities group
    /// </summary>
    [Description("securitygroups/{0}")]
    SecuritygroupsS,

    /// <summary>
    ///     Securities collections in security group
    /// </summary>
    [Description("securitygroups/{0}/collections")]
    SSC,

    /// <summary>
    ///     Securities collection in security group
    /// </summary>
    [Description("securitygroups/{0}/collections/{1}")]
    SSCC,

    /// <summary>
    ///     Securities description
    /// </summary>
    [Description("securitygroups/{0}/collections/{1}/securities")]
    SSCCS,

    /// <summary>
    ///     Securities types
    /// </summary>
    [Description("securitytypes")]
    Securitytypes,

    /// <summary>
    ///     Dictionary: security type
    /// </summary>
    [Description("securitytypes/{0}")]
    SecuritytypesS,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets")]
    SEFMOA,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/{0}
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/{0}")]
    SEFMOAA,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/{0}/volumes
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/{0}/volumes")]
    SEFMOAAV,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/{0}/optionboard
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/{0}/optionboard")]
    SEFMOAAO,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/{0}/openpositions
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/{0}/openpositions")]
    StatisticsEFMOAAO,

    /// <summary>
    ///     statistics/engines/futures/markets/options/assets/{0}/turnovers
    /// </summary>
    [Description("statistics/engines/futures/markets/options/assets/{0}/turnovers")]
    SEFMOAAT,

    /// <summary>
    ///     statistics/engines/stock/markets/shares/correlations
    /// </summary>
    [Description("statistics/engines/stock/markets/shares/correlations")]
    SESMSC,

    /// <summary>
    ///     statistics/engines/currency/markets/selt/rates
    /// </summary>
    [Description("statistics/engines/currency/markets/selt/rates")]
    SECMSR,

    /// <summary>
    ///     statistics/engines/stock/splits
    /// </summary>
    [Description("statistics/engines/stock/splits")]
    StatisticsESS,

    /// <summary>
    ///     statistics/engines/stock/splits/{0}
    /// </summary>
    [Description("statistics/engines/stock/splits/{0}")]
    SESSS,

    /// <summary>
    ///     statistics/engines/state/markets/repo/mirp
    /// </summary>
    [Description("statistics/engines/state/markets/repo/mirp")]
    SESMRM,

    /// <summary>
    ///     statistics/engines/state/markets/repo/dealers
    /// </summary>
    [Description("statistics/engines/state/markets/repo/dealers")]
    SESMRD,

    /// <summary>
    ///     statistics/engines/state/markets/repo/cboper
    /// </summary>
    [Description("statistics/engines/state/markets/repo/cboper")]
    SESMRC,

    /// <summary>
    ///     statistics/engines/stock/deviationcoeffs
    /// </summary>
    [Description("statistics/engines/stock/deviationcoeffs")]
    SESD,

    /// <summary>
    ///     statistics/engines/stock/quotedsecurities
    /// </summary>
    [Description("statistics/engines/stock/quotedsecurities")]
    SESQ,

    /// <summary>
    ///     statistics/engines/stock/currentprices
    /// </summary>
    [Description("statistics/engines/stock/currentprices")]
    SESC,

    /// <summary>
    ///     statistics/engines/stock/markets/bonds/monthendaccints
    /// </summary>
    [Description("statistics/engines/stock/markets/bonds/monthendaccints")]
    SESMBM,

    /// <summary>
    ///     Exchange news
    /// </summary>
    [Description("sitenews")]
    Sitenews,

    /// <summary>
    ///     A site news
    /// </summary>
    [Description("sitenews/{0}")]
    SN,

    /// <summary>
    ///     Exchange activities
    /// </summary>
    [Description("events")]
    Events,

    /// <summary>
    ///     Exchange activity content
    /// </summary>
    [Description("events/{0}")]
    EventsE,

    /// <summary>
    ///     statistics/engines/stock/markets/bonds/aggregates
    /// </summary>
    [Description("statistics/engines/stock/markets/bonds/aggregates")]
    SESMBA,

    /// <summary>
    ///     statistics/engines/stock/markets/bonds/aggregates/columns
    /// </summary>
    [Description("statistics/engines/stock/markets/bonds/aggregates/columns")]
    SESMBAC,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics")]
    SESMIA,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics/{0}
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics/{0}")]
    SESMIAI,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics/{0}/tickers
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics/{0}/tickers")]
    SESMIAIT,

    /// <summary>
    ///     statistics/engines/stock/markets/index/analytics/{0}/tickers/{1}
    /// </summary>
    [Description("statistics/engines/stock/markets/index/analytics/{0}/tickers/{1}")]
    SESMIAITT,

    /// <summary>
    ///     Stock market capitalization
    /// </summary>
    [Description("statistics/engines/stock/capitalization")]
    StatisticsESC,

    /// <summary>
    ///     history/engines/stock/totals/boards
    /// </summary>
    [Description("history/engines/stock/totals/boards")]
    HESTB,

    /// <summary>
    ///     history/engines/stock/totals/securities
    /// </summary>
    [Description("history/engines/stock/totals/securities")]
    HESTS,

    /// <summary>
    ///     history/engines/stock/totals/boards/{0}/securities
    /// </summary>
    [Description("history/engines/stock/totals/boards/{0}/securities")]
    HESTBBS,

    /// <summary>
    ///     history/engines/stock/totals/boards/{0}/securities/{1}
    /// </summary>
    [Description("history/engines/stock/totals/boards/{0}/securities/{1}")]
    HESTBBSS,

    /// <summary>
    ///     rms/engines/{0}/objects/irr
    /// </summary>
    [Description("rms/engines/{0}/objects/irr")]
    REEOI,

    /// <summary>
    ///     rms/engines/{0}/objects/irr/filters
    /// </summary>
    [Description("rms/engines/{0}/objects/irr/filters")]
    REEOIF,

    /// <summary>
    ///     rms/engines/{0}/objects/settlementscalendar
    /// </summary>
    [Description("rms/engines/{0}/objects/settlementscalendar")]
    REEOS,

    /// <summary>
    ///     statistics/engines/state/rates
    /// </summary>
    [Description("statistics/engines/state/rates")]
    SESR,

    /// <summary>
    ///     statistics/engines/state/rates/columns
    /// </summary>
    [Description("statistics/engines/state/rates/columns")]
    SESRC,

    /// <summary>
    ///     statistics/engines/{0}/derivatives/{1}
    /// </summary>
    [Description("statistics/engines/{0}/derivatives/{1}")]
    SEEDR,

    /// <summary>
    ///     statistics/engines/{0}/monthly/{1}
    /// </summary>
    [Description("statistics/engines/{0}/monthly/{1}")]
    SEEMR,

    /// <summary>
    ///     statistics/engines/currency/markets/fixing/{0}
    /// </summary>
    [Description("statistics/engines/currency/markets/fixing/{0}")]
    SECMFS,

    /// <summary>
    ///     statistics/engines/futures/markets/indicativerates/securities
    /// </summary>
    [Description("statistics/engines/futures/markets/indicativerates/securities")]
    SEFMIS,

    /// <summary>
    ///     statistics/engines/futures/markets/indicativerates/securities/{0}
    /// </summary>
    [Description("statistics/engines/futures/markets/indicativerates/securities/{0}")]
    SEFMISS,

    /// <summary>
    ///     statistics/engines/currency/markets/fixing
    /// </summary>
    [Description("statistics/engines/currency/markets/fixing")]
    SECMF,

    /// <summary>
    ///     statistics/engines/{0}/markets/{1}
    /// </summary>
    [Description("statistics/engines/{0}/markets/{1}")]
    SEEMM,

    /// <summary>
    ///     statistics/engines/{0}/markets/{1}/securities
    /// </summary>
    [Description("statistics/engines/{0}/markets/{1}/securities")]
    SEEMMS,

    /// <summary>
    ///     statistics/engines/{0}/markets/{1}/securities/{2}
    /// </summary>
    [Description("statistics/engines/{0}/markets/{1}/securities/{2}")]
    SEEMMSS,

    /// <summary>
    ///     analyticalproducts/netflow2/securities
    /// </summary>
    [Description("analyticalproducts/netflow2/securities")]
    ANS,

    /// <summary>
    ///     analyticalproducts/netflow2/securities/{0}
    /// </summary>
    [Description("analyticalproducts/netflow2/securities/{0}")]
    ANSS,

    /// <summary>
    ///     analyticalproducts/futoi/securities
    /// </summary>
    [Description("analyticalproducts/futoi/securities")]
    AFS,

    /// <summary>
    ///     analyticalproducts/futoi/securities/{0}
    /// </summary>
    [Description("analyticalproducts/futoi/securities/{0}")]
    AFSS,

    /// <summary>
    ///     analyticalproducts/curves/securities
    /// </summary>
    [Description("analyticalproducts/curves/securities")]
    ACS,

    /// <summary>
    ///     analyticalproducts/curves/securities/{0}
    /// </summary>
    [Description("analyticalproducts/curves/securities/{0}")]
    ACSS,

    /// <summary>
    ///     sdfi/curves/securities
    /// </summary>
    [Description("sdfi/curves/securities")]
    SCS,
}