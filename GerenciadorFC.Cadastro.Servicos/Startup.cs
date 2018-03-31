﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorFC.Cadastro.Servicos.JwtModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;

namespace GerenciadorFC.Cadastro.Servicos
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
			.AddJwtBearer(options => {
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					RequireExpirationTime = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = "http://localhost:12796",
					ValidAudience = "http://localhost:12796",
					IssuerSigningKey = JwtSecurtyKey.Create("a-password-very-big-to-be-good")
				};

				options.Events = new JwtBearerEvents
				{
					OnAuthenticationFailed = context =>
					{
						Console.WriteLine("OnAuthenticationFailed: " + context.Exception.Message);
						return Task.CompletedTask;
					},
					OnTokenValidated = context =>
					{
						Console.WriteLine("OnTokenValidated: " + context.SecurityToken);
						return Task.CompletedTask;
					}
				};
			});

			services.AddMvc();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Info { Title = "Cadastro", Version = "v1" });
			});
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
			//if (env.IsDevelopment())
			//{
			//    app.UseDeveloperExceptionPage();
			//}
			app.UseAuthentication();
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
			});
			app.UseMvc();
        }
    }
}
