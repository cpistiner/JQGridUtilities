using System;
using Trirand.Web.Mvc;

namespace Web.ViewModels.JQGridBuilders
{
	public class JQGridToolBarButtonBuilder
	{
		internal static JQGridToolBarButton NonDefaultEdit()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-pencil";
			button.ToolTip = "Modificar fila seleccionada (Ctrl+M)";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "modificarFila";

			return button;
		}

		internal static JQGridToolBarButton NonDefaultAdd()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-plus";
			button.ToolTip = "Agregar nueva fila (Ctrl+N)";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "agregarFila";

			return button;
		}
		
		internal static JQGridToolBarButton NonDefaultViewRow()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-document";
			button.ToolTip = "Ver fila";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "verFila";

			return button;
		}

		internal static JQGridToolBarButton ColumnChooser()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-grip-dotted-vertical";
			button.ToolTip = "Mostrar/ocultar columnas";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.Last;
			button.OnClick = "seleccionarColumnas";

			return button;
		}
	}
}