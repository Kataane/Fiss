namespace Fiss;

public record Page(Dictionary<string, Table> Tables);

public record Table(IEnumerable<Header> Headers, IEnumerable<Row>? Rows);

public record Row(Dictionary<string, (string type, string value)> Cells);

public record Header(string Name);
