﻿using System.Windows;

namespace ChaosRecipeEnhancer.UI.Model.Utils
{
    public static class UserWarning
    {
        public static void WarnUser(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}