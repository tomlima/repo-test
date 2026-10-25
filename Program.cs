// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string tokenApi = _configuration.GetSection("appsettings:TokenApi");
_service.Authentication(tokenApi);

_service.SendEmail();

_service.Notification();
