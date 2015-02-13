using System;
using Trirand.Web.Mvc;

namespace JQGridUtilities.JQGridBuilders
{
	public class JQGridToolBarButtonBuilder
	{
		public static JQGridToolBarButton NonDefaultEdit(jqGridBuildersLanguages language)
		{
			var button = NonDefaultEdit();

			if (language == jqGridBuildersLanguages.Spanish)
				button.ToolTip = "Editar la fila seleccionada";

			return button;
		}

		public static JQGridToolBarButton NonDefaultEdit()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-pencil";
			button.ToolTip = "Edit selected row";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "onEditRow";

			return button;
		}

		public static JQGridToolBarButton NonDefaultAdd()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-plus";
			button.ToolTip = "New row";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "onAddRow";

			return button;
		}

		public static JQGridToolBarButton NonDefaultViewRow()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-document";
			button.ToolTip = "View row";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "onViewRow";

			return button;
		}

		public static JQGridToolBarButton ColumnChooser()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-grip-dotted-vertical";
			button.ToolTip = "Show/hide columns";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.Last;
			button.OnClick = "onShowHideColumns";

			return button;
		}
	}
}