﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRecipientUpdateOptions : BankAccountOptions
    {

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

    }
}
