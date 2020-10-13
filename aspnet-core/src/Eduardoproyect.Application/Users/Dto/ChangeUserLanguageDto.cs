using System.ComponentModel.DataAnnotations;

namespace Eduardoproyect.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}