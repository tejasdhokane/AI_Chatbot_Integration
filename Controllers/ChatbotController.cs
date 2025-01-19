using Microsoft.AspNetCore.Mvc;
using OpenAI.API;
using OpenAI.API.Completions;

namespace AI_Chatbot_Integration.Controllers
{
    public class ChatbotController : Controller
    {
        private readonly OpenAIAPI _openAiApi;

        public ChatbotController()
        {
            // Initialize OpenAI API with your API key
            _openAiApi = new OpenAIAPI("your-openai-api-key");
        }

        // GET: Chatbot
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> GetResponse(string userMessage)
        {
            if (string.IsNullOrEmpty(userMessage))
            {
                return Json(new { error = "Message cannot be empty" });
            }

            try
            {
                // Get the chat completion response from GPT model
                var result = await GetAiResponseAsync(userMessage);
                return Json(new { response = result });
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        private async Task<string> GetAiResponseAsync(string userMessage)
        {
            var chatRequest = new CompletionRequest
            {
                Prompt = userMessage,
                MaxTokens = 150,
                Temperature = 0.7,
                Model = "gpt-3.5-turbo"
            };

            var result = await _openAiApi.Completions.CreateCompletionAsync(chatRequest);
            return result.Completions[0].Text.Trim();
        }
    }
}
