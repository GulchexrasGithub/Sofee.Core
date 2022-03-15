﻿using System;
using Xeptions;

namespace Sofee.Core.Api.Models.Languages.Exceptions
{
    public class NotFoundLanguageException : Xeption
    {
        public NotFoundLanguageException(Guid languageId) 
            : base(message: $"Couldn't find language with id: {languageId}.") 
        { }
    }
}
