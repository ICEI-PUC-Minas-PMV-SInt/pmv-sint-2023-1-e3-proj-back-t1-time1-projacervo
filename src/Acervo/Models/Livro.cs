﻿using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;

namespace Acervo.Models
{
    public class Livro
    {
        [Key, MaxLength(30)]
        public Guid LivroId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public string Localizacao { get; set; }
        [Required]
        public DateTimeOffset AnoPublicacao { get; set; }
        [Required]
        public bool? Reservado { get; set; }
    }
}