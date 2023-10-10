using DomainLayer.EF.Models;
using System;
using System.Collections.Generic;

namespace DomainLayer.EF.EntityModel;

public partial class Student: BaseEntity
{
    public int Id { get; set; }

    public Guid? StudentUniqueId { get; set; }

    public string Name { get; set; } = null!;

    public int Roll { get; set; }

    public string Address { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public Guid? UpdateBy { get; set; }
}
