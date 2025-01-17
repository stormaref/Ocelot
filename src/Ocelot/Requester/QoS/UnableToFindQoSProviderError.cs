﻿namespace Ocelot.Requester.QoS
{
    using Errors;

    public class UnableToFindQoSProviderError : Error
    {
        public UnableToFindQoSProviderError(string message)
            : base(message, OcelotErrorCode.UnableToFindQoSProviderError, 404)
        {
        }
    }
}
