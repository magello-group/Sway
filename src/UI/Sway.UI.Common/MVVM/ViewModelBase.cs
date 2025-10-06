using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sway.UI.Common.MVVM
{
	public class ViewModelBase : BindableBase
	{
		public DelegateCommand<object>? NavigateCommand { get; set; }

		private string? _title;
		public string? Title
		{
			get => _title;
			set => SetProperty(ref _title, value);
		}

		private string? _message;
		public string? Message
		{
			get => _message;
			set => SetProperty(ref _message, value);
		}
	}
}
