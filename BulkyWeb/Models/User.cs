using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace BulkyWeb.Models;

public class User : IdentityUser
{
    [Required]
    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string State {  get; set; }
}
