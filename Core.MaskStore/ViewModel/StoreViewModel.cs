using MaskInfo.Model;
using MaskInfo.Service;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MaskInfo.ViewModel
{
    public class StoreViewModel : BindableBase
    {
        #region Property
        StoreService storeService = new StoreService();

        private string _searchedText;
        public string SearchedText
        {
            get => _searchedText;
            set
            {
                SetProperty(ref _searchedText, value);
            }
        }

        private ObservableCollection<Store> _storesByAddress = new ObservableCollection<Store>();
        public ObservableCollection<Store> StoresByAddress
        {
            get => _storesByAddress;
            set
            {
                SetProperty(ref _storesByAddress, value);
            }
        }

        private ObservableCollection<Store> _storesByDrugstore = new ObservableCollection<Store>();
        public ObservableCollection<Store> StoresByDrugstore
        {
            get => _storesByDrugstore;
            set
            {
                SetProperty(ref _storesByDrugstore, value);
            }
        }

        private Store _selectedDrugstore;
        public Store SelectedDrugstore
        {
            get => _selectedDrugstore;
            set
            {
                SetProperty(ref _selectedDrugstore, value);
            }
        }

        private string _tbAddressGuideText = "주소를 입력해주세요";
        public string TbAddressGuideText
        {
            get => _tbAddressGuideText;
            set
            {
                SetProperty(ref _tbAddressGuideText, value);
            }
        }

        private bool _tbAddressGuideVisibiltiy = true;
        public bool TbAddressGuideVisibility
        {
            get => _tbAddressGuideVisibiltiy;
            set
            {
                SetProperty(ref _tbAddressGuideVisibiltiy, value);
            }
        }

        private string _tbDrugstoreGuideText = "약국을 입력해주세요";
        public string TbDrugstoreGuideText
        {
            get => _tbDrugstoreGuideText;
            set
            {
                SetProperty(ref _tbDrugstoreGuideText, value);
            }
        }

        private bool _tbDrugstoreGuideVisibiltiy = true;
        public bool TbDrugstoreGuideVisibility
        {
            get => _tbDrugstoreGuideVisibiltiy;
            set
            {
                SetProperty(ref _tbDrugstoreGuideVisibiltiy, value);
            }   
        }

        private bool _progressRingActivated;
        public bool ProgressRingActivated
        {
            get => _progressRingActivated;
            set
            {
                SetProperty(ref _progressRingActivated, value);
            }
        }
        #endregion

        #region Command
        public ICommand SearchByAddressCommand { get; set; }
        public ICommand SearchByDrugstoreCommand { get; set; }
        #endregion

        public StoreViewModel()
        {
            SearchByAddressCommand = new DelegateCommand(OnSearchAddress);
            SearchByDrugstoreCommand = new DelegateCommand(OnSearchDrugstore);
        }

        private async void OnSearchAddress()
        {
            ProgressRingActivated = true;
            var resp = await storeService.GetStoreByAddress(SearchedText);

            if (resp != null && resp.strores.Count != 0)
            {
                try
                {
                    Store store = new Store();

                    foreach (var item in resp.strores)
                    {
                        Store temp = new Store();

                        temp = item;
                        temp.ImageUrl = GetImageUrl(item.Type);
                        temp = SetInventoryAndColor(item);
                        
                        StoresByAddress.Add(item);
                    }

                    TbAddressGuideVisibility = false;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.StackTrace);
                }
            }

            if (resp.strores.Count == 0)
            {
                StoresByAddress.Clear();
                TbAddressGuideVisibility = true;
                TbAddressGuideText = "해당 주소를 찾지 못했습니다";
            }
            ProgressRingActivated = false;
        }

        private async void OnSearchDrugstore()
        {
            ProgressRingActivated = true;
            var resp = await storeService.GetDrugstore(SearchedText);

            if(resp != null && resp.Count != 0)
            {
                try
                {
                    Store store = new Store();

                    TbDrugstoreGuideVisibility = false;


                    foreach (var item in resp)
                    {
                        item.ImageUrl = GetImageUrl(item.Type);

                        StoresByDrugstore.Add(item);
                    }

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.StackTrace);
                }
            }
            if(resp == null)
            {
                TbDrugstoreGuideVisibility = true;
                TbDrugstoreGuideText = "서버가 연결되지 않았습니다";
            }
            else if (resp.Count == 0)
            {
                StoresByDrugstore.Clear();
                TbDrugstoreGuideVisibility = true;
                TbDrugstoreGuideText = "해당 약국을 찾지 못했습니다";
            }
            ProgressRingActivated = false;
        }

        public async Task OnViewDetailInfo()
        {
            ProgressRingActivated = true;
            SelectedDrugstore.Remain_stat = await storeService.GetMasks(SelectedDrugstore.Code);
            SelectedDrugstore = SetInventoryAndColor(SelectedDrugstore);
            ProgressRingActivated = false;
        }

        private string GetImageUrl(string type)
        {
            switch (type)
            {
                case "01":
                    return "/Assets/drug.png";
                case "02":
                    return "/Assets/mailbox.png";
                default:
                    return "/Assets/nh.png";
            }
        }

        private Store SetInventoryAndColor(Store store)
        {
            switch (store.Remain_stat)
            {
                case "break":
                    store.Inventory = "판매 중지";
                    store.InventoryColor = "LightGray";
                    break;
                case "empty":
                    store.Inventory = "없음 (1개 이하)";
                    store.InventoryColor = "Gray";
                    break;
                case "few":
                    store.Inventory = "부족 (2 ~ 30)";
                    store.InventoryColor = "Red";
                    break;
                case "some":
                    store.Inventory = "보통 (30 ~ 100)";
                    store.InventoryColor = "Orange";
                    break;
                case "plenty":
                    store.Inventory = "충분 (100개 이상)";
                    store.InventoryColor = "Green";
                    break;
                default:
                    store.Inventory = "재고가 확인되지 않습니다";
                    break;
            }
            return store;
        }
    }
}
