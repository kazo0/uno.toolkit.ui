﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uno.Toolkit.UI
{
    public partial class TabBarSelectionChangedEventArgs
    {
		public object? NewItem
		{
			get; internal set;
		}

		public object? OldItem
		{
			get; internal set;
		}
	}
}
