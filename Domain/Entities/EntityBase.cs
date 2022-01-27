using System;
using System.ComponentModel.DataAnnotations;

namespace FirstWebProject.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "Summary")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title picture")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO meta tags Title")]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "SEO meta tags Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "SEO meta tags Keywords")]
        public virtual string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
