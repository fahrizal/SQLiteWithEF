using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace SQLiteWithEF
{
    [Table(Name = "EmployeeMaster")]
    public class EmployeeMaster
    {
        [Column(Name = "ID", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID { get; set; }

        [Column(Name = "EmpName", DbType = "VARCHAR")]
        public string EmpName { get; set; }

        [Column(Name = "Salary", DbType = "DOUBLE")]
        public double Salary { get; set; }

        [Column(Name = "Designation", DbType = "VARCHAR")]
        public string Designation { get; set; }
    }
}
