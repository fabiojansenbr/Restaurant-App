﻿namespace Restaurant.Common.Constants
{
	public struct ApiConstants
	{
		public const string ApiName = "api1";
		public const string ClientId = "user_password.client";
		public const string ClientSecret = "secret";

		private const string AzureClientUrl = "https://restaurantserverapi.azurewebsites.net/";
		private const string ApiClientUrlForAndroidEmulator = "http://10.0.2.2:5000/";
		public static string ApiClientUrl => ApiClientUrlForAndroidEmulator;
	}
}