using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Model.Entities
{
    [Table("Courses")]
    public class Courses
    {

        [Column("Course_Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        [Column("Title")]
        public string Title { get; set; }
        
        [Column("credits")]
        public int Credits { get; set; }

    }
}