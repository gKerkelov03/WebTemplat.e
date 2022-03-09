using System;
using System.ComponentModel.DataAnnotations;

namespace Template.Data.Common
{
    public abstract class BaseEntity<TKey> 
    {
        [Key]
        public TKey Id { get; set; }
    }
}
