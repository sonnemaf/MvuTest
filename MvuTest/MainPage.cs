using MvuTest.Controls;
using System;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace MvuTest {

    public class MainPage : MvuPage {

        private TextBlock2 _tb;

        private int _count;

        protected override IUIElement2 Build() =>
            this.StackPanel(
                this.ToggleButton("Toggle it")
                    .IsChecked(true)
                    .Width(200)
                    .FontSize(30),
                this.Button("Increment", (sender, e) => {
                    _tb.Text($"Count {++_count}");
                }).HorizontalAlignment(HorizontalAlignment.Center),
                (_tb = this.TextBlock("Count 0"))
                    .FontSize(20)
                    .Foreground(Colors.Red),
                this.TextBox("Fons Sonnemans")
                    .Header("Name")
            ).Spacing(12)
             .HorizontalAlignment(HorizontalAlignment.Center)
             .VerticalAlignment(VerticalAlignment.Center);
    }

}