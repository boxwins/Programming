using Newtonsoft.Json;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сериализует данные в формате JSON.
    /// </summary>
    public static class Serializer
    {
        private static JsonSerializerSettings Settings { get; set; } = new JsonSerializerSettings();

        static Serializer()
        {
            Settings.Formatting = Formatting.Indented;
            Settings.TypeNameHandling = TypeNameHandling.All;
            Settings.ObjectCreationHandling = ObjectCreationHandling.Replace;
        }

        /// <summary>
        /// Сериализует данные.
        /// </summary>
        /// <param name="data">Данные.</param>
        /// <param name="path">Путь к файлу.</param>
        public static void Serialize<T>(T data, string path)
        {
            string json = JsonConvert.SerializeObject(data, Settings);

            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Десериализует данные.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns>Данные.</returns>
        public static T Deserialize<T>(string path)
        {
            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Десереализует массив строк.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns>Массив строк.</returns>
        public static string[] Deserialize(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
