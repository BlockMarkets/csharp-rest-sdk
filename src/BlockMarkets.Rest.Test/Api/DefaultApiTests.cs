/* 
 * BlockMarkets Cryptocurrency API
 *
 * The BlockMarkets API provides real-time and historical market data on cryptocurrencies from the world's leading crypto exchanges. Sign up for a free, unlimited API key at [BlockMarkets Cryptocurrency API](https://www.blockmarkets.io/cryptocurrency-api).
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Model;

namespace BlockMarkets.Rest.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        
        /// <summary>
        /// Test BenchmarkRate
        /// </summary>
        [Test]
        public void BenchmarkRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.BenchmarkRate(symbol);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test BenchmarkRateHistory
        /// </summary>
        [Test]
        public void BenchmarkRateHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string close = null;
            //var response = instance.BenchmarkRateHistory(symbol, close);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListAssetMarkets
        /// </summary>
        [Test]
        public void ListAssetMarketsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.ListAssetMarkets(symbol);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListAssets
        /// </summary>
        [Test]
        public void ListAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListAssets();
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListBenchmarkRates
        /// </summary>
        [Test]
        public void ListBenchmarkRatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListBenchmarkRates();
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListExchangeMarkets
        /// </summary>
        [Test]
        public void ListExchangeMarketsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //var response = instance.ListExchangeMarkets(exchange);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListExchanges
        /// </summary>
        [Test]
        public void ListExchangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListExchanges();
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListMarkets
        /// </summary>
        [Test]
        public void ListMarketsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListMarkets();
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListPairMarkets
        /// </summary>
        [Test]
        public void ListPairMarketsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //var response = instance.ListPairMarkets(pair);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListPairs
        /// </summary>
        [Test]
        public void ListPairsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListPairs();
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test ListSpotRates
        /// </summary>
        [Test]
        public void ListSpotRatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListSpotRates();
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test MarketBook
        /// </summary>
        [Test]
        public void MarketBookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //string pair = null;
            //var response = instance.MarketBook(exchange, pair);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test MarketOHLCV
        /// </summary>
        [Test]
        public void MarketOHLCVTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //string pair = null;
            //int? limit = null;
            //int? interval = null;
            //string start = null;
            //string end = null;
            //var response = instance.MarketOHLCV(exchange, pair, limit, interval, start, end);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test MarketTicker
        /// </summary>
        [Test]
        public void MarketTickerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //string pair = null;
            //var response = instance.MarketTicker(exchange, pair);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test MarketTrades
        /// </summary>
        [Test]
        public void MarketTradesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //string pair = null;
            //int? limit = null;
            //string start = null;
            //string end = null;
            //var response = instance.MarketTrades(exchange, pair, limit, start, end);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test SpotRate
        /// </summary>
        [Test]
        public void SpotRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.SpotRate(symbol);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test SpotRateHistory
        /// </summary>
        [Test]
        public void SpotRateHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //int? limit = null;
            //string start = null;
            //string end = null;
            //var response = instance.SpotRateHistory(symbol, limit, start, end);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
        /// <summary>
        /// Test SpotRateOHLCV
        /// </summary>
        [Test]
        public void SpotRateOHLCVTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //int? limit = null;
            //int? interval = null;
            //string start = null;
            //string end = null;
            //var response = instance.SpotRateOHLCV(symbol, limit, interval, start, end);
            //Assert.IsInstanceOf<Empty> (response, "response is Empty");
        }
        
    }

}
