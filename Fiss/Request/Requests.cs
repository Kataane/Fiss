namespace Fiss.Request;

/// <summary>
/// Статическая обертка для IIssRequst 
/// для создания цепочки обязанностей.
/// В данном классе реализованны методы
/// построения путей.
/// </summary>
/// <example>
/// <code>
/// var requst = new IssRequest().Securities();
/// var longRequst = new IssRequest().History().Otc().Providers().Nsd().Markets();
/// </code>
/// </example>
public static partial class IssRequestExtension
{
	/// <summary>
	/// Добавляет в общий массив путей, путь futoi
	/// </summary>
	public static IIssRequest Futoi(this IIssRequest request) => Returner(request, "futoi");

	/// <summary>
	/// Добавляет в общий массив путей, путь netflow2
	/// </summary>
	public static IIssRequest Netflow2(this IIssRequest request) => Returner(request, "netflow2");

	/// <summary>
	/// Добавляет в общий массив путей, путь analyticalproducts
	/// </summary>
	public static IIssRequest AnalyticalProducts(this IIssRequest request) => Returner(request, "analyticalproducts");

	/// <summary>
	/// Добавляет в общий массив путей, путь indicativerates
	/// </summary>
	public static IIssRequest IndicativeRates(this IIssRequest request) => Returner(request, "indicativerates");

	/// <summary>
	/// Добавляет в общий массив путей, путь futures
	/// </summary>
	public static IIssRequest Futures(this IIssRequest request) => Returner(request, "futures");

	/// <summary>
	/// Добавляет в общий массив путей, путь fixing
	/// </summary>
	public static IIssRequest Fixing(this IIssRequest request) => Returner(request, "fixing");

	/// <summary>
	/// Добавляет в общий массив путей, путь ReportName
	/// </summary>
	public static IIssRequest ReportName(this IIssRequest request, string reportName) => Returner(request, $"{reportName}");

	/// <summary>
	/// Добавляет в общий массив путей, путь derivatives
	/// </summary>
	public static IIssRequest Derivatives(this IIssRequest request) => Returner(request, "derivatives");

	public static IIssRequest Filters(this IIssRequest request) => Returner(request, "filters");

	public static IIssRequest Irr(this IIssRequest request) => Returner(request, "irr");

	public static IIssRequest Objects(this IIssRequest request) => Returner(request, "objects");

	public static IIssRequest Rms(this IIssRequest request) => Returner(request, "rms");

	public static IIssRequest Totals(this IIssRequest request) => Returner(request, "totals");

	public static IIssRequest Capitalization(this IIssRequest request) => Returner(request, "capitalization");

	public static IIssRequest Ticker(this IIssRequest request, string ticker) => Returner(request, $"{ticker}");

	public static IIssRequest Tickers(this IIssRequest request) => Returner(request, "tickers");

	public static IIssRequest Indexid(this IIssRequest request, string Indexid) => Returner(request, $"{Indexid}");

	public static IIssRequest Bonds(this IIssRequest request) => Returner(request, "bonds");

	public static IIssRequest EventId(this IIssRequest request, string eventId) => Returner(request, $"{eventId}");

	public static IIssRequest Events(this IIssRequest request) => Returner(request, "events");

	public static IIssRequest NewsId(this IIssRequest request, string newsId) => Returner(request, $"{newsId}");

	public static IIssRequest Sitenews(this IIssRequest request) => Returner(request, "sitenews");

	public static IIssRequest Currentprices(this IIssRequest request) => Returner(request, "currentprices");

	public static IIssRequest Quotedsecurities(this IIssRequest request) => Returner(request, "quotedsecurities");

	public static IIssRequest Deviationcoeffs(this IIssRequest request) => Returner(request, "deviationcoeffs");

	public static IIssRequest Cboper(this IIssRequest request) => Returner(request, "cboper");

	public static IIssRequest Dealers(this IIssRequest request) => Returner(request, "dealers");

	public static IIssRequest Mirp(this IIssRequest request) => Returner(request, "mirp");

	public static IIssRequest Repo(this IIssRequest request) => Returner(request, "repo");

	public static IIssRequest State(this IIssRequest request) => Returner(request, "state");

	public static IIssRequest Splits(this IIssRequest request) => Returner(request, "splits");

	public static IIssRequest Rates(this IIssRequest request) => Returner(request, "rates");

	public static IIssRequest Selt(this IIssRequest request) => Returner(request, "selt");

	public static IIssRequest Currency(this IIssRequest request) => Returner(request, "currency");

	public static IIssRequest Correlations(this IIssRequest request) => Returner(request, "correlations");

	public static IIssRequest Securitytype(this IIssRequest request, string Securitytype) => Returner(request, $"{Securitytype}");

	public static IIssRequest Securitytypes(this IIssRequest request) => Returner(request, "securitytypes");

