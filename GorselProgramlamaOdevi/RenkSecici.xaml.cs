namespace GorselProgramlamaOdevi;

public partial class RenkSecici : ContentPage
{
    public RenkSecici()
    {
        InitializeComponent();

        sliderRed.Value = 0;
        sliderGreen.Value = 0;
        sliderBlue.Value = 0;  

        UpdateColor();
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateColor();

        labelRed.Text = $"Kırmızı Ton : {sliderRed.Value}";
        labelGreen.Text = $"Yeşil Ton: {sliderGreen.Value}";
        labelBlue.Text = $"Mavi : {sliderBlue.Value}";
    }

    private void UpdateColor()
    {
        Color color = Color.FromRgb((int)sliderRed.Value, (int)sliderGreen.Value, (int)sliderBlue.Value);
        colorCanvas.Color = color;

        labelColorCode.Text = $"#{ToHex((int)sliderRed.Value)}{ToHex((int)sliderGreen.Value)}{ToHex((int)sliderBlue.Value)}";
    }

    private string ToHex(int value)
    {
        return value.ToString("X2");
    }

    private void OnRandomColorButtonClicked(object sender, EventArgs e)
    {
        Random random = new Random();
        sliderRed.Value = random.Next(0, 256);
        sliderGreen.Value = random.Next(0, 256);
        sliderBlue.Value = random.Next(0, 256);
    }

    private async void OnCopyButtonClicked(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(labelColorCode.Text);
    }
}
