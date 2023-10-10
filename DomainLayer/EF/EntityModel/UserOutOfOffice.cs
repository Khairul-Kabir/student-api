using DomainLayer.EF.Models;
using System;
using System.Collections.Generic;

namespace DomainLayer.EF.EntityModel;

public partial class UserOutOfOffice: BaseEntity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public bool IsActive { get; set; }

    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
