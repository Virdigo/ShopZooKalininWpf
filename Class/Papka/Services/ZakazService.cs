using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ShopZooKalininWpf.Class.Papka.Services
{
	public class ZakazService
	{
        public List<Zakaz> GetZakaz()
        {
            using (var context = new ShopZooKalininEntities1())
            {
                return context.Zakaz.ToList();
            }
        }

        public void AddZakaz(Zakaz zakaz)
        {
            using (var context = new ShopZooKalininEntities1())
            {
                context.Zakaz.Add(zakaz);
                context.SaveChanges();
            }
        }

        public void EditZakaz(Zakaz zakaz)
        {
            using (var context = new ShopZooKalininEntities1())
            {
                var existingProduct = context.Zakaz.Find(zakaz.id_zakaz);
                if (existingProduct != null)
                {
                    existingProduct.Data = zakaz.Data;
                    existingProduct.Kolichestvo = zakaz.Kolichestvo;
                    existingProduct.id_product = zakaz.id_product;
                    existingProduct.id_users = zakaz.id_users;

                    context.SaveChanges();
                }
            }
        }

        public void DeleteZakaz(int ZakazId)
        {
            using (var context = new ShopZooKalininEntities1())
            {
                var zakaz = context.Zakaz.Find(ZakazId);
                if (zakaz != null)
                {
                    context.Zakaz.Remove(zakaz);
                    context.SaveChanges();
                }
            }
        }
    }
}






