using System;
using System.Collections;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Layouts
{
    public partial class StackLayoutDemo : ContentPage
    {
        class LayoutOptionsContainer
        {
            public LayoutOptions Options { get; set; }
            public string Name { get; set; }
        }

        public StackLayoutDemo()
        {
            InitializeComponent();
            HorizontalOptionsPicker.ItemsSource = (IList)GetLayoutOptions();
            VerticalOptionsPicker.ItemsSource = (IList)GetLayoutOptions();
        }

        private IList<LayoutOptionsContainer> GetLayoutOptions()
        {
            return new List<LayoutOptionsContainer>
            {
                new LayoutOptionsContainer { Options = LayoutOptions.Start, Name = "Start" },
                new LayoutOptionsContainer { Options = LayoutOptions.Center, Name = "Center" },
                new LayoutOptionsContainer { Options = LayoutOptions.End, Name = "End" },
                new LayoutOptionsContainer { Options = LayoutOptions.Fill, Name = "Fill" },
                new LayoutOptionsContainer { Options = LayoutOptions.StartAndExpand, Name = "StartAndExpand" },
                new LayoutOptionsContainer { Options = LayoutOptions.CenterAndExpand, Name = "CenterAndExpand" },
                new LayoutOptionsContainer { Options = LayoutOptions.EndAndExpand, Name = "EndAndExpand" },
                new LayoutOptionsContainer { Options = LayoutOptions.FillAndExpand, Name = "FillAndExpand" },
            };
        }
    }
}

