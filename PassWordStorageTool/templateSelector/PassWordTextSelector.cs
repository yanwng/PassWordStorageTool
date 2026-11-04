using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PassWordStorageTool.templateSelector
{
    public class PassWordTextSelector:DataTemplateSelector
    {
        public ItemContainerTemplate Pass { get; set; }
        public ItemContainerTemplate ShowPass { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (!((ContentPresenter)container).IsFocused)
                return ShowPass;
            return Pass;
            

        }
    }
}
