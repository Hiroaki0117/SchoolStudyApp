using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudyApp
{
    internal class OpenAIClass
    {

        public static async Task<string> getOpenAIResponse(string prompt)
        {
            var responseContent = "";
            var openAIApi = new OpenAI_API.OpenAIAPI("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");
            //var openAIService = new OpenAIService(new OpenAiOptions()
            //{
            //    ApiKey = "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"
            //});

            var chat = openAIApi.Chat.CreateConversation();


            //var result = openAIService.Completions.CreateCompletionAsStream(new CompletionCreateRequest
            //{
            //    Prompt = prompt,
            //    Echo = false,
            //    MaxTokens = 1000
            //}, Models.TextDavinciV3);

            chat.AppendUserInput(prompt);

            string response = await chat.GetResponseFromChatbotAsync();

            if (response != null)
            {
                responseContent = response;
                return responseContent;
            }
            else
            {
                return null;
            }


            //if (result.)
            //{
            //    responseContent = result.Choices.Select(x => x.Text).FirstOrDefault();
            //}
            //else
            //{
            //    return null;
            //}
            //return responseContent;
        }
    }
}
