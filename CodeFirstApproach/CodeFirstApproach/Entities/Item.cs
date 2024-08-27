using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Entities
{
    [PrimaryKey("Id")]
    public class Item
    {
        //This will help us auto generated Identity column 'Id' 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }      
        public int Quantity { get; set; }
    }
}
