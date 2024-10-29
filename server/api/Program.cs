using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSingleton(StorageClient.Create(GoogleCredential.GetApplicationDefault()));


var app = builder.Build();

app.UseCors(config => config.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().SetIsOriginAllowed(_ => true));
app.MapControllers();
app.Run();
