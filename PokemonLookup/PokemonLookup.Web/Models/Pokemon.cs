﻿using System.ComponentModel.DataAnnotations;

namespace PokemonLookup.Web.Models;

public class Pokemon
{
    [Key]
    [MaxLength(20)]
    public required string Name { get; set; }

    public required int Id { get; set; }
    public required int Height { get; set; }
    public required int Weight { get; set; }
}