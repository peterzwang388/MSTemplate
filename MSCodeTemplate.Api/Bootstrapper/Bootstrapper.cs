using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Nancy.Bootstrappers.Autofac;
using Nancy.Bootstrapper;
using Nancy.Responses;
using Nancy;
using Nancy.Extensions;
using MSCodeTemplate.Api.Services;
using MSCodeTemplate.Api.Services.Interfaces;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using MSCodeTemplate.Api.Bootstrapper.Utils;
using Nancy.Diagnostics;
using MSCodeTemplate.Api.Models;

namespace MSCodeTemplate.Api.Bootstrapper
{
    public class Bootstrapper : AutofacNancyBootstrapper
    {
        protected async override void ApplicationStartup(ILifetimeScope container,
            IPipelines pipelines)
        {
            pipelines.BeforeRequest += (ctx) =>
            {
                Guid correlationId;
                if (!Guid.TryParse(ctx.Request.Headers["CorrelationId"].FirstOrDefault(), out correlationId))
                    correlationId = Guid.NewGuid();

                CorrelationId.Update(correlationId);

                return null;
            };


        }

        protected override void RequestStartup(ILifetimeScope container, IPipelines pipelines, NancyContext context)
        {

            pipelines.BeforeRequest += PreProcess;

            pipelines.AfterRequest += PostProcess;
            base.RequestStartup(container, pipelines, context);
        }

        private void PostProcess(NancyContext context)
        {
            // Logging here
        }

        private Response PreProcess(NancyContext context)
        {

            // do GUID correlationId here
            // Use logging machinism here
            return null;
        }

        protected override void ConfigureApplicationContainer(ILifetimeScope existingContainer)
        {
            base.ConfigureApplicationContainer(existingContainer);

            existingContainer.Update(builder =>
            {

                //Database context factory injection here, following is an example one
                builder.RegisterType<DbContextFactory>()
                        .As<IDbContextFactory>()
                       .InstancePerLifetimeScope();


                //business logic service injection here, following is an example one
                builder.RegisterType<TemplateService>()
                       .As<ITemplateService>()
                       .InstancePerLifetimeScope();
                // Logging helper injection here
                // Message queue helper/service injection here

            });
        }


        protected override void ConfigureRequestContainer(ILifetimeScope container, NancyContext context)
        {
            base.ConfigureRequestContainer(container, context);

            container.Update(builder =>
            {

            });
        }

     
    }
}