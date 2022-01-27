using System.ComponentModel.DataAnnotations;

namespace FirstWebProject.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Enter the service name")]
        [Display(Name = "Service name")]
        public override string Title { get; set; }

        [Display(Name = "Summary")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public override string Text { get; set; }
    }
}
