using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CricketersWebApi.DAL.Entities
{
    public abstract class ReportingBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}