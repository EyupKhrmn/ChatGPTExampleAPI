using ChatGPTExampleAPI.Configuration;
using Microsoft.Extensions.Options;
using OpenAI_API;

namespace ChatGPTExampleAPI.Services;

public class OpenAIService : IOpenAIService
{
    private readonly OpenAIConfig _config;

    public OpenAIService(IOptionsMonitor<OpenAIConfig> config)
    {
        _config = config.CurrentValue;
    }

    public async Task<string> ComplateSentece(string text)
    {
        var api = new OpenAIAPI(_config.Key);
        var result = await api.Completions.GetCompletion(text);
        return result;
    }
}