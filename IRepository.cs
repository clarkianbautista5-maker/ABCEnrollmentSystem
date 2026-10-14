using System;
using System.Collections.Generic;
using System.Text;

namespace ABCEnrollmentSystem
{
    internal interface IRepository<T>//G
    {
        List<T> GetAll(); //GetAll record  #1
        T GetByID(string id);  //GetOne record  #2
        List<T> Search(string keyword); //search  #3

        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
    }
}
