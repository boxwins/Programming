using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Data.Serialization;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сериализует данные в формате JSON.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Сериализует данные.
        /// </summary>
        /// <param name="data">Данные.</param>
        /// <param name="path">Путь к файлу.</param>
        public static void Serialize<T>(T data, string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string json = Regex.Unescape(JsonSerializer.Serialize(data, options));

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

            return JsonSerializer.Deserialize<T>(json);
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
