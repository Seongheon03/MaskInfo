using Newtonsoft.Json;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskInfo.Model
{
    public class Store : BindableBase
    {
        private string _code;
        public string Code
        {
            get => _code;
            set
            {
                SetProperty(ref _code, value);
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                SetProperty(ref _name, value);
            }
        }

        private string _addr;
        public string Addr
        {
            get => _addr;
            set
            {
                SetProperty(ref _addr, value);
            }
        }

        private string _remain_stat;
        public string Remain_stat
        {
            get => _remain_stat;
            set
            {
                SetProperty(ref _remain_stat, value);
            }
        }

        private string _type;
        public string Type
        {
            get => _type;
            set
            {
                SetProperty(ref _type, value);
            }
        }

        private string _imageUrl;
        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                SetProperty(ref _imageUrl, value);
            }
        }

        private string _inventory;
        public string Inventory
        {
            get => _inventory;
            set
            {
                SetProperty(ref _inventory, value);
            }
        }

        private string _inventoryColor;
        public string InventoryColor
        {
            get => _inventoryColor;
            set
            {
                SetProperty(ref _inventoryColor, value);
            }
        }
    }
}
