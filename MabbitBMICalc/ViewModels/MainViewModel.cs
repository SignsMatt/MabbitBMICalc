using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MabbitBMICalc.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        bool isMaleSelected = true;

        [ObservableProperty]
        double sliderValue = 180.0;

        [ObservableProperty]
        double weight = 60.0;

        [ObservableProperty]
        int age = 20;

        [RelayCommand]
        void MaleTap()
        {
            IsMaleSelected = true;
        }

        [RelayCommand]
        void FemaleTap()
        {
            IsMaleSelected = false;
        }

        [RelayCommand]
        void WeightIncrement()
        {
            Weight++;
        }

        [RelayCommand]
        void WeightDecrement()
        {
            Weight--;
        }

        [RelayCommand]
        void AgeIncrement()
        {
            Age++;
        }

        [RelayCommand]
        void AgeDecrement()
        {
            Age--;
        }
    }
}
