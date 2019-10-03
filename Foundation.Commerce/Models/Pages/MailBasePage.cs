using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Foundation.Cms.Pages;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Commerce.Models.Pages
{
    public abstract class MailBasePage : FoundationPageData
    {
        [CultureSpecific]
        [Display(
            Name = "Mail Title",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string MailTitle { get; set; }
    }
}