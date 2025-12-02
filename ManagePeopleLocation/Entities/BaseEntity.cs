using System.ComponentModel.DataAnnotations;

namespace ManagePeopleLocation.Entities;

public class BaseEntity
{
    [Key]
    public long Id { get; set; }
}