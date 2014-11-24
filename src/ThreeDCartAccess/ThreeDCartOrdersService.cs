﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using ThreeDCartAccess.Misc;
using ThreeDCartAccess.Models.Configuration;
using ThreeDCartAccess.Models.Order;
using ThreeDCartAccess.ThreeDCartAdvancedService;
using ThreeDCartAccess.ThreeDCartService;

namespace ThreeDCartAccess
{
	public class ThreeDCartOrdersService: IThreeDCartOrdersService
	{
		private readonly ThreeDCartConfig _config;
		private readonly cartAPISoapClient _service;
		private readonly cartAPIAdvancedSoapClient _advancedService;
		private readonly WebRequestServices _webRequestServices;

		public ThreeDCartOrdersService( ThreeDCartConfig config )
		{
			Condition.Requires( config, "config" ).IsNotNull();

			this._config = config;
			this._service = new cartAPISoapClient();
			this._advancedService = new cartAPIAdvancedSoapClient();
			this._webRequestServices = new WebRequestServices();
		}

		public IEnumerable< ThreeDCartOrder > GetOrders()
		{
			var result = this._webRequestServices.Get< ThreeDCartOrders >( this._config,
				() => this._service.getOrder( this._config.StoreUrl, this._config.UserKey, 100, 1, false, "", "", "", "", "" ) );
			return result.Orders;
		}

		public async Task< IEnumerable< ThreeDCartOrder > > GetOrdersAsync()
		{
			var result = await this._webRequestServices.GetAsync< ThreeDCartOrders >( this._config,
				async () => ( await this._service.getOrderAsync( this._config.StoreUrl, this._config.UserKey, 100, 1, false, "", "", "", "", "" ) ).Body.getOrderResult );
			return result.Orders;
		}

		public IEnumerable< ThreeDCartOrder > GetOrders( DateTime startDateUtc, DateTime endDateUtc )
		{
			var result = this._webRequestServices.Get< ThreeDCartOrders >( this._config,
				() => this._service.getOrder( this._config.StoreUrl, this._config.UserKey, 100, 1, false, "", "", "", "", "" ) );
			return result.Orders;
		}

		public async Task< IEnumerable< ThreeDCartOrder > > GetOrdersAsync( DateTime startDateUtc, DateTime endDateUtc )
		{
			var result = await this._webRequestServices.GetAsync< ThreeDCartOrders >( this._config,
				async () => ( await this._service.getOrderAsync( this._config.StoreUrl, this._config.UserKey, 100, 1, false, "", "", "", "", "" ) ).Body.getOrderResult );
			return result.Orders;
		}

		public IEnumerable< ThreeDCartOrderStatus > GetOrderStatuses()
		{
			const string sql = "select id, StatusID, StatusDefinition, StatusText, Visible from order_Status";
			var result = this._webRequestServices.Get< ThreeDCartOrderStatuses >( this._config,
				() => this._advancedService.runQuery( this._config.StoreUrl, this._config.UserKey, sql, "" ) );
			return result.Statuses;
		}

		public async Task< IEnumerable< ThreeDCartOrderStatus > > GetOrderStatusesAsync()
		{
			const string sql = "select id, StatusID, StatusDefinition, StatusText, Visible from order_Status";
			var result = await this._webRequestServices.GetAsync< ThreeDCartOrderStatuses >( this._config,
				async () => ( await this._advancedService.runQueryAsync( this._config.StoreUrl, this._config.UserKey, sql, "" ) ).Body.runQueryResult );
			return result.Statuses;
		}
	}
}