using System;
using System.Reflection;
using System.Web;
using DotnetIntercomAPI.Extensions;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Helpers;

public static class HttpHelper
{
    public static string ToQueryStringAsString<T>(T obj)
    {
        var properties = from p in obj?
                                .GetType()
                                .GetProperties()
                         where p.GetValue(obj, null) != null
                         select $"{HttpUtility.UrlEncode(p.Name)}" +
                         $"={HttpUtility.UrlEncode(p.GetValue(obj)?.ToString())}";

        return string.Join("&", properties);
    }

    public static Dictionary<string, string> ToSnakeCaseQueryStringAsDictionary<T>(T obj)
    {
        var dictionary = new Dictionary<string, string>();

        if (obj != null)
        {
            var properties = obj.GetType().GetProperties()
                .Where(p => p.GetValue(obj, null) != null)  // Filter out null values
                .Select(p =>
                {
                    string key = p.Name.ToSnakeCase();

                    var type = p.PropertyType;
                    var value = p.GetValue(obj)?.ToString();

                    if (type == typeof(bool))
                        value = value?.ToLower();

                    return new
                    {
                        Key = key,
                        Value = value
                    };
                });

            foreach (var prop in properties)
            {
                dictionary.Add(prop.Key, prop.Value);
            }
        }

        return dictionary;
    }
}
