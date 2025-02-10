namespace color;

public partial class color : ContentPage
{
    public color()
    {
        InitializeComponent();
        
    }
    string col = "#000000";
    string hexR = "00";
    string hexG = "00";
    string hexB = "00";

    public void zmienionaWartoscRed(object sender, EventArgs e)
    {
        int val = Convert.ToInt32(Math.Round(Convert.ToDouble(red.Value)));
        hexR = val.ToString("X");
        if (val < 16)
        {
            hexR = "0" + val.ToString("X");

        }
        col = "#" + hexR + hexG +hexB;
        lb1.Text = col ;
        
        BackgroundColor = Color.FromHex(colorAsArgbHex: col);



    }
    public void zmienionaWartoscGreen(object sender, EventArgs e)
    {
        int val = Convert.ToInt32(Math.Round(Convert.ToDouble(Green.Value)));
        hexG = val.ToString("X");
        if (val < 16)
        {
            hexG = "0" + val.ToString("X");

        }
        col = "#" + hexR + hexG + hexB;
        lb1.Text = col;
        BackgroundColor = Color.FromHex(colorAsArgbHex: col);

    }
    public void zmienionaWartoscBlue(object sender, EventArgs e)
    {
        int val = Convert.ToInt32(Math.Round(Convert.ToDouble(blue.Value)));
        hexB = val.ToString("X");
        if (val < 16)
        {
            hexB = "0" + val.ToString("X");

        }
        col = "#" + hexR + hexG + hexB;
        lb1.Text = col;

        BackgroundColor = Color.FromHex(colorAsArgbHex: col);
    }
    public void losuj(object sender, EventArgs e)
    {
        Random random = new Random();
        int valR = random.Next(255);
        int valG = random.Next(255);
        int valB = random.Next(255);

        if (valR < 16)
        {
            hexR ="0" + valR.ToString("X");
        }
        if (valG < 16)
        {
            hexG = "0" + valG.ToString("X");
        }
        if (valB < 16)
        {
            hexB="0" + valB.ToString("X");
        }
        if (valR > 16 &&  valG > 16 && valB > 16) 
        {
            hexR = valR.ToString("X");
            hexG = valG.ToString("X");
            hexB = valB.ToString("X");
        }
        col = "#" + hexR + hexG + hexB ;
        
        lb1.Text = col;

        red.Value = valR;
        Green.Value = valG;
        blue.Value = valB;

        BackgroundColor = Color.FromHex(colorAsArgbHex: col);
        Clipboard.Default.SetTextAsync(col);
        
    }
    public void kop(object sender, EventArgs e)
    {
        Clipboard.Default.SetTextAsync(lb1.Text);
    }
}