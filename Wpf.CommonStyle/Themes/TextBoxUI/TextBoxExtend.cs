using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Wpf.CommonStyle.Themes.TextBoxUI
{
  public  class TextBoxExtend:TextBox
    {
        public string WaterText
        {
            get { return (string)GetValue(WaterTextProperty); }
            set { SetValue(WaterTextProperty, value); }
        }
        public static readonly DependencyProperty WaterTextProperty =
          DependencyProperty.Register("WaterText", typeof(string), typeof(TextBoxExtend));



        public CornerRadius TextBoxCornerRadius
        {
            get { return (CornerRadius)GetValue(TextBoxCornerRadiusProperty); }
            set { SetValue(TextBoxCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxCornerRadiusProperty =
            DependencyProperty.Register("TextBoxCornerRadius", typeof(CornerRadius), typeof(TextBoxExtend), new PropertyMetadata(new CornerRadius(2)));


    }
}
