using System;

namespace Library.Data.Models
{
    public interface ILog 
    {
        short? IsActive { get; set; } 

        int? CreatedBy { get; set; }

        int? UpdatedBy { get; set; }

        DateTime? CreatedDate { get; set; }

        DateTime? LastUpdatedDate { get; set; }
    }
}