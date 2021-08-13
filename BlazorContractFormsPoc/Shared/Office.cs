using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace BlazorContractFormsPoc.Shared
{
    public record Office
    {
        public bool Enabled { get; set; }

        public DateTime DateTime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string String { get; set; }
        
        public OfficeType OfficeType { get; set; }

        [Range(43, 44)]
        public int Int { get; set; }

        public ImmutableList<Person> Staff { get; init; } = ImmutableList<Person>.Empty;


    }

    public enum OfficeType
    {
        Fun,
        NotFun,
        Mordor
    }
}