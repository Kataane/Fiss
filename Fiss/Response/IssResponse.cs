namespace Fiss.Response;

/// <summary>
/// Объект который предаставляет из себя
/// ответ от ISS Moex
/// </summary>
[JsonConverter(typeof(IssResponseJsonConverter))]
public record IssResponse(IDictionary<string, Table> Tables);

public record Table(IEnumerable<Header> Headers, IEnumerable<Row> Rows);

public record Row(IDictionary<string, object> Values);

public record Header(string Name);
