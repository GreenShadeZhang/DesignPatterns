using System;
using System.Collections.Generic;
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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace GridViewDemo
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }
      private  static BlankPage1 _blank;
    void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //var res = await GetWallpaper.GetWallpaperMethod();
           GridViewMain.ItemsSource = new ItemsToShow();
            _blank = this;
        }
        public static BlankPage1 Blank { get { return _blank; } }
        public ProgressBar MyProperty { get { return this.ProgressBar; } }
    }
}
