using Final_Project.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project
{
    public class FinalContextDAO
    {
        private FinalContext context;

        public FinalContextDAO(FinalContext _context)
        {
            context = _context;
        }

        //public StudentModel GetRowById(int _id)
        //{
        //    return context.Student.Where(x => x.Id.Equals(_id)).FirstOrDefault();
        //}
    }
}
