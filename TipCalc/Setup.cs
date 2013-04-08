using Cirrious.MvvmCross.ViewModels;
using TipCalc.Core;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using TipCalc.ViewModel;

namespace TipCalc
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter)
			: base(appDelegate, presenter)
		{
		}
		
		protected override IMvxApplication CreateApp()
		{
			return new App();
		}
	}
}