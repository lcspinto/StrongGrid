﻿using Newtonsoft.Json;
using System;

namespace StrongGrid.Models
{
	/// <summary>
	/// User credits.
	/// </summary>
	public class UserCredits
	{
		/// <summary>
		/// Gets or sets the remaining.
		/// </summary>
		/// <value>
		/// The remaining.
		/// </value>
		[JsonProperty("remain", NullValueHandling = NullValueHandling.Ignore)]
		public long Remaining { get; set; }

		/// <summary>
		/// Gets or sets the total.
		/// </summary>
		/// <value>
		/// The total.
		/// </value>
		[JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
		public long Total { get; set; }

		/// <summary>
		/// Gets or sets the overage.
		/// </summary>
		/// <value>
		/// The overage.
		/// </value>
		[JsonProperty("overage", NullValueHandling = NullValueHandling.Ignore)]
		public long Overage { get; set; }

		/// <summary>
		/// Gets or sets the used.
		/// </summary>
		/// <value>
		/// The used.
		/// </value>
		[JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
		public long Used { get; set; }

		/// <summary>
		/// Gets or sets the last reset.
		/// </summary>
		/// <value>
		/// The last reset.
		/// </value>
		[JsonProperty("last_reset", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime LastReset { get; set; }

		/// <summary>
		/// Gets or sets the next reset.
		/// </summary>
		/// <value>
		/// The next reset.
		/// </value>
		[JsonProperty("next_reset", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime NextReset { get; set; }

		/// <summary>
		/// Gets or sets the reset frequency.
		/// </summary>
		/// <value>
		/// The reset frequency.
		/// </value>
		[JsonProperty("reset_frequency", NullValueHandling = NullValueHandling.Ignore)]
		public string ResetFrequency { get; set; }
	}
}
