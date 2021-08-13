using System.ComponentModel.DataAnnotations;

namespace BlazorContractFormsPoc.Shared
{
    public record Person
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
    }
}