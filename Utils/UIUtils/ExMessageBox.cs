using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;

namespace Axen.Minecraft.Launcher.Utils.UIUtils
{
    public class ExMessageBox
    {
        public static async Task<object> ShowAlert(string title, string message, string confirmTitle,
            Action<object, DialogClosingEventArgs> closingHandler = null)
        {
            var content = new StackPanel
            {
                Height = 180,
                Width = 350,
                Children =
                {
                    new TextBlock
                    {
                        Text = title,
                        Margin = new Thickness(5),
                        FontSize = 24
                    },
                    new TextBlock
                    {
                        Text = message,
                        Margin = new Thickness(5),
                        FontSize = 14,
                        Height = 85,
                        TextWrapping = TextWrapping.Wrap
                    },
                    new Button
                    {
                        Content = confirmTitle,
                        Margin = new Thickness(5),
                        Command = DialogHost.CloseDialogCommand,
                        Style = StyleLocator.GetStyle("MaterialDesignFlatButton")
                    }
                }
            };

            return await DialogHost.Show(content, closingHandler);
        }

        public static async Task<bool> ShowConfirm(string title, string message, string confirmTitle,
            string cancelTitle, Action<object, DialogClosingEventArgs> closingHandler = null)
        {
            var content = new StackPanel
            {
                Height = 180,
                Width = 350,
                Children =
                {
                    new TextBlock
                    {
                        Text = title,
                        Margin = new Thickness(5),
                        FontSize = 24
                    },
                    new TextBlock
                    {
                        Text = message,
                        Margin = new Thickness(5),
                        FontSize = 14,
                        Height = 85,
                        TextWrapping = TextWrapping.Wrap
                    },
                    new StackPanel
                    {
                        Orientation = Orientation.Horizontal,
                        HorizontalAlignment = HorizontalAlignment.Right,
                        Children =
                        {
                            new Button
                            {
                                Content = confirmTitle,
                                Margin = new Thickness(5),
                                Command = DialogHost.CloseDialogCommand,
                                CommandParameter = true,
                                Style = StyleLocator.GetStyle("MaterialDesignFlatButton")
                            },
                            new Button
                            {
                                Content = cancelTitle,
                                Margin = new Thickness(5),
                                Command = DialogHost.CloseDialogCommand,
                                CommandParameter = false,
                                Style = StyleLocator.GetStyle("MaterialDesignFlatButton"),
                                Foreground = Brushes.Gray
                            }
                        }
                    }
                }
            };

            return (bool) await DialogHost.Show(content, closingHandler);
        }
    }
}