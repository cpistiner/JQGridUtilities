using System;
using Trirand.Web.Mvc;

namespace JQGridUtilities.JQGridBuilders
{
	public class JQGridColumnBuilder
	{
		public JQGridColumnBuilder()
		{
		}

		public JQGridColumn GetCurrency(string headerText, string dataField)
		{
			var column = this.GetStandard(headerText, dataField);
			column.Width = 97;
			column.TextAlign = Trirand.Web.Mvc.TextAlign.Right;
			column.DataType = typeof(decimal);
			column.DataFormatString = "{0:C2}";

			return column;
		}

		public JQGridColumn GetCUIT(string headerText, string dataField)
		{
			var column = this.GetStandard(headerText, dataField);
			column.Width = 85;

			return column;
		}

		public JQGridColumn GetDate(string headerText, string dataField)
		{
			var column = this.GetStandard(headerText, dataField);
			column.DataFormatString = "{0:dd/MM/yyyy}";
			column.DataType = typeof(DateTime);
			column.Width = 70;

			return column;
		}

		public JQGridColumn GetStandard(string headerText, string dataField)
		{
			return new JQGridColumn
			{
				HeaderText = headerText,
				DataField = dataField,

				//standar values
				Editable = false,
				Searchable = false,
				TextAlign = Trirand.Web.Mvc.TextAlign.Center,
				ClearSearch = true
			};
		}
	}
}