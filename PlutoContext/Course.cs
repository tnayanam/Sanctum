namespace PlutoContext
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Courses")]
    // Ideally we should have table name as Plural form of our Domain Class
    // So that entity framework can eaily map them
    // If that is not the case in legacy code and all, then inorder to tell the framework that
    // this domain class belongs to a particular table in DB we use below approach
    //[Table("tbl_Courses")] 
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Tags = new HashSet<Tag>();
        }


        // Ideal Convention is ID or classNameID
        // If this is not follwed then we need to add [Key]
        // also if we do not want the DB to genenrate the key automatically and we want to provide the key from code then
        // we use 
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] // this wil make sure DB wont generate it. We need to provide this.
        public int Id { get; set; }

        //[Column("Title")] // In case if column name does not match with column name in DB
        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }

        public int? Author_Id { get; set; }

        public virtual Author Author { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