	public static IIssRequest Collection(this IIssRequest request, string collection) => Returner(request, $"{collection}");

	public static IIssRequest Collections(this IIssRequest request) => Returner(request, "collections");

	public static IIssRequest Securitygroup(this IIssRequest request, string Securitygroup) => Returner(request, $"{Securitygroup}");

	public static IIssRequest Securitygroups(this IIssRequest request) => Returner(request, "securitygroups");

	public static IIssRequest Months(this IIssRequest request) => Returner(request, "months");

	public static IIssRequest Year(this IIssRequest request, string year) => Returner(request, $"{year}");

	public static IIssRequest Period(this IIssRequest request, string period) => Returner(request, $"{period}");

	public static IIssRequest Years(this IIssRequest request) => Returner(request, "years");

	public static IIssRequest Datatype(this IIssRequest request, string Datatype) => Returner(request, $"{Datatype}");

	public static IIssRequest Archives(this IIssRequest request) => Returner(request, "archives");

	public static IIssRequest Dates(this IIssRequest request) => Returner(request, "dates");

	public static IIssRequest Yields(this IIssRequest request) => Returner(request, "yields");

	public static IIssRequest Changeover(this IIssRequest request) => Returner(request, "changeover");

	public static IIssRequest Shares(this IIssRequest request) => Returner(request, "shares");

	public static IIssRequest Candleborders(this IIssRequest request) => Returner(request, "candleborders");

	public static IIssRequest Candles(this IIssRequest request) => Returner(request, "candles");

	public static IIssRequest Rusfar(this IIssRequest request) => Returner(request, "rusfar");

	public static IIssRequest Bulletins(this IIssRequest request) => Returner(request, "bulletins");

	public static IIssRequest Analytics(this IIssRequest request) => Returner(request, "analytics");

	public static IIssRequest Securitieslisting(this IIssRequest request) => Returner(request, "securitieslisting");

	public static IIssRequest Stock(this IIssRequest request) => Returner(request, "stock");

	public static IIssRequest Statistics(this IIssRequest request) => Returner(request, "statistics");

	public static IIssRequest Trades(this IIssRequest request) => Returner(request, "trades");

	public static IIssRequest Session(this IIssRequest request) => Returner(request, "session");

	public static IIssRequest Session(this IIssRequest request, string session) => Returner(request, $"{session}");

	public static IIssRequest Sessions(this IIssRequest request) => Returner(request, "sessions");

	public static IIssRequest Orderbook(this IIssRequest request) => Returner(request, "orderbook");

	public static IIssRequest Boardgroup(this IIssRequest request, string boardgroup) => Returner(request, $"{boardgroup}");

	public static IIssRequest Boardgroups(this IIssRequest request) => Returner(request, "boardgroups");

	public static IIssRequest Board(this IIssRequest request, string board) => Returner(request, $"{board}");

	public static IIssRequest Boards(this IIssRequest request) => Returner(request, "boards");

	public static IIssRequest Listing(this IIssRequest request) => Returner(request, "listing");

	public static IIssRequest Monthly(this IIssRequest request) => Returner(request, "monthly");

	public static IIssRequest Daily(this IIssRequest request) => Returner(request, "daily");

	public static IIssRequest Nsd(this IIssRequest request) => Returner(request, "nsd");

	public static IIssRequest Providers(this IIssRequest request) => Returner(request, "providers");

	public static IIssRequest Otc(this IIssRequest request) => Returner(request, "otc");

	public static IIssRequest History(this IIssRequest request) => Returner(request, "history");

	public static IIssRequest Index(this IIssRequest request) => Returner(request, "index");

	public static IIssRequest Zcyc(this IIssRequest request) => Returner(request, "zcyc");

	public static IIssRequest Columns(this IIssRequest request) => Returner(request, "columns");

	public static IIssRequest Turnovers(this IIssRequest request) => Returner(request, "turnovers");

	public static IIssRequest Secstats(this IIssRequest request) => Returner(request, "secstats");

	public static IIssRequest Market(this IIssRequest request, string market) => Returner(request, $"{market}");

	public static IIssRequest Markets(this IIssRequest request) => Returner(request, "markets");

	public static IIssRequest Engine(this IIssRequest request, string engine) => Returner(request, $"{engine}");

	public static IIssRequest Engines(this IIssRequest request) => Returner(request, "engines");

	public static IIssRequest Aggregates(this IIssRequest request) => Returner(request, "aggregates");

	public static IIssRequest Indices(this IIssRequest request) => Returner(request, "indices");

	public static IIssRequest Security(this IIssRequest request, string security) => Returner(request, $"{security}");

	public static IIssRequest Securities(this IIssRequest request) => Returner(request, "securities");

	private static IIssRequest Returner(IIssRequest request, string path)
	{
		request.AddPath(path.ToLower());
		return request;
	}
}
