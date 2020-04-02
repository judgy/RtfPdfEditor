using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using RtfPdfCreator.ViewModels;
using RtfPdfCreator.Views;

namespace RtfPdfCreator
{
    public class RtfPdfModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public RtfPdfModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

            //containerRegistry.RegisterSingleton<IPcStatusControlViewModelService, PcStatusControlViewModelService>();
            //containerRegistry.RegisterSingleton<IPcClockViewModelService, PcClockViewModelService>();
            containerRegistry.Register<PdfViewerViewModel>();
            containerRegistry.Register<RtfEditorViewModel>();

            //containerRegistry.RegisterForNavigation<PcClockView>();
            //containerRegistry.RegisterForNavigation<PcStatusView>();
            //containerRegistry.RegisterForNavigation<ClockSummary>();
            //containerRegistry.RegisterForNavigation<PaidMoneyControl>();

            _regionManager.RegisterViewWithRegion(SubRegionNames.RtfRegion, typeof(RtfEditor));
            _regionManager.RegisterViewWithRegion(SubRegionNames.PdfRegion, typeof(PdfViewer));
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }
    }
}
