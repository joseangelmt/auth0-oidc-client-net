﻿using System;
using System.Security.Claims;

namespace Auth0.OidcClient.Tokens
{
    /// <summary>
    /// Identity token validation requirements for use with <see cref="IdTokenValidator"/>.
    /// </summary>
    internal class IdTokenRequirements
    {
        /// <summary>
        /// Required issuer (iss) the token must be from.
        /// </summary>
        public string Issuer;

        /// <summary>
        /// Required audience (aud) the token must be for.
        /// </summary>
        public string Audience;

        /// <summary>
        /// Optional one-time nonce the token must be issued in response to.
        /// </summary>
        public string Nonce;

        /// <summary>
        /// Optional maximum time since the user last authenticated.
        /// </summary>
        public TimeSpan? MaxAge = null;

        /// <summary>
        /// Amount of leeway to allow in validating date and time claims in order to allow some clock variance
        /// between the issuer and the application.
        /// </summary>
        public TimeSpan Leeway;

        /// <summary>
        /// Required organization the token must be for.
        /// </summary>
        /// <remarks>
        /// - If you provide an Organization ID (a string with the prefix `org_`), it will be validated against the `org_id` claim of your user's ID Token. The validation is case-sensitive.
        /// - If you provide an Organization Name (a string *without* the prefix `org_`), it will be validated against the `org_name` claim of your user's ID Token. The validation is case-insensitive.
        /// </remarks>
        public string Organization;

        /// <summary>
        /// Create a new instance of <see cref="IdTokenRequirements"/> with specified parameters.
        /// </summary>
        /// <param name="issuer">Required issuer (iss) the token must be from.</param>
        /// <param name="audience">Required audience (aud) the token must be for.</param>
        /// <param name="leeway">Amount of leeway in validating date and time claims to allow some clock variance
        /// between the issuer and the application.</param>
        /// <param name="maxAge">Optional maximum time since the user last authenticated.</param>
        public IdTokenRequirements(string issuer, string audience, TimeSpan leeway, TimeSpan ? maxAge = null, string organization = null)
        {
            Issuer = issuer;
            Audience = audience;
            Leeway = leeway;
            MaxAge = maxAge;
            Organization = organization;
        }
    }
}
