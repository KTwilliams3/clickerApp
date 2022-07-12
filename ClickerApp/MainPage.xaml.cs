namespace ClickerApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	
	public MainPage()
	{
		InitializeComponent();
	}

	private void CounterAdd_Clicked(object sender, EventArgs e)
	{
		count++;
		counterLabel.Text = $"Count: {count}";

	}
}

