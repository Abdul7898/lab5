using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Model.Entities
{
    [Table("Student")]
    public class Student   
    {
        [Column("student_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int studentid { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; } = null!;
        [Column("last_name")]
        public string LastName { get; set; } = null!;
        [Column("Age")]
        public string age { get; set; } = null!;


    }
}