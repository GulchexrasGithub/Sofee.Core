﻿// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;

namespace Sofee.Core.Api.Tests.Acceptance.Brokers
{
    public partial class SofeeApiBroker
    {
        private readonly IRESTFulApiFactoryClient apiFactoryClient;

        public SofeeApiBroker()
        {
            WebApplicationFactory<Startup> webApplicationFactory = new WebApplicationFactory<Startup>();
            HttpClient httpClient = webApplicationFactory.CreateClient();
            this.apiFactoryClient = new RESTFulApiFactoryClient(httpClient);
        }
    }
}
