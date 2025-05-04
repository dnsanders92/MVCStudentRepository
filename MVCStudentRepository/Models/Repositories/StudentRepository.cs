using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MVCStudentRepository.Models;
using MVCStudentRepository.Models.Repositories;

namespace MVCStudentRepository.Models.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDBContext db = null;

        public StudentRepository()
        {
            this.db = new StudentDBContext();
        }

        public StudentRepository(StudentDBContext db)
        {
            this.db = db;
        }

        public IEnumerable<Student> SelectAll()
        {
            return db.Students.OrderBy(s => s.Surname).ToList();
        }

        public Student SelectByID(string BNumber)
        {
            return db.Students.Find(BNumber);
        }

        public void Insert(Student obj)
        {
            db.Students.Add(obj);
        }

        public void Update(Student obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(string BNumber)
        {
            Student existing = db.Students.Find(BNumber);
            if (existing != null)
            {
                db.Students.Remove(existing);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}