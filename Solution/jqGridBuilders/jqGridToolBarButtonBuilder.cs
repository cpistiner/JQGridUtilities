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

		public static JQGridToolBarButton NonDefaultAdd(jqGridBuildersLanguages language)
		{
			var button = NonDefaultAdd();

			if (language == jqGridBuildersLanguages.Spanish)
				button.ToolTip = "Nueva fila";

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

		public static JQGridToolBarButton NonDefaultViewRow(jqGridBuildersLanguages language)
		{
			var button = NonDefaultViewRow();

			if (language == jqGridBuildersLanguages.Spanish)
				button.ToolTip = "Ver la fila seleccionada";

			return button;
		}

		public static JQGridToolBarButton NonDefaultViewRow()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-document";
			button.ToolTip = "View selected row";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "onViewRow";

			return button;
		}

		public static JQGridToolBarButton ColumnChooser(jqGridBuildersLanguages language)
		{
			var button = ColumnChooser();

			if (language == jqGridBuildersLanguages.Spanish)
				button.ToolTip = "Mostrar/ocultar columnas";

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