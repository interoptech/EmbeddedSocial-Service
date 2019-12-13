﻿// <copyright file="PostSessionResponse.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace SocialPlus.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Response from post (create) session
    /// </summary>
    public class PostSessionResponse
    {
        /// <summary>
        /// Gets or sets user handle
        /// </summary>
        [Required]
        public string UserHandle { get; set; }

        /// <summary>
        /// Gets or sets session token generated by our server.
        /// The client saves the session token and sends it with every request
        /// </summary>
        [Required]
        public string SessionToken { get; set; }
    }
}