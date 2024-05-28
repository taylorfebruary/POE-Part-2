using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace POE_Part_1.Models
{
    public class ContactForm : Controller
    {
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string Name { get; set; }

            [Required]
            [EmailAddress]
            [StringLength(100)]
            public string Email { get; set; }

            [Required]
            [StringLength(1000)]
            public string Message { get; set; }
        }
    }
