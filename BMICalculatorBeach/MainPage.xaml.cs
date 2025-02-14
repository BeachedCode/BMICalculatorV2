namespace BMICalculatorBeach
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        string gender = "Male";

        private void TapMale_Tapped(object sender, TappedEventArgs e)
        {
            gender = "Male";
            MaleFrame.BorderColor = Color.FromArgb("#FF000000");
            FemaleFrame.BorderColor = Color.FromArgb("#FFD3D3D3");
        }

        private void TapFemale_Tapped(object sender, TappedEventArgs e)
        {
            gender = "Female";
            MaleFrame.BorderColor = Color.FromArgb("#FFD3D3D3");
            FemaleFrame.BorderColor = Color.FromArgb("#FF000000");
        }

        private void CalculateBMI(object sender, EventArgs e)
        {
            double height = double.Parse(LblHeight.Text);
            double weight = double.Parse(LblWeight.Text);

            double BMI = Math.Round((weight * 703)/Math.Pow(height, 2),2);

            Navigation.PushAsync(new BMIResult(BMI));

            /*if (gender.Equals("Male"))
            {
                if(BMI < 18.5)
                {
                    DisplayAlert("Your Calculated BMI Results:", "Gender: " + gender + "\nBMI: " + BMI + "\nStatus: Underweight" +
                        "\nRecommendations:" +
                        "\n-Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, Underweight whole grains)." +
                        "\n-Incorporate strength training to build muscle mass. Consult a nutritionist if needed.", "Ok");
                }
                else if (BMI >= 18.5 && BMI < 25)
                {
                    DisplayAlert("Your Calculated BMI Results:", "Gender: " + gender + "\nBMI: " + BMI + "\nStatus: Normal Weight" +
                        "\nRecommendations:" +
                        "\n-Maintain a balanced diet with proteins, healthy fats, and fiber." +
                        "\n-Stay physically active with at least 150 minutes of exercise per week." +
                        "\n-Keep regular check-ups to monitor overall health.", "Ok");
                }
                else if (BMI >= 25 && BMI < 30)
                {
                    DisplayAlert("Your Calculated BMI Results:", "Gender: " + gender + "\nBMI: " + BMI + "\nStatus: Overweight" +
                        "\nRecommendations:" +
                        "\n-Reduce processed foods and focus on portion control." +
                        "\n-Engage in regular Overweight aerobic exercises (e.g., jogging, swimming) and strength training." +
                        "\n-Drink plenty of water and track your progress.", "Ok");
                }
                else
                {
                    DisplayAlert("Your Calculated BMI Results:", "Gender: " + gender + "\nBMI: " + BMI + "\nStatus: Obese" +
                        "\nRecommendations:" +
                        "\n-Consult a doctor for personalized guidance." +
                        "\n-Start with low-impact exercises (e.g., walking, cycling)." +
                        "\n-Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes." +
                        "\n-Avoid sugary drinks and maintain a consistent sleep schedule.", "Ok");
                }
            }

            if (gender.Equals("Female"))
            {
                if (BMI < 18)
                {
                    DisplayAlert("Your Calculated BMI Results:", "Gender: " + gender + "\nBMI: " + BMI + "\nStatus: Underweight" +
                        "\nRecommendations:" +
                        "\n-Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, Underweight whole grains)." +
                        "\n-Incorporate strength training to build muscle mass. Consult a nutritionist if needed.", "Ok");
                }
                else if (BMI >= 18 && BMI < 24)
                {
                    DisplayAlert("Your Calculated BMI Results:", "Gender: " + gender + "\nBMI: " + BMI + "\nStatus: Normal Weight" +
                        "\nRecommendations:" +
                        "\n-Maintain a balanced diet with proteins, healthy fats, and fiber." +
                        "\n-Stay physically active with at least 150 minutes of exercise per week." +
                        "\n-Keep regular check-ups to monitor overall health.", "Ok");
                }
                else if (BMI >= 24 && BMI < 29)
                {
                    DisplayAlert("Your Calculated BMI Results:", "Gender: " + gender + "\nBMI: " + BMI + "\nStatus: Overweight" +
                        "\nRecommendations:" +
                        "\n-Reduce processed foods and focus on portion control." +
                        "\n-Engage in regular Overweight aerobic exercises (e.g., jogging, swimming) and strength training." +
                        "\n-Drink plenty of water and track your progress.", "Ok");
                }
                else
                {
                    DisplayAlert("Your Calculated BMI Results:", "Gender: " + gender + "\nBMI: " + BMI + "\nStatus: Obese" +
                        "\nRecommendations:" +
                        "\n-Consult a doctor for personalized guidance." +
                        "\n-Start with low-impact exercises (e.g., walking, cycling)." +
                        "\n-Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes." +
                        "\n-Avoid sugary drinks and maintain a consistent sleep schedule.", "Ok");
                }
            }*/

        }
    }

}
