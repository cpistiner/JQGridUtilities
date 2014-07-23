using System;
using Trirand.Web.Mvc;

namespace Web.ViewModels.JQGridBuilders
{
	public class JQGridColumnBuilder
	{
		public JQGridColumnBuilder()
		{
		}

		public JQGridColumn NewCurrency(string headerText, string dataField)
		{
			var column = this.NewStandar(headerText, dataField);
			column.Width = 97;
			column.TextAlign = Trirand.Web.Mvc.TextAlign.Right;
			column.DataType = typeof(decimal);
			column.DataFormatString = "{0:C2}";

			return column;
		}

		public JQGridColumn NewCuit(string headerText, string dataField)
		{
			var column = this.NewStandar(headerText, dataField);
			column.Width = 85;

			return column;
		}

		public JQGridColumn NewDate(string headerText, string dataField)
		{
			var column = this.NewStandar(headerText, dataField);
			column.DataFormatString = "{0:dd/MM/yyyy}";
			column.DataType = typeof(DateTime);
			column.Width = 70;

			return column;
		}

		public JQGridColumn NewStandar(string headerText, string dataField)
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