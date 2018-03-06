using System.ComponentModel.DataAnnotations.Schema;
namespace CodeFirstSample.EntityModels
{
    [Table("tblEmployees")]
    public class Employee 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Column("LName")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}