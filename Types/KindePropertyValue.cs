using System.Text.Json.Serialization;

namespace Clinically.Kinde.Authentication.Types;

public class KindePropertiesRoot
{
    [JsonPropertyName("properties")]
    public Dictionary<string, KindePropertyValue> Properties { get; set; }
}

public class KindePropertyValue
{
    [JsonPropertyName("v")]
    public string Value { get; set; }
}