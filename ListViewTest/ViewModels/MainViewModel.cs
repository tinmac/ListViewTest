using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ListViewTest.ViewModels;

public class MainViewModel : INPC
{

    private ObservableCollection<Item> itemsOC = new();
    public ObservableCollection<Item> ItemsOC
    {
        get => itemsOC;
        set => Set(ref itemsOC, value);
    }

    public MainViewModel()
    {
        itemsOC.Add(new Item { Data_0 = "The quick brown fox jumps over the lazy dog", Data_1 = "Data", Data_2 = "Data", Data_3 = "Data", Data_4 = "Data", Data_5 = "Data", Data_6 = "Data", Data_7 = "Data", Data_8 = "Data" });
        itemsOC.Add(new Item { Data_0 = "The cat sat on the mat", Data_1 = "Data", Data_2 = "Data", Data_3 = "Data", Data_4 = "Data", Data_5 = "Data", Data_6 = "Data", Data_7 = "Data", Data_8 = "Data" });
    }
}
