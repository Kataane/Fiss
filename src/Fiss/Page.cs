namespace Fiss;

public record Page(Dictionary<string, Table> Tables);

public record Table(List<Header> Headers, List<Row>? Rows);

public record Row(Dictionary<string, (string type, string value)> Cells);

public record Header(string Name);
