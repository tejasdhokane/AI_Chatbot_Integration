# AI CHATBOT INTEGRATION

COMPANY: CODTECH IT SOLUTIONS

NAME:TEJAS DHOKANE

INTERN ID:CT08GIN

DOMAIN: .Net Web Development

DURATION: 4 WEEKS

MENTOR: NEELA SANTOSH

DISCRIPTION: In this AI chatbot integration demo, the goal is to build a basic chatbot functionality using .NET 8 MVC, Entity Framework, and a third-party AI service like OpenAI. We begin by creating a new ASP.NET Core MVC application with the .NET 8 framework and install required NuGet packages for Entity Framework Core and OpenAI API (or any other AI provider). The first step is to set up the database model for storing chat history, with a ChatHistory class containing properties such as Id, UserMessage, BotResponse, and Timestamp. We configure Entity Framework Core in ApplicationDbContext to manage the database connection, setting the connection string in appsettings.json for SQL Server. The next step is implementing the chatbot's core functionality with a ChatbotService class that communicates with the chosen AI API (such as OpenAI). This service will send the user's message and receive a generated response, which will be returned to the application. After that, the controller (ChatbotController) is implemented, which has methods to handle user input and interactions. The Index action fetches and displays recent chat histories from the database, while the SendMessage action processes the user's message, retrieves the AI response, saves both messages in the database, and redirects back to the main chat page. The chat interface is created in the Index.cshtml view, which includes a form for sending messages and displays the chat history for both user and bot messages. This view utilizes a simple HTML structure to allow users to input messages and see past conversations, making the chatbot interactive. The application is run locally, testing the interaction between the user, chatbot, and the database. The chatbot's core AI logic is implemented through the integration of the AI service, where we set parameters like MaxTokens and Prompt to control how the responses are generated. The result is an interactive chatbot application that stores and displays previous conversations, providing an excellent foundation for further development like user authentication, real-time updates, or more advanced AI integrations. The entire system uses Entity Framework to handle persistent data storage, ensuring that all interactions are saved in the database and retrievable later. Overall, this implementation demonstrates how to integrate AI chatbot functionality into a modern .NET 8 web application using MVC architecture and the Entity Framework for database management, providing an end-to-end solution from front-end interaction to back-end storage.

OUTPUT : 
![Image](https://github.com/user-attachments/assets/c2a7968c-72da-4b53-a6d6-1d78e487dd0c)


 
