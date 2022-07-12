namespace Fiss.Response;

/// <summary>
/// Конвертер для десериализаци ответа от ISS Moex в IssResponse
/// </summary>
public class IssResponseJsonConverter : JsonConverter
{
    public override bool CanConvert(Type objectType) =>
        typeof(IssResponse).IsAssignableFrom(objectType);


    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        var responses = new Dictionary<string, Table>();

        // Нужен для чтения родительского
        // объекта на глубине 1
        while (reader.Read())
        {
            if (reader.TokenType == JsonToken.EndObject) break;

            var value = reader.Value.ToString().ToPascalCase();

            // Нужен чтобы перейти к детям
            // в родительском объекте
            reader.Read();

            // Переходим к первому ребенку
            reader.Read();
            var metadataJtoken = JToken.Load(reader);
            var columnsJtoken = JToken.Load(reader);
            var dataJtoken = JToken.Load(reader);

            var columns = JArray.Load(columnsJtoken.First.CreateReader())
                .ToObject<IEnumerable<string>>()
                .Select(item => new Header(item.ToPascalCase()));

            var data = JArray.Load(dataJtoken.First.CreateReader())
                .ToObject<IEnumerable<IEnumerable<object>>>();

            // Для связывания данных с названием колонки
            var rows = data.Select(data => data
                .Zip(columns, (value, column) => new { value, column })
                .ToDictionary(item => item.column.Name, item => item.value))
                .Select(dic => new Row(dic));

            var response = new Table(columns, rows);
            responses[value] = response;

            reader.Skip();
        }

        return new IssResponse(responses);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}
