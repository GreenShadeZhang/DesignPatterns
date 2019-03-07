using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace GridViewDemo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    { ObservableCollection<string> vs = new ObservableCollection<string>();
        public MainPage()
        {
            this.InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                vs.Add("文本"+i.ToString());
            }
            grid.ItemsSource = vs;
        }

        private void Sv_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            ScrollViewer sv = sender as ScrollViewer;
            double vo = sv.VerticalOffset;
            double vh = sv.ViewportHeight;
            double eh = sv.ExtentHeight;
            string VerticalOffset = sv.VerticalOffset.ToString();
            string ViewPortHeight = sv.ViewportHeight.ToString();
            string ExtentHeight = sv.ExtentHeight.ToString();
            a.Text = "VerticalOffset" + VerticalOffset;
            b.Text = "ViewPortHeight" + ViewPortHeight;
            c.Text = "ExtentHeight" + ExtentHeight;
            if(vo+vh==eh)
            {
                for (int i = 0; i < 100; i++)
                {
                    vs.Add("文本" + i.ToString());
                }
            }
        }
    }
}
