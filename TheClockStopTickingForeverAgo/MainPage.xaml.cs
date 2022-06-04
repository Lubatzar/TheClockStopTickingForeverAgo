using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Shapes;
using Rectangle = Xamarin.Forms.Rectangle;

namespace TheClockStopTickingForeverAgo
{
    public partial class MainPage : ContentPage
    {
        public class Digit
        {
            readonly Brush colorOn = new SolidColorBrush(Color.FromHex("#D4172F"));
            readonly Brush colorOff = Brush.Transparent;
            readonly Brush tColorOn = new SolidColorBrush(Color.FromHex("#FBB901"));
            readonly Brush tColorOff = new SolidColorBrush(Color.FromHex("#0D0D0D"));
            
            private Polygon[] polies = new Polygon[7];
            private Polygon createNewDigitParts(double x, double y, double rotation)
            {
                Polygon poly = new Polygon();
                if (rotation == 0)
                {
                    poly.Points.Add(new Point(x, y));
                    poly.Points.Add(new Point(x + 15.0, y - 15.0));
                    poly.Points.Add(new Point(x + 105.0, y - 15.0));
                    poly.Points.Add(new Point(x + 120.0, y));
                    poly.Points.Add(new Point(x + 105.0, y + 15.0));
                    poly.Points.Add(new Point(x + 15.0, y + 15.0));
                }
                else
                {
                    poly.Points.Add(new Point(x, y));
                    poly.Points.Add(new Point(x + 15.0, y + 15.0));
                    poly.Points.Add(new Point(x + 15.0, y + 105.0));
                    poly.Points.Add(new Point(x, y + 120.0));
                    poly.Points.Add(new Point(x - 15.0, y + 105.0));
                    poly.Points.Add(new Point(x - 15.0, y + 15.0)); 
                }
                poly.Stroke = new SolidColorBrush(Color.FromHex("#0D0D0D"));
                poly.StrokeThickness = 5.0;
                return poly;
            }

            public Digit(double x, double y, AbsoluteLayout absoluteLayout)
            {
                polies[0] = createNewDigitParts(x, y, 0);                               // верх центр
                polies[1] = createNewDigitParts(x, y, 1);                 // верх влево
                polies[2] = createNewDigitParts(x + 120, y, 1);                                      // верх право
                polies[3] = createNewDigitParts(x, y + 120, 0);                       // центр центр
                polies[4] = createNewDigitParts(x, y + 120, 1);         // низ влево
                polies[5] = createNewDigitParts(x + 120, y + 120, 1);                              // низ вправо
                polies[6] = createNewDigitParts(x, y + 240, 0);                       // низ центр

                foreach (var poly in polies)
                {
                    absoluteLayout.Children.Add(poly);
                }
                
                
            }

