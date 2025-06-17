using System.Collections.ObjectModel;

namespace SolutionTest;

public partial class MainPage
{
    public ObservableCollection<TripItem> Items { get; set; }

    public MainPage()
    {
        InitializeComponent();

        Items =
        [
            new TripItem { Name = "Trip to Amsterdam" },
            new TripItem { Name = "Trip to Utrecht" },
            new TripItem { Name = "Trip to Rotterdam" }
        ];

        BindingContext = this;
    }
}

public class TripItem
{
    public string? Name { get; set; }
}