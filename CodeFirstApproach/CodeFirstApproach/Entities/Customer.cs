using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Entities
{
    [PrimaryKey("Id")]
    public class Customer
    {
        //This will help us auto generated Identity column 'Id' 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }            
    }
}
