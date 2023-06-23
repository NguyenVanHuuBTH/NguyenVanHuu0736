using System.ComponentModel.DataAnnotations;

namespace NguyenVanHuu0736.Models;
public class NVHStudent
{
    [Key]
    public string? NVHStudentId { get; set; }

    
    public string? NVHStudentName { get; set; }

   
    public string? NVHStudentDIACHI { get; set; }


}
