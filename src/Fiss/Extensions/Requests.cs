using System.Runtime.CompilerServices;

namespace Fiss;

/// <summary>
///     Class for constructing a path to ISS MOEX
/// </summary>
/// <example>
///     <code>
///         var requst = new IssRequest().Securities();
///         var longRequst = new IssRequest().History().Otc().Providers().Nsd().Markets();
///     </code>
/// </example>
public static partial class IssRequestExtension
{
    public static IIssRequest Bondization(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Futoi(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Netflow2(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest AnalyticalProducts(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest IndicativeRates(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Futures(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Fixing(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest ReportName(this IIssRequest request, ReportType reportName) => request.MethodNameToPath(reportName.ToString());

    public static IIssRequest Derivatives(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Filters(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Irr(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Objects(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Rms(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Totals(this IIssRequest request) => request.MethodNameToPath();
        
    public static IIssRequest Capitalization(this IIssRequest request) => request.MethodNameToPath();

    #region Tickers

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest Tickers(this IIssRequest request) => request.MethodNameToPath();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest Tickers(this IIssRequest request, string ticker) => request.MethodNameToPath(additionalPath: ticker);

    #endregion

    public static IIssRequest Bonds(this IIssRequest request) => request.MethodNameToPath();

    #region Events

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest Events(this IIssRequest request) => request.MethodNameToPath();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest Events(this IIssRequest request, string eventId) => request.MethodNameToPath(additionalPath: eventId);

    #endregion

    public static IIssRequest NewsId(this IIssRequest request, int newsId) => request.MethodNameToPath(newsId.ToString());

    #region SiteNews

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest SiteNews(this IIssRequest request) => request.MethodNameToPath();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest SiteNews(this IIssRequest request, string newsId) => request.MethodNameToPath(additionalPath: newsId);

    #endregion

    public static IIssRequest CurrentPrices(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest QuotedSecurities(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest DeviationCoeffs(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Cboper(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Dealers(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Mirp(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Repo(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest State(this IIssRequest request) => request.MethodNameToPath();

    #region Splits

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest Splits(this IIssRequest request) => request.MethodNameToPath();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest Splits(this IIssRequest request, string security) => request.MethodNameToPath(additionalPath: security);

    #endregion

    public static IIssRequest Rates(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Selt(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Currency(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Correlations(this IIssRequest request) => request.MethodNameToPath();

    #region SecurityGroup

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest SecurityGroups(this IIssRequest request) => request.MethodNameToPath();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest SecurityGroups(this IIssRequest request, SecurityGroup securityGroup) => request.MethodNameToPath(additionalPath: Convert.ToInt32(securityGroup).ToString());

    #endregion

    #region Collections

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest Collections(this IIssRequest request) => request.MethodNameToPath();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IIssRequest Collections(this IIssRequest request, CollectionType collectionType) => request.MethodNameToPath(additionalPath: Convert.ToInt32(collectionType).ToString());

    #endregion

    #region SecurityTypes

    public static IIssRequest SecurityTypes(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest SecurityTypes(this IIssRequest request, SecurityType securityType) => request.MethodNameToPath(additionalPath: securityType.ToString());

    #endregion

    public static IIssRequest Months(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Period(this IIssRequest request, Period period) => request.MethodNameToPath(additionalPath: period.ToString());

    #region Years

    public static IIssRequest Years(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Years(this IIssRequest request, int year) => request.MethodNameToPath(additionalPath: year.ToString());

    #endregion

    public static IIssRequest DataType(this IIssRequest request, DataType dataType) => request.MethodNameToPath(dataType.ToString());

	public static IIssRequest Archives(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Dates(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Yields(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Changeover(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Shares(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest CandleBorders(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Candles(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Rusfar(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Bulletins(this IIssRequest request) => request.MethodNameToPath();

    #region Analytics

    public static IIssRequest Analytics(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Analytics(this IIssRequest request, string indexId) => request.MethodNameToPath(additionalPath: indexId);

    #endregion

    public static IIssRequest SecuritiesListing(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Stock(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Statistics(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Trades(this IIssRequest request) => request.MethodNameToPath();

    #region Session

    public static IIssRequest Sessions(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Sessions(this IIssRequest request, TradingSession tradingSession) => request.MethodNameToPath(additionalPath: tradingSession.ToString());

    #endregion

    public static IIssRequest Orderbook(this IIssRequest request) => request.MethodNameToPath();

    #region BoardGroup

	public static IIssRequest BoardGroups(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest BoardGroups(this IIssRequest request, BoardGroup boardGroup) => request.MethodNameToPath(additionalPath: boardGroup.ToString());

    #endregion

    #region Boards

    public static IIssRequest Boards(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Boards(this IIssRequest request, Board board) => request.MethodNameToPath(additionalPath: board.ToString());

    #endregion

    #region Listing

    public static IIssRequest Listing(this IIssRequest request) => request.MethodNameToPath();

    #endregion

    public static IIssRequest Monthly(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Daily(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Nsd(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Providers(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Otc(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest History(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Index(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Zcyc(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Columns(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Turnovers(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Secstats(this IIssRequest request) => request.MethodNameToPath();

    #region Marktes

	public static IIssRequest Markets(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Markets(this IIssRequest request, AgroMarket agroMarket) => request.MethodNameToPath(additionalPath: agroMarket.ToString());

	public static IIssRequest Markets(this IIssRequest request, CommodityMarket commodityMarket) => request.MethodNameToPath(additionalPath: commodityMarket.ToString());

	public static IIssRequest Markets(this IIssRequest request, CurrencyMarket currencyMarket) => request.MethodNameToPath(additionalPath: currencyMarket.ToString());

	public static IIssRequest Markets(this IIssRequest request, FuturesMarket futuresMarket) => request.MethodNameToPath(additionalPath: futuresMarket.ToString());

	public static IIssRequest Markets(this IIssRequest request, InterventionsMarket interventionsMarket) => request.MethodNameToPath(additionalPath: interventionsMarket.ToString());

	public static IIssRequest Markets(this IIssRequest request, OffboardMarket offboardMarket) => request.MethodNameToPath(additionalPath: offboardMarket.ToString());

	public static IIssRequest Markets(this IIssRequest request, StateMarket stateMarket) => request.MethodNameToPath(additionalPath: stateMarket.ToString());

	public static IIssRequest Markets(this IIssRequest request, StockMarket stockMarket) => request.MethodNameToPath(additionalPath: stockMarket.ToString());

    #endregion

    #region Engine

    public static IIssRequest Engines(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Engines(this IIssRequest request, Engine engine) => request.MethodNameToPath(additionalPath: engine.ToString());

    #endregion

    public static IIssRequest Aggregates(this IIssRequest request) => request.MethodNameToPath();

	public static IIssRequest Indices(this IIssRequest request) => request.MethodNameToPath();

    #region Securities

    public static IIssRequest Securities(this IIssRequest request) => request.MethodNameToPath();

    public static IIssRequest Securities(this IIssRequest request, string securities) => request.MethodNameToPath(additionalPath: securities);

    #endregion

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static IIssRequest MethodNameToPath(this IIssRequest request, string additionalPath, [CallerMemberName] string path = "")
    {
        request.AddPath(path.ToLowerInvariant());
        request.AddPath(additionalPath.ToLowerInvariant());
        return request;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static IIssRequest MethodNameToPath(this IIssRequest request, [CallerMemberName] string path = "")
	{
		request.AddPath(path.ToLowerInvariant());
		return request;
	}
}