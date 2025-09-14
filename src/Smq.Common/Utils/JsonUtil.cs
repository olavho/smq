namespace Smq.Common.Utils
{
    public class JsonUtil
    {
        public static string AsJson(object obj)
        {
            return System.Text.Json.JsonSerializer.Serialize(obj);
        }

        public static T AsObject<T>(string json)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }
    }
}
