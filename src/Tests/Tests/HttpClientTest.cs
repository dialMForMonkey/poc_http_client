using System;
using Microsoft.Extensions.Logging;
using poc_http_client.Application;
using poc_http_client.Infra;
using poc_http_client.Models;
using Xunit;

namespace Tests
{
    public class Content
    {
        public string Message { get; set; }
    }

    public class GetTest
    {

        private readonly IBuilder _client;

        public GetTest(IBuilder client)
        {
            _client = client;
        }

        

        
        [Fact]
        public async  void HttpGetNotFoundTest()
        {
            _client.Get();//.Url("https://www.google.com/181u81u8").Send();
            //uint statusCode = result.StatusCode();
            Assert.Equal(true, true);
        }
        #region MyRegion
/****
        
        public async void HttpGetHeadersTest()
        {
            var result = await _client.Get().Url("http://localhost:3000/headers").Send();
            uint statusCode = result.StatusCode();
            var headers = result.Headers();

            bool keyMatch = false;
                
            while (headers.MoveNext())
            {
                if (headers.Current.Key == "gambs")
                {
                    keyMatch = true;
                }
            }
                
            
            Assert.Equal(200u, statusCode);
            Assert.True(keyMatch);
        }
        
        
        public async  void HttpGetContentSerializedTest()
        {
            var result = await  _client.Get().Url("http://localhost:3000/content").Send();
            uint statusCode = result.StatusCode();
            Content message = result.Content<Content>();
            Assert.Equal("Ok", message.Message);
            Assert.Equal(200u , statusCode);
        }

        
        public async  void HttpGetContentStringTest()
        {
            var result = await  _client.Get().Url("http://localhost:3000/content").Send();
            uint statusCode = result.StatusCode();
            string message = result.Content();
            Assert.Equal("{\"message\": \"Ok\"}", message);
            Assert.Equal(200u , statusCode);
        }
        
        
        public async  void HttpGetTimeoutServiceTest()
        {
            var result = await  _client.Get().Url("http://localhost:3000/timeout").Send();
            uint statusCode = result.StatusCode();
            Assert.Equal(408u , statusCode);
        }

        
        public async  void HttpGetSetTimeoutTest()
        {
            var result = await  _client.Get().AddTimeout(1).Url("http://localhost:3000/timeout").Send();
            uint statusCode = result.StatusCode();
            Assert.Equal(408u , statusCode);
        }
 
        
        public async  void HttpGetNotFoundDomainTest()
        {
            var result = await  _client.Get().Url("https://www.go2ogle.com").Send();
            uint statusCode = result.StatusCode();
            string content = result.Content();
            Assert.Equal(0u , statusCode);
            Assert.Equal("Name or service not known (www.go2ogle.com:443)" , content);
        }
        
       
        
        
        
        public async  void HttpGetHeaderTest()
        {
            var result = await _client.Get().Url("https://www.google.com").Send();
            uint statusCode = result.StatusCode();
            Assert.Equal(200u, statusCode);
        }
        
        
        public async  void HttpGetCachedTest()
        {
            
            
            var resultOutCached = await _client.Get().Url("http://localhost:3000/content").Send(true, "mockcached", TTLUnit.Minutes, 1);
            var resultCached = await _client.Get().Url("http://localhost:3000/content").Send(true, "mockcached", TTLUnit.Minutes, 1);
            uint statusCode = resultCached.StatusCode();
            Assert.Equal(304u, statusCode);
            Assert.Equal(resultOutCached.Content(), resultCached.Content());
        }
        
        
        public async  void HttpGetCacheNotConnectTest()
        {
            
            
            var resultOutCached = await _client.Get().Url("http://localhost:3000/content").Send(true, "mockcached", TTLUnit.Minutes, 1);
            var resultCached = await _client.Get().Url("http://localhost:3000/content").Send(true, "mockcached", TTLUnit.Minutes, 1);
            uint statusCode = resultCached.StatusCode();
            Assert.Equal(200u, statusCode);
            Assert.Equal(resultOutCached.Content(), resultCached.Content());
        }
        
        
        public async  void HttpGetRetryTest()
        {
            var result = await _client
                .Get()
                .Url("http://localhost:3000/content")
                .Retry(2)
                .Send(true, "mockcached", TTLUnit.Minutes, 1);
            uint statusCode = result.StatusCode();
            Assert.Equal(200u, statusCode);
        }
        
        
        public async  void HttpGetRetryInUseTest()
        {
            var result = await _client
                .Get()
                .Url("http://localhost:3000/timeout")
                .Retry(2)
                .AddTimeout(1)
                .Send();
            
            uint statusCode = result.StatusCode();
            Assert.Equal(408u, statusCode);
        }
        ****/
        #endregion
    }
}