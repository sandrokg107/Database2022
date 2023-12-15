using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database2022
{
    public class MatriculaService
    {
        private readonly DataContext.AppDbContext _context;

        public MatriculaService() => _context = App.GetContext();


        public bool Create(Matricula item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Matriculas.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Matricula> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Matriculas.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Matricula> Get()
        {
            return _context.Matriculas.ToList();
        }


        public List<Matricula> GetByText(string text)
        {
            return _context.Matriculas.Where(x => x.Name.Contains(text)).ToList();
        }

    }
}