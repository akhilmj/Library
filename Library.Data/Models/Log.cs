using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    public abstract class Log : IValidatableObject, ILog
    {
        public virtual short? IsActive { get; set; }

        public int? CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual Users user1 { get; set; }


        public  int? UpdatedBy { get; set; }
        [ForeignKey("UpdatedBy")]
        public virtual Users user2 { get; set; }

        public  DateTime? CreatedDate { get; set; }

        public  DateTime? LastUpdatedDate { get; set; }

        public Log()
        {
            IsActive = 1;
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }

    }
}