            public void SetValue(int val)
            {
                if (val == 0)
                {
                    polies[0].Fill = colorOn;
                    polies[1].Fill = colorOn;
                    polies[2].Fill = colorOn;
                    polies[3].Fill = colorOff;
                    polies[4].Fill = colorOn;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOn;
                }
                else if (val == 1)
                {
                    polies[0].Fill = colorOff;
                    polies[1].Fill = colorOff;
                    polies[2].Fill = colorOn;
                    polies[3].Fill = colorOff;
                    polies[4].Fill = colorOff;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOff;
                }
                else if (val == 2)
                {
                    polies[0].Fill = colorOn;
                    polies[1].Fill = colorOff;
                    polies[2].Fill = colorOn;
                    polies[3].Fill = colorOn;
                    polies[4].Fill = colorOn;
                    polies[5].Fill = colorOff;
                    polies[6].Fill = colorOn;
                }
                else if (val == 3)
                {
                    polies[0].Fill = colorOn;
                    polies[1].Fill = colorOff;
                    polies[2].Fill = colorOn;
                    polies[3].Fill = colorOn;
                    polies[4].Fill = colorOff;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOn;
                }
                else if (val == 4)
                {
                    polies[0].Fill = colorOff;
                    polies[1].Fill = colorOn;
                    polies[2].Fill = colorOn;
                    polies[3].Fill = colorOn;
                    polies[4].Fill = colorOff;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOff;
                }
                else if (val == 5)
                {
                    polies[0].Fill = colorOn;
                    polies[1].Fill = colorOn;
                    polies[2].Fill = colorOff;
                    polies[3].Fill = colorOn;
                    polies[4].Fill = colorOff;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOn;
                }
                else if (val == 6)
                {
                    polies[0].Fill = colorOn;
                    polies[1].Fill = colorOn;
                    polies[2].Fill = colorOff;
                    polies[3].Fill = colorOn;
                    polies[4].Fill = colorOn;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOn;
                }
                else if (val == 7)
                {
                    polies[0].Fill = colorOn;
                    polies[1].Fill = colorOff;
                    polies[2].Fill = colorOn;
                    polies[3].Fill = colorOff;
                    polies[4].Fill = colorOff;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOff;
                }
                else if (val == 8)
                {
                    polies[0].Fill = colorOn;
                    polies[1].Fill = colorOn;
                    polies[2].Fill = colorOn;
                    polies[3].Fill = colorOn;
                    polies[4].Fill = colorOn;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOn;
                }
                else if (val == 9)
                {
                    polies[0].Fill = colorOn;
                    polies[1].Fill = colorOn;
                    polies[2].Fill = colorOn;
                    polies[3].Fill = colorOn;
                    polies[4].Fill = colorOff;
                    polies[5].Fill = colorOn;
                    polies[6].Fill = colorOn;
                }
                else
                {
                    throw new Exception("Ты абобус?");
                }
            }
            public void SetValueThickness(int val)
            {
                if (val == 0)
                {
                    polies[0].Stroke = tColorOn;
                    polies[1].Stroke = tColorOn;
                    polies[2].Stroke = tColorOn;
                    polies[3].Stroke = tColorOff;
                    polies[4].Stroke = tColorOn;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOn;
                }
                else if (val == 1)
                {
                    polies[0].Stroke = tColorOff;
                    polies[1].Stroke = tColorOff;
                    polies[2].Stroke = tColorOn;
                    polies[3].Stroke = tColorOff;
                    polies[4].Stroke = tColorOff;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOff;
                }
                else if (val == 2)
                {
                    polies[0].Stroke = tColorOn;
                    polies[1].Stroke = tColorOff;
                    polies[2].Stroke = tColorOn;
                    polies[3].Stroke = tColorOn;
                    polies[4].Stroke = tColorOn;
                    polies[5].Stroke = tColorOff;
                    polies[6].Stroke = tColorOn;
                }
                else if (val == 3)
                {
                    polies[0].Stroke = tColorOn;
                    polies[1].Stroke = tColorOff;
                    polies[2].Stroke = tColorOn;
                    polies[3].Stroke = tColorOn;
                    polies[4].Stroke = tColorOff;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOn;
                }
                else if (val == 4)
                {
                    polies[0].Stroke = tColorOff;
                    polies[1].Stroke = tColorOn;
                    polies[2].Stroke = tColorOn;
                    polies[3].Stroke = tColorOn;
                    polies[4].Stroke = tColorOff;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOff;
                }
                else if (val == 5)
                {
                    polies[0].Stroke = tColorOn;
                    polies[1].Stroke = tColorOn;
                    polies[2].Stroke = tColorOff;
                    polies[3].Stroke = tColorOn;
                    polies[4].Stroke = tColorOff;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOn;
                }
                else if (val == 6)
                {
                    polies[0].Stroke = tColorOn;
                    polies[1].Stroke = tColorOn;
                    polies[2].Stroke = tColorOff;
                    polies[3].Stroke = tColorOn;
                    polies[4].Stroke = tColorOn;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOn;
                }
                else if (val == 7)
                {
                    polies[0].Stroke = tColorOn;
                    polies[1].Stroke = tColorOff;
                    polies[2].Stroke = tColorOn;
                    polies[3].Stroke = tColorOff;
                    polies[4].Stroke = tColorOff;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOff;
                }
                else if (val == 8)
                {
                    polies[0].Stroke = tColorOn;
                    polies[1].Stroke = tColorOn;
                    polies[2].Stroke = tColorOn;
                    polies[3].Stroke = tColorOn;
                    polies[4].Stroke = tColorOn;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOn;
                }
                else if (val == 9)
                {
                    polies[0].Stroke = tColorOn;
                    polies[1].Stroke = tColorOn;
                    polies[2].Stroke = tColorOn;
                    polies[3].Stroke = tColorOn;
                    polies[4].Stroke = tColorOff;
                    polies[5].Stroke = tColorOn;
                    polies[6].Stroke = tColorOn;
                }
                else
                {
                    throw new Exception("Ты абобус?");
                }
            }
        }
        Digit[] digits = new Digit[4];
        public MainPage()
        {
            InitializeComponent();

            digits[0] = new Digit(27, 27, absoluteLayout);
            digits[1] = new Digit(27 + 165, 27, absoluteLayout);
            digits[2] = new Digit(27 + 330 + 50, 27, absoluteLayout);
            digits[3] = new Digit(27 + 495 + 50, 27, absoluteLayout);


            // Set the timer and initialize with a manual call.
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimer);
            OnTimer();
        }

        bool OnTimer()
        {
            DateTime dateTime = DateTime.Now;
            
            digits[0].SetValue(dateTime.Hour / 10);
            digits[1].SetValue(dateTime.Hour % 10);
            digits[2].SetValue(dateTime.Minute / 10);
            digits[3].SetValue(dateTime.Minute % 10);
            digits[2].SetValueThickness(dateTime.Second / 10);
            digits[3].SetValueThickness(dateTime.Second % 10);
            
            return true;
        }
    }
}