﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ApiInGames
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()

                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;

                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                })

            .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Senatur", Version = "v1" });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services

                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = "JwtBearer";
                    options.DefaultChallengeScheme = "JwtBearer";
                })

              .AddJwtBearer("JwtBearer", options =>
              {
                  options.TokenValidationParameters = new TokenValidationParameters
                  {
                      // Quem está solicitando
                      ValidateIssuer = true,

                      // Quem está validando
                      ValidateAudience = true,

                      // Definindo o tempo de expiração
                      ValidateLifetime = true,

                      // Forma de criptografia
                      IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("ingames-chave-autenticacao")),

                      // Tempo de expiração do token
                      ClockSkew = TimeSpan.FromMinutes(30),

                      // Nome da issuer, de onde está vindo
                      ValidIssuer = "ApiInGames",

                      // Nome da audience, de onde está vindo
                      ValidAudience = "ApiInGames"
                  };
              });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "InGames V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseMvc();
        }
    }
}
