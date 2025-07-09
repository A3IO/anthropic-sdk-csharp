using Anthropic = Anthropic;
using System = System;

namespace Anthropic.Tests;

public class TestBase
{
    protected Anthropic::IAnthropicClient client;

    public TestBase()
    {
        client = new Anthropic::AnthropicClient()
        {
            BaseUrl = new System::Uri(
                System::Environment.GetEnvironmentVariable("TEST_API_BASE_URL")
                    ?? "http://localhost:4010"
            ),
            APIKey = "my-anthropic-api-key",
        };
    }
}
