using System.Text.Json.Serialization;

namespace woodgroveapi.Models
{

    public class TokenIssuanceStartRequest
    {
        [JsonPropertyName("data")]
        public TokenIssuanceStartRequest_Data data { get; set; }
        public TokenIssuanceStartRequest()
        {
            data = new TokenIssuanceStartRequest_Data();
        }
    }

    public class TokenIssuanceStartRequest_Data
    {
        [JsonPropertyName("@odata.type")]
        public string odatatype { get; set; }
        public string tenantId { get; set; }
        public string authenticationEventListenerId { get; set; }
        public string customAuthenticationExtensionId { get; set; }
        public AuthenticationContext authenticationContext { get; set; }

    }
}