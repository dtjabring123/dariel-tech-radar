namespace gql
{
  internal class TextSerializer : GraphQL.IGraphQLTextSerializer
  {
    public T? Deserialize<T>(string? value)
    {
      throw new NotImplementedException();
    }

    public ValueTask<T?> ReadAsync<T>(Stream stream, CancellationToken cancellationToken = default)
    {
      throw new NotImplementedException();
    }

    public T? ReadNode<T>(object? value)
    {
      throw new NotImplementedException();
    }

    public string Serialize<T>(T? value)
    {
      throw new NotImplementedException();
    }

    public Task WriteAsync<T>(Stream stream, T? value, CancellationToken cancellationToken = default)
    {
      throw new NotImplementedException();
    }
  }
}