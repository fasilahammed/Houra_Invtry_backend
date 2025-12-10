using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houra.Domain.Entities;
public enum UserRole : byte { SuperAdmin = 0, Admin = 1, Billing = 2, Sales = 3, Inventory = 4, Viewer = 5 }

public class User : BaseEntity
{
    public string FullName { get; set; } = null!;
    public string? Email { get; set; }
    public string PasswordHash { get; set; } = null!;
    public string? Phone { get; set; }
    public UserRole Role { get; set; }
    public bool IsActive { get; set; } = true;
}

