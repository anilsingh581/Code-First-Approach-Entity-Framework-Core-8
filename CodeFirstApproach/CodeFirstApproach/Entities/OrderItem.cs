using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Entities
{
    [PrimaryKey("Id")]
    public class OrderItem
    {
        public int Id { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }
        //This is virtual Item and Entity framwork will use to perform CRUD operation.
        public virtual Item Item { get; set; }


        [ForeignKey("Order")]
        public int OrderId { get; set; }
        //This is virtual Order and Entity framwork will use to perform CRUD operation.
        public virtual Order Order { get; set; }

    }
}
