using Newtonsoft.Json;

namespace Mcr.CrossCuttingConcerns.Extensions
{
    public static class ObjectExtensions
    {
        public static string AsJsonString(this object obj)
        {
            var content = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return content;
        }
    }
}
