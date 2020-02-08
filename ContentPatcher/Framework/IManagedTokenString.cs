using System.Collections.Generic;
using ContentPatcher.Framework.Lexing.LexTokens;

namespace ContentPatcher.Framework
{
    /// <summary>A string value optionally containing tokens, including methods for managing its state.</summary>
    internal interface IManagedTokenString : IContextual, ITokenString
    {
        /*********
        ** Methods
        *********/
        /// <summary>The lexical tokens parsed from the raw string.</summary>
        IEnumerable<ILexToken> LexTokens { get; }

        /// <summary>Recursively get the token placeholders from the given lexical tokens.</summary>
        /// <param name="recursive">Whether to scan recursively.</param>
        IEnumerable<LexTokenToken> GetTokenPlaceholders(bool recursive);
    }
}
