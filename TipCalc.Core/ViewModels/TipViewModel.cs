﻿using Cirrious.MvvmCross.ViewModels;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
		private readonly ICalculation _calculation;
		private int _generosity;
		private int _generosityString;

        private double _subTotal;
        private double _tip;

        public TipViewModel(ICalculation calculation)
        {
            _calculation = calculation;
        }

        public double SubTotal
        {
            get { return _subTotal; }
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalcuate();
            }
        }
		
		public int Generosity
		{
			get { return _generosity; }
			set
			{
				_generosity = Limit(value);
				RaisePropertyChanged(() => Generosity);
				RaisePropertyChanged(() => GenerosityString);
				Recalcuate();
			}
		}

		public string GenerosityString
		{
			get { return _generosity + "%"; } 
		}

        public double Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        public override void Start()
        {
            _subTotal = 219;
            _generosity = 10;
            Recalcuate();
            base.Start();
        }

        private int Limit(int value)
        {
            if (value < 0)
                value = 0;
            if (value > 100)
                value = 100;
            return value;
        }

        private void Recalcuate()
        {
            Tip = _calculation.TipAmount(SubTotal, Generosity);
        }
    }
}