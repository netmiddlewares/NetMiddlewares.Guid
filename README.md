# NetMiddlewares.Guid

[![GitHub license](https://img.shields.io/github/license/netmiddlewares/NetMiddlewares.Guid)](https://github.com/netmiddlewares/NetMiddlewares.Guid)
[![Build Status](https://travis-ci.org/netmiddlewares/NetMiddlewares.Guid.svg?branch=master)](https://travis-ci.org/netmiddlewares/NetMiddlewares.Guid)
[![Nuget](https://buildstats.info/nuget/NetMiddlewares.Guid)](http://www.nuget.org/packages/NetMiddlewares.Guid)

.NET Core middleware to generate an Guid and add it to the Request and Response headers

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
    
    app.UseGuid();
    
    //...
}
  ```

Done!

From now on, everytime the pipeline is run, the request and the response will share an unique Guid under the "X-Guid" header.

The Guid is added to the request as it passes through the middleware and added to the response when the response is starting.
