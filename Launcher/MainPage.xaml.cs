using System;
using Windows.ApplicationModel;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.Storage;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Launcher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += PageOnLoaded;
            Window.Current.Activated += Current_Activated;
        }

        private async void PageOnLoaded(object sender, RoutedEventArgs e)
        {
            ApplyTransparencyToTitlebar();
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("DriversUsedSpace");

            HDUsedSpace();
        }



        private async void HDUsedSpace()
        {
            string fname = @"Assets\Space_C.txt";
            StorageFolder InstallationFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFile file = await InstallationFolder.GetFileAsync(fname);
            if (File.Exists(file.Path))
            {
                DriveC.Text = File.ReadAllText(fname);
            }

            string fname2 = @"Assets\Space_D.txt";
            StorageFolder InstallationFolder2 = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFile file2 = await InstallationFolder.GetFileAsync(fname2);
            if (File.Exists(file2.Path))
            {
                DriveD.Text = File.ReadAllText(fname2);
            }

        }




        private static void ApplyTransparencyToTitlebar()
        {
            var formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
        }


        private void Current_Activated(object sender, WindowActivatedEventArgs e)    
        {
            if (e.WindowActivationState == CoreWindowActivationState.Deactivated)
            {
                Suspend();
            }
        }


        private async void Suspend()
        {
            //close/suspend the Launcher
            await ApplicationView.GetForCurrentView().TryConsolidateAsync();
        }






        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Edge DEV");
            Suspend();
        }

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Chrome");
            Suspend();
        }

        private async void Button3_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Opera");
            Suspend();
        }



        private async void Button4_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VS2022");
            Suspend();
        }

        private async void Button5_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VSCodePreview");
            Suspend();
        }

        private async void Button6_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VSCodeStable");
            Suspend();
        }




        private async void Button7_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("uTorrent Pro");
            Suspend();
        }

        private async void Button8_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Beyond Compare (Adm)");
            Suspend();
        }

        private async void Button9_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("CCleaner");
            Suspend();
        }

        private async void Button10_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Core Temp");
            Suspend();
        }

        private async void Button11_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("CPU-Z");
            Suspend();
        }

        private async void Button12_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("MusicBee");
            Suspend();
        }

        private async void Button13_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("PDF-XChange Editor");
            Suspend();
        }

        private async void Button14_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Revo Uninstaller Pro");
            Suspend();
        }

        private async void Button15_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VLC");
            Suspend();
        }

        private async void Button16_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("WinRAR");            
            Suspend();
        }







        private async void Button17_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Acronis True Image");
            Suspend();
        }

        private async void Button18_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Bulk File Changer");
            Suspend();
        }

        private async void Button19_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Camtasia Studio");
            Suspend();
        }

        private async void Button20_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Desfragmentar e Otimizar Unidades");
            Suspend();
        }

        private async void Button21_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Driver Booster");
            Suspend();
        }

        private async void Button22_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Duplicate Cleaner Pro");
            Suspend();
        }

        private async void Button23_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("EaseUS Partition Master");
            Suspend();
        }

        private async void Button24_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Font Creator (Portable)");
            Suspend();
        }

        private async void Button25_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("HandBrake");
            Suspend();
        }

        private async void Button26_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("MemoNotes");
            Suspend();
        }

        private async void Button27_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("NVIDIA Painel de Controle");
            Suspend();
        }

        private async void Button28_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("PatchCleaner");
            Suspend();
        }

        private async void Button29_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("PerfectDisk");
            Suspend();
        }

        private async void Button30_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Rainmeter");
            Suspend();
        }

        private async void Button31_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Recuva");
            Suspend();
        }

        private async void Button32_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Rufus");
            Suspend();
        }

        private async void Button33_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Switch Sound File Converter");
            Suspend();
        }

        private async void Button34_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Tornado ThrottleStop");
            Suspend();
        }

        private async void Button35_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("TPM 2.0 error fix");
            Suspend();
        }

        private async void Button36_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("TreeSize");
            Suspend();
        }













        private async void Button37_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Mouse e Teclado");
            Suspend();
        }

        private async void Button38_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Logitech");
            Suspend();
        }

        private async void Button39_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Bluetooth Battery Monitor");
            Suspend();
        }

        private async void Button40_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Windscribe");
            Suspend();
        }

















        private async void Button47_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Captura_e_Esboço");
            Suspend();
        }

        private async void Button48_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("WindowsTerminalAdmin");
            Suspend();
        }

        private async void Button49_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("FixWindowsSettings");
            Suspend();
        }

        private async void Button50_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("LimpezaWindows");
            Suspend();
        }

        private async void Button51_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("ChecarWindowsUpdate");
            Suspend();
        }

        private async void Button52_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Wallpapers");
            Suspend();
        }

        private async void Button53_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("ClipboardHistory");
            Suspend();
        }















        private async void Button100_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Fireworks");
            Suspend();
        }









        private async void Button200_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Shell Menu View");
            Suspend();
        }

        private async void Button201_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Shell Ex View");
            Suspend();
        }















        private async void Button300_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("FotoFamilia");
            Suspend();
        }











        private async void Button400_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Notepad");
            Suspend();
        }

        private async void Button401_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Paint");
            Suspend();
        }

        private async void Button402_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Calculadora");
            Suspend();
        }

        private async void Button403_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("XAML Controls Gallery");
            Suspend();
        }

















        private async void Button500_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Excel");
            Suspend();
        }

        private async void Button501_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Word");
            Suspend();
        }










        private async void Button600_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Relatório de Erros 1");
            Suspend();
        }

        private async void Button601_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Diagnósticos do Feedback Hub");
            Suspend();
        }

        private async void Button602_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("NVidia Downloader");
            Suspend();
        }

        private async void Button603_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Desktop");
            Suspend();
        }

        private async void Button604_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("DesktopDell");
            Suspend();
        }

        private async void Button605_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("ÁreadeTrabalho");
            Suspend();
        }

        private async void Button606_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Avatar");
            Suspend();
        }

        private async void Button607_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Cópia_de_alguns_documentos");
            Suspend();
        }

        private async void Button608_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Corel_Painter");
            Suspend();
        }

        private async void Button609_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Documentos");
            Suspend();
        }

        private async void Button610_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("VisualStudioCrashDumps");
            Suspend();
        }

        private async void Button611_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Meus_Projetos_e_Treinamentos_C");
            Suspend();
        }

        private async void Button612_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("Meus_Projetos_e_Treinamentos_D");
            Suspend();
        }

        private async void Button614_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync("TEMP");
            Suspend();
        }










    }
}
