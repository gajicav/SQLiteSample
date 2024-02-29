using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLiteSample
{
    internal class Database
    {
        private readonly SQLiteAsyncConnection _connection;

        public Database(String dbpath)
        {
            _connection = new SQLiteAsyncConnection(dbpath);
            _connection.CreateTableAsync<Student>();
        }
        public Task<List<Student>> GetStudentsAsync()
        {
            return _connection.Table<Student>().ToListAsync();
        }
        public Task<int> SaveStudentAsync(Student student) 
        {
            return _connection.InsertAsync(student);
        }
    }
}
