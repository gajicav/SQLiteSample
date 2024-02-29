using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteSample
{
    internal class Student
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAttending { get; set; }
    }
}
