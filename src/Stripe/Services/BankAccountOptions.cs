﻿using Newtonsoft.Json;

namespace Stripe
{
	public abstract class BankAccountOptions
	{
        [JsonProperty("bank_account[country]")]
		public string BankCountry { get; set; }

        [JsonProperty("bank_account[routing_number]")]
		public string BankRoutingNumber { get; set; }

        [JsonProperty("bank_account[account_number]")]
		public string BankAccountNumber { get; set; }

        [JsonProperty("bank_account")]
		public string TokenId { get; set; }
	}
}
