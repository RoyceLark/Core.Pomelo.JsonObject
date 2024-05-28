// ReSharper disable once CheckNamespace
namespace System
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class JsonObject : JsonObject<object>
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public JsonObject(string json)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
      : base(json)
    {
    }
  }
}
