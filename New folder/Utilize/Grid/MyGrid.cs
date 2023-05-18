using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Infragistics.Win.UltraWinGrid;

namespace WinLibrary.Grid
{
	public class MyGrid : UltraGrid
	{
		public event EventHandler EventDataTableChanged;

		private DataTable _Table;
		public DataTable Table
		{
			get { return _Table; }
			set
			{
				_Table = value;
				DataSource = value;
				if (EventDataTableChanged != null)
					EventDataTableChanged.Invoke(this, new EventArgs());

			}
		}
	}
}
