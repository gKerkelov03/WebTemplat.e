using System;
using System.ComponentModel.DataAnnotations;

namespace Template.Data.Common
{
    public abstract class BaseModel<TKey> 
    {
        [Key]
        public TKey Id { get; set; }
    }
}
