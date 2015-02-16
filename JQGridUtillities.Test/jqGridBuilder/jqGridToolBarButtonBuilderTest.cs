using JQGridUtilities.JQGridBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trirand.Web.Mvc;

namespace JQGridUtilities.Test.jqGridBuilder
{
	[TestClass]
	public class jqGridToolBarButtonBuilderTest
	{
		[TestMethod]
		public void NonDefaultEdit_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultEdit();

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultEdit(jqGridBuildersLanguages.English);

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultEdit(jqGridBuildersLanguages.Spanish);

			Assert.AreEqual("Editar la fila seleccionada", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultAdd_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultAdd();

			Assert.AreEqual("New row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultAdd_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultAdd(jqGridBuildersLanguages.English);

			Assert.AreEqual("New row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultAdd_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultAdd(jqGridBuildersLanguages.Spanish);

			Assert.AreEqual("Nueva fila", button.ToolTip);
		}

		//NonDefaultViewRow
		[TestMethod]
		public void NonDefaultViewRow_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultViewRow();

			Assert.AreEqual("View selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultViewRow_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultViewRow(jqGridBuildersLanguages.English);

			Assert.AreEqual("View selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultViewRow_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.NonDefaultViewRow(jqGridBuildersLanguages.Spanish);

			Assert.AreEqual("Ver la fila seleccionada", button.ToolTip);
		}

		//ColumnChooser
		[TestMethod]
		public void ColumnChooser_TooltipInEnglishByDefault()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.ColumnChooser();

			Assert.AreEqual("Show/hide columns", button.ToolTip);
		}

		[TestMethod]
		public void ColumnChooser_TooltipInEnglishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.ColumnChooser(jqGridBuildersLanguages.English);

			Assert.AreEqual("Show/hide columns", button.ToolTip);
		}

		[TestMethod]
		public void ColumnChooser_TooltipInSpanishByParameter()
		{
			JQGridToolBarButton button = JQGridToolBarButtonBuilder.ColumnChooser(jqGridBuildersLanguages.Spanish);

			Assert.AreEqual("Mostrar/ocultar columnas", button.ToolTip);
		}
	}
}