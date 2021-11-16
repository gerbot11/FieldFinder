using FieldFinder.Model;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FieldFinder.ViewModel
{
    public class OnBoardViewModel : BaseViewModel
    {
        private ObservableRangeCollection<OnBoardModel> _onBoardModels;
        public ObservableRangeCollection<OnBoardModel> OnBoardModels
        {
            get => _onBoardModels;
            set => SetProperty(ref _onBoardModels, value);
        }
        public OnBoardViewModel()
        {
            OnBoardModels = new ObservableRangeCollection<OnBoardModel>
            {
                new OnBoardModel
                {
                    Title = "Cari tempat Olahragamu dengan mudah!",
                    Content = "Sehat bersama teman teman",
                    Image = "onboard_futsal"
                },
                new OnBoardModel
                {
                    Title = "Cari lawan sparing mu",
                    Content = "Ingin lawan tanding biar seru? Cari di sini!",
                    Image = "onboard_duel"
                },
                new OnBoardModel
                {
                    Title = "Nge Gym biar sehat",
                    Content = "Bentukin otot-ototmu",
                    Image = "onboard_gym"
                },
                new OnBoardModel
                {
                    Title = "Transaksi lebih mudah!",
                    Content = "Transaksi pembayaran mudah",
                    Image = "onboard_pay"
                }
            };
        }

        
    }
}
