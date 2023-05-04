using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saveAsItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("Your Document will be saved","Save?",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void newItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("New Document will be created", "New", MessageBoxButton.OK, MessageBoxImage.Information);

            this.MainTabControl.AddNewTabItem();

            RichTextBox richText = new RichTextBox();
            richText.AppendText("New Tab Text "+ Guid.NewGuid());
            MainTabControl.Items.Add(richText);

        }

        private void BarButtonItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
        }

        private void copyItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("Your Document Copied to Clipboard", "Copied", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void cutItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("Operation Successful", "Cut", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void pasteItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("Your Document Pasted from Clipboard", "Paste", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BarButtonItem_ItemClick_1(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("Text Selected", "Selected", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
