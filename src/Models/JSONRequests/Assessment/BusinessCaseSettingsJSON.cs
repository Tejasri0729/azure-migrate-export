using Newtonsoft.Json;

using Azure.Migrate.Export.Common;

namespace Azure.Migrate.Export.Models
{
    public class BusinessCaseSettingsJSON
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("properties")]
        public BuisnessCaseProperty Properties = new BuisnessCaseProperty();
    }

    public class BuisnessCaseProperty
    {
        [JsonProperty("settings")]
        public BusinessCaseSettings Settings { get; set; } = new BusinessCaseSettings();
    }

    public class BusinessCaseSettings
    {
        [JsonProperty("azureSettings")]
        public BusinessCaseAzureSettings AzureSettings { get; set; } = new BusinessCaseAzureSettings();
    }
    

    public class BusinessCaseAzureSettings
    {
        [JsonProperty("discountPercentage")]
        public int DiscountPercentage { get; set; } = 0;

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("workloadDiscoverySource")]
        public string WorkloadDiscoverySource { get; set; } = "Appliance";

        [JsonProperty("businessCaseType")]
        public string BusinessCaseType { get; set; }

        [JsonProperty("savingsOption")]
        public string SavingsOption { get; set; } = "SavingsPlan3Year"; 
    }
}