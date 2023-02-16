namespace Fiss.Response;

public record Page(IDictionary<string, Table> Tables);

public record Table(IEnumerable<Header> Headers, IEnumerable<Row>? Rows);

public record Row(IDictionary<string, object> Values);

public record Header(string Name);
