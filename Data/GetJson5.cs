using System;
using Newtonsoft.Json;

namespace genFurikomiTesuuryo.Data
{
    [JsonObject("GetJson5")]
    class GetJson5
    {
        [JsonProperty("GetJson5 Test")]
        public string Test { get; set; }
    }
}
