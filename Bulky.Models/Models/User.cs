using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models;

public class User : IdentityUser
{
    [Required]
    public string Name { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;    

    public string State { get; set; } = string.Empty;
}
