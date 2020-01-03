# NetMiddlewares.Core.Guid
.NET Core middleware to genearet an Guid and add it to the Request and Response headers

# How to use

## Step 1 - Add the middleware to the services declaration

```
public void ConfigureServices(IServiceCollection services)
{
    //...
    services.AddGuid();
}
  ```
  
  ## Step 2 - Add the middleware to the pipeline

```
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    //...
    
    app.UseUuid();
    
    //...
}
  ```
  
  Done!
