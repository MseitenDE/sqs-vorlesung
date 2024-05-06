﻿using System.Text.RegularExpressions;

namespace PokemonLookup.Web.Services;

public partial class InputChecker : IInputChecker
{
    public bool IsUserInputValid(string input)
    {
        return CharacterWhitelist().IsMatch(input);
    }

    [GeneratedRegex("^[a-zA-Z0-9]+$", RegexOptions.Compiled)]
    private static partial Regex CharacterWhitelist();
}