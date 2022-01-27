using System.ComponentModel.DataAnnotations;

namespace FirstWebProject.Domain.Entities
{
    public class TextField : EntityBase
    {
        public string CodeWord { get; set; }

        [Display(Name = "Title")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Full description")]
        public override string Text { get; set; } = "Сontent to be filled by administrator";
    }
}
