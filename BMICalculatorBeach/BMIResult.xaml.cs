using System.Runtime.CompilerServices;

namespace BMICalculatorBeach;

public partial class BMIResult : ContentPage
{
    string recommendation;
    public BMIResult(double BMI, string gender)
    {
        InitializeComponent();
        LblBMI.Text = "BMI = " + BMI.ToString();

        if (gender.Equals("Male"))
        {
            if (BMI < 18.5)
            {
                LblClass.Text = "Underweight";
                recommendation =
                    "-Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, Underweight whole grains)." +
                    "\n-Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                LblClass.Text = "Normal Weight";
                recommendation =
                    "-Maintain a balanced diet with proteins, healthy fats, and fiber." +
                    "\n-Stay physically active with at least 150 minutes of exercise per week." +
                    "\n-Keep regular check-ups to monitor overall health.";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                LblClass.Text = "Overweight";
                recommendation =
                    "-Reduce processed foods and focus on portion control." +
                    "\n-Engage in regular Overweight aerobic exercises (e.g., jogging, swimming) and strength training." +
                    "\n-Drink plenty of water and track your progress.";
            }
            else
            {
                LblClass.Text = "Obese";
                recommendation =
                    "-Consult a doctor for personalized guidance." +
                    "\n-Start with low-impact exercises (e.g., walking, cycling)." +
                    "\n-Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes." +
                    "\n-Avoid sugary drinks and maintain a consistent sleep schedule.";
            }
        }

        if (gender.Equals("Female"))
        {
            if (BMI < 18)
            {
                LblClass.Text = "Underweight";
                recommendation =
                    "-Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, Underweight whole grains)." +
                    "\n-Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
            }
            else if (BMI >= 18 && BMI < 24)
            {
                LblClass.Text = "Normal Weight";
                recommendation =
                    "-Maintain a balanced diet with proteins, healthy fats, and fiber." +
                    "\n-Stay physically active with at least 150 minutes of exercise per week." +
                    "\n-Keep regular check-ups to monitor overall health.";
            }
            else if (BMI >= 24 && BMI < 29)
            {
                LblClass.Text = "Overweight";
                recommendation =
                    "-Reduce processed foods and focus on portion control." +
                    "\n-Engage in regular Overweight aerobic exercises (e.g., jogging, swimming) and strength training." +
                    "\n-Drink plenty of water and track your progress.";
            }
            else
            {
                LblClass.Text = "Obese";
                recommendation =
                    "-Consult a doctor for personalized guidance." +
                    "\n-Start with low-impact exercises (e.g., walking, cycling)." +
                    "\n-Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes." +
                    "\n-Avoid sugary drinks and maintain a consistent sleep schedule.";
            }
        }
    }

    private void GoBackClicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void RecommendationsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RecommendationPage(recommendation));
    }
}