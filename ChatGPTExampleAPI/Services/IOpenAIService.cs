namespace ChatGPTExampleAPI.Services;

public interface IOpenAIService
{
    Task<string> ComplateSentece(string text);
}