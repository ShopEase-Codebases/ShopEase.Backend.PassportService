﻿namespace ShopEase.Backend.PassportService.Core.Primitives
{
    /// <summary>
    /// Common Record for Error Handling
    /// </summary>
    /// <param name="Code"></param>
    /// <param name="Message"></param>
    public record Error(string Code, string Message)
    {
        public static readonly Error None = new(string.Empty, string.Empty);

        public static readonly Error NullValue = new("Error.NullValue", "The specified result value is null.");

        public static readonly Error ConditionNotMet = new("Error.ConditionNotMet", "The specified condition was not met.");
    }
}
