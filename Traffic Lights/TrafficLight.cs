using System;

public class TrafficLight
{
    private LightColor currentColor;

    public TrafficLight(LightColor currentColor)
    {
        this.currentColor = currentColor;
    }

    public LightColor CurrentColor => this.currentColor;

    public void ChangeColor()
    {
        int color = (int)this.currentColor;
        color = (color + 1) % 3;
        this.currentColor = (LightColor)Enum.Parse(typeof(LightColor), color.ToString());
    }
}