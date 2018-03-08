using Newtonsoft.Json;

namespace WatchTyping.Infra.Ultilities
{
    public static class JsonExtension
    {
        public static string ToJson<T>(this T obj) where T : class => JsonConvert.SerializeObject(obj);
        public static T DeserializeObject<T>(this string @value) where T : class => JsonConvert.DeserializeObject<T>(value);
    }
}
