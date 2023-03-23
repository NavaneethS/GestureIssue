using System.Diagnostics;
namespace GestureIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        ContentView contentView = new ContentView();
        PinchGestureRecognizer pinchGestureRecognizer = new PinchGestureRecognizer();
        pinchGestureRecognizer.PinchUpdated += (sender, e) =>
        {
            Debug.WriteLine("PinchUpdated");
        };
        contentView.GestureRecognizers.Add(pinchGestureRecognizer);
        Content = contentView;


        Grid childView = new Grid();
        TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += (sender, e) =>
        {
            Debug.WriteLine("Tapped");
        };
        childView.GestureRecognizers.Add(tapGestureRecognizer);
        contentView.Content = childView;
    }
}

