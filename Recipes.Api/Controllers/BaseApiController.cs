﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Recipes.Api.Controllers
{
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
