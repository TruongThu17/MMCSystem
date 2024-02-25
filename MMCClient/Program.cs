using Firebase.Storage;
using Microsoft.Extensions.Configuration;
using MMCSystemAPI.Config;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();

var firebaseConfig = new FirebaseConfig
{
    ApiKey = "AIzaSyB_VJL2H22gl4i0ZV7wOgs6CtiLb7Z63BM",
    AuthDomain = "mmcsytem.firebaseapp.com",
    ProjectId = "mmcsytem",
    StorageBucket = "mmcsytem.appspot.com",
    MessagingSenderId = "1051656781419",
    AppId = "1:1051656781419:web:a215ed53a0dccaf089fb2e",
    MeasurementId = "G-5LV7VV798C"
};
builder.Services.AddSingleton(firebaseConfig);

// Add Firebase Storage
builder.Services.AddSingleton<FirebaseStorage>(
    new FirebaseStorage(
        firebaseConfig.StorageBucket,
        new FirebaseStorageOptions
        {
            AuthTokenAsyncFactory = () => Task.FromResult("optional-auth-token"), // Add your authentication logic if needed
            ThrowOnCancel = true
        }
    )
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
