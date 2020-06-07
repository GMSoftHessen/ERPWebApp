using DataAccessLayer.Admin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public class MenuRepository : GenericRepository<Menu>
    {
        public AdminDbContext _context { get; set; }
        public MenuRepository(AdminDbContext ctx) : base(ctx)
        {
        }

        public override IEnumerable<Menu> All()
        {
            return base.All();
        }

        public override IEnumerable<Menu> AllInclude(params Expression<Func<Menu, object>>[] includeProperties)
        {
            return base.AllInclude(includeProperties);
        }

        public override void Delete(int id)
        {
            base.Delete(id);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IEnumerable<Menu> FindBy(Expression<Func<Menu, bool>> predicate)
        {
            return _context.Menus.Where(predicate).ToList();
        }

        public override IEnumerable<Menu> FindByInclude(Expression<Func<Menu, bool>> predicate, params Expression<Func<Menu, object>>[] includeProperties)
        {
            return base.FindByInclude(predicate, includeProperties);
        }

        public override Menu FindByKey(int id)
        {
            return base.FindByKey(id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Insert(Menu entity)
        {
            base.Insert(entity);
        }

        public override void SaveChanges()
        {
            base.SaveChanges();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update(Menu entity)
        {
            Menu menu = _context.Menus.Single(e => e.MenuId == entity.MenuId);

            if (menu != null)
               base.Update(entity);
        }
    }
}
