using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCStudentRepository.Models.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> SelectAll();
        Student SelectByID(string BNumber);
        void Insert(Student obj);
        void Update(Student obj);
        void Delete(string BNumber);
        void Save();
    }
}
