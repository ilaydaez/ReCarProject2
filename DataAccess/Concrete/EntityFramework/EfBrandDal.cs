using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand brand)
        {

            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(brand);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }

        }

        public void Delete(Brand brand)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(brand);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand brand)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(brand);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
