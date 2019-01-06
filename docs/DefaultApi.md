# BlockMarkets.Rest.Api.DefaultApi

All URIs are relative to *https://api.blockmarkets.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BenchmarkRate**](DefaultApi.md#benchmarkrate) | **GET** /v1/rates/benchmark/{symbol} | Returns the latest available benchmark rates for a specific asset.
[**BenchmarkRateHistory**](DefaultApi.md#benchmarkratehistory) | **GET** /v1/rates/benchmark/{symbol}/history | Returns historical benchmark rates for an asset. Requires premium subscription.
[**ListAssetMarkets**](DefaultApi.md#listassetmarkets) | **GET** /v1/assets/{symbol} | Returns a list of all markets (base and quote) for a specific asset.
[**ListAssets**](DefaultApi.md#listassets) | **GET** /v1/assets | Returns a list of supported assets.
[**ListBenchmarkRates**](DefaultApi.md#listbenchmarkrates) | **GET** /v1/rates/benchmark | Returns a list of supported USD benchmark rates.
[**ListExchangeMarkets**](DefaultApi.md#listexchangemarkets) | **GET** /v1/exchanges/{exchange} | Returns a list of markets for a specific exchange.
[**ListExchanges**](DefaultApi.md#listexchanges) | **GET** /v1/exchanges | Returns a list of supported exchanges.
[**ListMarkets**](DefaultApi.md#listmarkets) | **GET** /v1/markets | Returns a list of supported markets.
[**ListPairMarkets**](DefaultApi.md#listpairmarkets) | **GET** /v1/pairs/{pair} | Returns a list of markets for a specific asset pair.
[**ListPairs**](DefaultApi.md#listpairs) | **GET** /v1/pairs | Returns a list of supported asset pairs.
[**ListSpotRates**](DefaultApi.md#listspotrates) | **GET** /v1/rates/spot | Returns a list of supported USD spot rates.
[**MarketBook**](DefaultApi.md#marketbook) | **GET** /v1/markets/{exchange}/{pair}/book | Returns the top 50 bids and asks from the current order book for a market pair. Requires premium subscription.
[**MarketOHLCV**](DefaultApi.md#marketohlcv) | **GET** /v1/markets/{exchange}/{pair}/ohlcv | Returns OHLCV history for a market pair.
[**MarketTicker**](DefaultApi.md#marketticker) | **GET** /v1/markets/{exchange}/{pair} | Returns the latest ticker for a market pair.
[**MarketTrades**](DefaultApi.md#markettrades) | **GET** /v1/markets/{exchange}/{pair}/trades | Returns trades for a market pair. Requires premium subscription.
[**SpotRate**](DefaultApi.md#spotrate) | **GET** /v1/rates/spot/{symbol} | Returns the last USD spot rate for an asset.
[**SpotRateHistory**](DefaultApi.md#spotratehistory) | **GET** /v1/rates/spot/{symbol}/history | Returns historical spot rates for an asset. Requires premium subscription.
[**SpotRateOHLCV**](DefaultApi.md#spotrateohlcv) | **GET** /v1/rates/spot/{symbol}/ohlcv | Returns the OHLCV history for a spot rate.


<a name="benchmarkrate"></a>
# **BenchmarkRate**
> Empty BenchmarkRate (string symbol)

Returns the latest available benchmark rates for a specific asset.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class BenchmarkRateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var symbol = symbol_example;  // string | The asset symbol (see /assets)

            try
            {
                // Returns the latest available benchmark rates for a specific asset.
                Empty result = apiInstance.BenchmarkRate(symbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.BenchmarkRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The asset symbol (see /assets) | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="benchmarkratehistory"></a>
# **BenchmarkRateHistory**
> Empty BenchmarkRateHistory (string symbol, string close = null)

Returns historical benchmark rates for an asset. Requires premium subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class BenchmarkRateHistoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var symbol = symbol_example;  // string | The asset symbol (see /assets)
            var close = close_example;  // string | The closing time. Options - 4pm-gmt-close, 4pm-est-close, 0-utc-close (optional) 

            try
            {
                // Returns historical benchmark rates for an asset. Requires premium subscription.
                Empty result = apiInstance.BenchmarkRateHistory(symbol, close);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.BenchmarkRateHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The asset symbol (see /assets) | 
 **close** | **string**| The closing time. Options - 4pm-gmt-close, 4pm-est-close, 0-utc-close | [optional] 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listassetmarkets"></a>
# **ListAssetMarkets**
> Empty ListAssetMarkets (string symbol)

Returns a list of all markets (base and quote) for a specific asset.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListAssetMarketsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var symbol = symbol_example;  // string | The asset symbol (see /assets)

            try
            {
                // Returns a list of all markets (base and quote) for a specific asset.
                Empty result = apiInstance.ListAssetMarkets(symbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAssetMarkets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The asset symbol (see /assets) | 

### Return type

[**Empty**](Empty.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listassets"></a>
# **ListAssets**
> Empty ListAssets ()

Returns a list of supported assets.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListAssetsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // Returns a list of supported assets.
                Empty result = apiInstance.ListAssets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbenchmarkrates"></a>
# **ListBenchmarkRates**
> Empty ListBenchmarkRates ()

Returns a list of supported USD benchmark rates.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListBenchmarkRatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // Returns a list of supported USD benchmark rates.
                Empty result = apiInstance.ListBenchmarkRates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListBenchmarkRates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listexchangemarkets"></a>
# **ListExchangeMarkets**
> Empty ListExchangeMarkets (string exchange)

Returns a list of markets for a specific exchange.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListExchangeMarketsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var exchange = exchange_example;  // string | The 4-char exchange code (see /exchanges)

            try
            {
                // Returns a list of markets for a specific exchange.
                Empty result = apiInstance.ListExchangeMarkets(exchange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListExchangeMarkets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exchange** | **string**| The 4-char exchange code (see /exchanges) | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listexchanges"></a>
# **ListExchanges**
> Empty ListExchanges ()

Returns a list of supported exchanges.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListExchangesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // Returns a list of supported exchanges.
                Empty result = apiInstance.ListExchanges();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListExchanges: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmarkets"></a>
# **ListMarkets**
> Empty ListMarkets ()

Returns a list of supported markets.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListMarketsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // Returns a list of supported markets.
                Empty result = apiInstance.ListMarkets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListMarkets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpairmarkets"></a>
# **ListPairMarkets**
> Empty ListPairMarkets (string pair)

Returns a list of markets for a specific asset pair.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListPairMarketsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var pair = pair_example;  // string | The asset pair (see /pairs)

            try
            {
                // Returns a list of markets for a specific asset pair.
                Empty result = apiInstance.ListPairMarkets(pair);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListPairMarkets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pair** | **string**| The asset pair (see /pairs) | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpairs"></a>
# **ListPairs**
> Empty ListPairs ()

Returns a list of supported asset pairs.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListPairsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // Returns a list of supported asset pairs.
                Empty result = apiInstance.ListPairs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListPairs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listspotrates"></a>
# **ListSpotRates**
> Empty ListSpotRates ()

Returns a list of supported USD spot rates.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class ListSpotRatesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // Returns a list of supported USD spot rates.
                Empty result = apiInstance.ListSpotRates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ListSpotRates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="marketbook"></a>
# **MarketBook**
> Empty MarketBook (string exchange, string pair)

Returns the top 50 bids and asks from the current order book for a market pair. Requires premium subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class MarketBookExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var exchange = exchange_example;  // string | The 4-char exchange code (see /exchanges)
            var pair = pair_example;  // string | The asset pair (see /pairs)

            try
            {
                // Returns the top 50 bids and asks from the current order book for a market pair. Requires premium subscription.
                Empty result = apiInstance.MarketBook(exchange, pair);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.MarketBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exchange** | **string**| The 4-char exchange code (see /exchanges) | 
 **pair** | **string**| The asset pair (see /pairs) | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="marketohlcv"></a>
# **MarketOHLCV**
> Empty MarketOHLCV (string exchange, string pair, int? limit = null, int? interval = null, string start = null, string end = null)

Returns OHLCV history for a market pair.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class MarketOHLCVExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var exchange = exchange_example;  // string | The 4-char exchange code (see /exchanges)
            var pair = pair_example;  // string | The asset pair (see /pairs)
            var limit = 56;  // int? | Number of records to retrieve (default=100, max=1000) (optional) 
            var interval = 56;  // int? | Interval period in minutes. Supported - 1,3,5,15,30,60,1440 (default=1440) (optional) 
            var start = start_example;  // string | Start datetime in ISO 8601 (optional) 
            var end = end_example;  // string | End datetime in ISO 8601 (optional) 

            try
            {
                // Returns OHLCV history for a market pair.
                Empty result = apiInstance.MarketOHLCV(exchange, pair, limit, interval, start, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.MarketOHLCV: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exchange** | **string**| The 4-char exchange code (see /exchanges) | 
 **pair** | **string**| The asset pair (see /pairs) | 
 **limit** | **int?**| Number of records to retrieve (default&#x3D;100, max&#x3D;1000) | [optional] 
 **interval** | **int?**| Interval period in minutes. Supported - 1,3,5,15,30,60,1440 (default&#x3D;1440) | [optional] 
 **start** | **string**| Start datetime in ISO 8601 | [optional] 
 **end** | **string**| End datetime in ISO 8601 | [optional] 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="marketticker"></a>
# **MarketTicker**
> Empty MarketTicker (string exchange, string pair)

Returns the latest ticker for a market pair.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class MarketTickerExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var exchange = exchange_example;  // string | The 4-char exchange code (see /exchanges)
            var pair = pair_example;  // string | The asset pair (see /pairs)

            try
            {
                // Returns the latest ticker for a market pair.
                Empty result = apiInstance.MarketTicker(exchange, pair);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.MarketTicker: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exchange** | **string**| The 4-char exchange code (see /exchanges) | 
 **pair** | **string**| The asset pair (see /pairs) | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markettrades"></a>
# **MarketTrades**
> Empty MarketTrades (string exchange, string pair, int? limit = null, string start = null, string end = null)

Returns trades for a market pair. Requires premium subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class MarketTradesExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var exchange = exchange_example;  // string | The 4-char exchange code (see /exchanges)
            var pair = pair_example;  // string | The asset pair (see /pairs)
            var limit = 56;  // int? | Number of records to retrieve (default=100, max=1000) (optional) 
            var start = start_example;  // string | Start datetime in ISO 8601 (optional) 
            var end = end_example;  // string | End datetime in ISO 8601 (optional) 

            try
            {
                // Returns trades for a market pair. Requires premium subscription.
                Empty result = apiInstance.MarketTrades(exchange, pair, limit, start, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.MarketTrades: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exchange** | **string**| The 4-char exchange code (see /exchanges) | 
 **pair** | **string**| The asset pair (see /pairs) | 
 **limit** | **int?**| Number of records to retrieve (default&#x3D;100, max&#x3D;1000) | [optional] 
 **start** | **string**| Start datetime in ISO 8601 | [optional] 
 **end** | **string**| End datetime in ISO 8601 | [optional] 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spotrate"></a>
# **SpotRate**
> Empty SpotRate (string symbol)

Returns the last USD spot rate for an asset.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class SpotRateExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var symbol = symbol_example;  // string | The asset symbol (see /assets)

            try
            {
                // Returns the last USD spot rate for an asset.
                Empty result = apiInstance.SpotRate(symbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SpotRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The asset symbol (see /assets) | 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spotratehistory"></a>
# **SpotRateHistory**
> Empty SpotRateHistory (string symbol, int? limit = null, string start = null, string end = null)

Returns historical spot rates for an asset. Requires premium subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class SpotRateHistoryExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var symbol = symbol_example;  // string | The asset symbol (see /assets)
            var limit = 56;  // int? | Number of records to retrieve (default=100, max=1000) (optional) 
            var start = start_example;  // string | Start datetime in ISO 8601 (optional) 
            var end = end_example;  // string | End datetime in ISO 8601 (optional) 

            try
            {
                // Returns historical spot rates for an asset. Requires premium subscription.
                Empty result = apiInstance.SpotRateHistory(symbol, limit, start, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SpotRateHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The asset symbol (see /assets) | 
 **limit** | **int?**| Number of records to retrieve (default&#x3D;100, max&#x3D;1000) | [optional] 
 **start** | **string**| Start datetime in ISO 8601 | [optional] 
 **end** | **string**| End datetime in ISO 8601 | [optional] 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spotrateohlcv"></a>
# **SpotRateOHLCV**
> Empty SpotRateOHLCV (string symbol, int? limit = null, int? interval = null, string start = null, string end = null)

Returns the OHLCV history for a spot rate.

### Example
```csharp
using System;
using System.Diagnostics;
using BlockMarkets.Rest.Api;
using BlockMarkets.Rest.Client;
using BlockMarkets.Rest.Model;

namespace Example
{
    public class SpotRateOHLCVExample
    {
        public void main()
        {
            // Configure API key authorization: api_key
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DefaultApi();
            var symbol = symbol_example;  // string | The asset symbol (see /assets)
            var limit = 56;  // int? | Number of records to retrieve (default=100, max=1000) (optional) 
            var interval = 56;  // int? | Interval period in minutes. Supported -  1,3,5,15,30,60,1440 (default=1440) (optional) 
            var start = start_example;  // string | Start datetime in ISO 8601 (optional) 
            var end = end_example;  // string | End datetime in ISO 8601 (optional) 

            try
            {
                // Returns the OHLCV history for a spot rate.
                Empty result = apiInstance.SpotRateOHLCV(symbol, limit, interval, start, end);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SpotRateOHLCV: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The asset symbol (see /assets) | 
 **limit** | **int?**| Number of records to retrieve (default&#x3D;100, max&#x3D;1000) | [optional] 
 **interval** | **int?**| Interval period in minutes. Supported -  1,3,5,15,30,60,1440 (default&#x3D;1440) | [optional] 
 **start** | **string**| Start datetime in ISO 8601 | [optional] 
 **end** | **string**| End datetime in ISO 8601 | [optional] 

### Return type

[**Empty**](Empty.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

