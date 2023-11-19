namespace GorselProgramlamaOdevi;

using Microsoft.Maui.Controls;


    public partial class VucutKitleIndeksi : ContentPage
    {
        public VucutKitleIndeksi()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            weightLabel.Text = $"Kilonuz: {weightSlider.Value:F1} KG";
            heightLabel.Text = $"Boyunuz: {heightSlider.Value:F2} CM";
            CalculateBmi();
        }

        void CalculateBmi()
        {
            double weight = weightSlider.Value;
            double height = heightSlider.Value;
            double bmi = weight / (height * height);
            resultLabel.Text = $"VKL: {bmi:F1}";

            string bmiComment;
            if (bmi < 16)
                bmiComment = "İleri Düzeyde Zayıf";
            else if (bmi < 17)
                bmiComment = "Orta Düzeyde Zayıf";
            else if (bmi < 18.5)
                bmiComment = "Hafif Düzeyde Zayıf";
            else if (bmi < 25)
                bmiComment = "Normal Kilolu";
            else if (bmi < 30)
                bmiComment = "Hafif şişman";
            else if (bmi < 35)
                bmiComment = "1. Derecede Obez";
            else if (bmi < 40)
                bmiComment = "2. Derecede Obez";
            else
                bmiComment = "3. Derecede Obez";

            bmiCommentLabel.Text = bmiComment;
        }
    }

