using System;
using Trirand.Web.Mvc;

namespace JQGridUtilities.JQGridBuilders
{
	public class JQGridToolBarButtonBuilder
	{
		private static jqGridBuildersLanguages _defaultLanguage;

		public static JQGridToolBarButton NonDefaultEdit()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-pencil";
			button.ToolTip = GetNonDefaultEditToolTipByLanguage(_defaultLanguage);
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "onEditRow";

			return button;
		}

		public static JQGridToolBarButton NonDefaultAdd()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-plus";
			button.ToolTip = GetNonDefaultAddToolTipByLanguage(_defaultLanguage);
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "onAddRow";

			return button;
		}

		public static JQGridToolBarButton NonDefaultViewRow()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-document";
			button.ToolTip = GetNonDefaultViewRowToolTipByLanguage(_defaultLanguage);
			button.Text = " ";
			button.Position = ToolBarButtonPosition.First;
			button.OnClick = "onViewRow";

			return button;
		}

		public static JQGridToolBarButton ColumnChooser()
		{
			var button = new JQGridToolBarButton();
			button.ButtonIcon = "ui-icon-grip-dotted-vertical";
			button.ToolTip = GetColumnChooserToolTipByLanguage(_defaultLanguage);
			button.Text = " ";
			button.Position = ToolBarButtonPosition.Last;
			button.OnClick = "onShowHideColumns";

			return button;
		}

		public static JQGridToolBarButton Comments()
		{
			var button = new JQGridToolBarButton();
			button.ToolTip = GetCommentsToolTipByLanguage(_defaultLanguage);
			button.ButtonIcon = "ui-icon-comment";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.Last;
			button.OnClick = "comments";

			return button;
		}

		public static JQGridToolBarButton Comments(jqGridBuildersLanguages language)
		{
			var button = Comments();

			if (language == jqGridBuildersLanguages.Spanish)
				button.ToolTip = "Conversación";

			return button;
		}

		public static JQGridToolBarButton Print()
		{
			var button = new JQGridToolBarButton();
			button.ToolTip = GetPrintToolTipByLanguage(_defaultLanguage);
			button.ButtonIcon = "ui-icon-print";
			button.Text = " ";
			button.Position = ToolBarButtonPosition.Last;
			button.OnClick = "print";

			return button;
		}

		public static JQGridToolBarButton Print(jqGridBuildersLanguages language)
		{
			var button = Print();

			if (language == jqGridBuildersLanguages.Spanish)
				button.ToolTip = "Imprimir la fila seleccionada";

			return button;
		}

		public static jqGridBuildersLanguages DefaultLanguage 
		{
			get { return _defaultLanguage; }
		}

		public static void SetDefaultLanguage(jqGridBuildersLanguages language)
		{
			_defaultLanguage = language;
		}

		public static void Initialize()
		{
			_defaultLanguage = jqGridBuildersLanguages.English;
		}

		private static string GetNonDefaultEditToolTipByLanguage(jqGridBuildersLanguages language)
		{
			switch (language)
			{
				case jqGridBuildersLanguages.English:
					return "Edit selected row";
				case jqGridBuildersLanguages.Spanish:
					return "Editar la fila seleccionada";
				default:
					return "Edit selected row";
			}
		}

		private static string GetNonDefaultAddToolTipByLanguage(jqGridBuildersLanguages language)
		{
			switch (language)
			{
				case jqGridBuildersLanguages.English:
					return "New row";
				case jqGridBuildersLanguages.Spanish:
					return "Nueva fila";
				default:
					return "New row";
			}
		}

		private static string GetNonDefaultViewRowToolTipByLanguage(jqGridBuildersLanguages language)
		{
			switch (language)
			{
				case jqGridBuildersLanguages.English:
					return "View selected row";
				case jqGridBuildersLanguages.Spanish:
					return "Ver la fila seleccionada";
				default:
					return "View selected row";
			}
		}

		private static string GetColumnChooserToolTipByLanguage(jqGridBuildersLanguages language)
		{
			switch (language)
			{
				case jqGridBuildersLanguages.English:
					return "Show/hide columns";
				case jqGridBuildersLanguages.Spanish:
					return "Mostrar/ocultar columnas";
				default:
					return "Show/hide columns";
			}
		}

		private static string GetCommentsToolTipByLanguage(jqGridBuildersLanguages language)
		{
			switch (language)
			{
				case jqGridBuildersLanguages.English:
					return "Comments";
				case jqGridBuildersLanguages.Spanish:
					return "Conversación";
				default:
					return "Comments";
			}
		}

		private static string GetPrintToolTipByLanguage(jqGridBuildersLanguages language)
		{
			switch (language)
			{
				case jqGridBuildersLanguages.English:
					return "Print selected row";
				case jqGridBuildersLanguages.Spanish:
					return "Imprimir la fila seleccionada";
				default:
					return "Print selected row";
			}
		}
	}
}