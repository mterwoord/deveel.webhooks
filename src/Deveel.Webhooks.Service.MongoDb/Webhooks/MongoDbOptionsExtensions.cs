﻿using System;
using System.Collections.Generic;

using Deveel.Data;

namespace Deveel.Webhooks {
	public static class MongoDbOptionsExtensions {
		public static string DeliveryResultsCollectionName(this MongoDbOptions options)
			=> options.Collections?[MongoDbWebhookStorageConstants.DeliveryResultsCollectionKey];

		public static MongoDbOptions DeliveryResultsCollectionName(this MongoDbOptions options, string collectionName) {
			if (options.Collections == null)
				options.Collections = new Dictionary<string, string>();

			options.Collections[MongoDbWebhookStorageConstants.DeliveryResultsCollectionKey] = collectionName;
			return options;
		}

		public static string SubscriptionsCollectionName(this MongoDbOptions options)
			=> options.Collections?[MongoDbWebhookStorageConstants.SubscriptionCollectionKey];

		public static MongoDbOptions SubscriptionsCollectionName(this MongoDbOptions options, string collectionName) {
			if (options.Collections == null)
				options.Collections = new Dictionary<string, string>();

			options.Collections[MongoDbWebhookStorageConstants.SubscriptionCollectionKey] = collectionName;
			return options;
		}
	}
}
