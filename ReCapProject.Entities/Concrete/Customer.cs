using ReCapProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ReCapProject.Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }

        // Customers sınıfının Users ile ilişkisi
        public virtual User User { get; set; }
    }
}
