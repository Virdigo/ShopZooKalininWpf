using ShopZooKalininWpf.Class.Papka.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ShopZooKalininWpf.Class.Papka.ViewModels
{
    public class ZakazViewModel : BaseViewModel
    {
        public ZakazService _ZakazService;
        public ObservableCollection<Zakaz> Zakaz { get; set; }

        public ZakazViewModel()
        {
            _ZakazService = new ZakazService();
            Zakaz = new ObservableCollection<Zakaz>();
            LoadZakaz();
        }

        public void LoadZakaz()
        {
            Zakaz.Clear();
            var zakaz = _ZakazService.GetZakaz();
            foreach (var order in zakaz)
            {
                Zakaz.Add(order);
            }
        }
    }
}
