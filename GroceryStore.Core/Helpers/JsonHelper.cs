using Newtonsoft.Json;
using System.IO;

namespace GroceryStore.Core.Helpers
{
    public static class JsonHelper
    {
        private static readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            Formatting = Newtonsoft.Json.Formatting.Indented,
            DateFormatString = "dd.MM.yy"
        };

        public static T GetData<T>(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonContent, _settings);
        }

        public static void SetData<T>(string filePath, T data) where T : class
        {
            string jsonString = JsonConvert.SerializeObject(data, _settings);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
