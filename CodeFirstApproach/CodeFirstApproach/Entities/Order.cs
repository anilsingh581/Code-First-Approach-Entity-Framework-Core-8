using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace CodeFirstApproach.Entities
{
    [PrimaryKey("OrderId")]
    public class Order
    {
        //This will help us auto generated Identity column 'OrderId' 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public int Amount { get; set; }


        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        //This is virtual Customer and Entity framwork will use to perform CRUD operation.
        public virtual Customer Customer { get; set; } 
    }
}
