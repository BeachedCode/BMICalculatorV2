namespace BMICalculatorBeach;

public partial class RecommendationPage : ContentPage
{
	public RecommendationPage(string recommendation)
	{
		InitializeComponent();

		LblRecommendation.Text = recommendation;
	}

	private void GoBackClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

    private void MainPageClicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}