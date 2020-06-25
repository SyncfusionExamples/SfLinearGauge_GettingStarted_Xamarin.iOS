using System;
using System.Collections.ObjectModel;
using Syncfusion.SfGauge.iOS;
using UIKit;

namespace Gauge_GettingStarted
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SFLinearGauge linearGauge = new SFLinearGauge();
            linearGauge.BackgroundColor = UIColor.White;
            SFLinearLabel linearHeader = new SFLinearLabel();
            linearHeader.Text = (Foundation.NSString)"Thermometer";
            linearHeader.Font = UIFont.FromName("Helvetica", 20f);
            linearHeader.Position = new CoreGraphics.CGPoint(0.35, 0.35);
            linearHeader.Color = UIColor.Black;
            linearGauge.Header = linearHeader;

            SFLinearScale linearScale = new SFLinearScale();
            linearGauge.Header = new SFLinearLabel();
            linearScale.ScaleBarColor = UIColor.FromRGB(224, 224, 224);
            linearScale.MajorTickSettings.Length = 12;
            linearScale.MinorTickSettings.Length = 5;
            linearScale.LabelColor = UIColor.FromRGB(66, 66, 66);
            linearGauge.Scales.Add(linearScale);

            SFSymbolPointer symbolPointer = new SFSymbolPointer();
            symbolPointer.Value = 60;
            symbolPointer.Thickness = 10;
            symbolPointer.SymbolPosition = SymbolPointerPosition.Away;
            symbolPointer.Color = UIColor.FromRGB(117, 117, 117);
            linearScale.Pointers.Add(symbolPointer);

            SFBarPointer barPointer = new SFBarPointer();
            barPointer.Value = 50;
            barPointer.Thickness = 10;
            barPointer.Color = UIColor.FromRGB(117, 117, 117);
            linearScale.Pointers.Add(barPointer);

            SFLinearRange linearRange = new SFLinearRange();
            linearRange.StartValue = 0;
            linearRange.EndValue = 40;
            linearRange.Color = UIColor.FromRGB(39, 190, 183);
            linearRange.Offset = -20;
            linearRange.StartWidth = 10;
            linearRange.EndWidth = 10;
            linearScale.Ranges.Add(linearRange);

            SFLinearRange linearRange1 = new SFLinearRange();
            linearRange1.StartValue = 40;
            linearRange1.EndValue = 100;
            linearRange1.Color = UIColor.FromRGB(224, 255, 255);
            linearRange1.Offset = -20;
            linearRange1.StartWidth = 10;
            linearRange1.EndWidth = 10;
            linearScale.Ranges.Add(linearRange1);

            this.View.AddSubview(linearGauge);

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
