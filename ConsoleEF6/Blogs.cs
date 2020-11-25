using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleEF6
{
    public class Blogs
    {
        public Blogs()
        {
            Id = Guid.NewGuid();
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

    }
}
