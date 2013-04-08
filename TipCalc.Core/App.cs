using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.ViewModel
{
	public class App : MvxApplication
	{
		public App()
		{
			Mvx.RegisterType<ICalculation, Calculation>();
			Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
		}
	}
}