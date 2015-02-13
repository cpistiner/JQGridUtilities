using JQGridUtilities.JQGridBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JQGridUtillities.Test.jqGridBuilder
{
	[TestClass]
	public class jqGridToolBarButtonBuilderTest
	{
		[TestMethod]
		public void NonDefaultEdit_SetTooltipByDefault()
		{
			var button = JQGridToolBarButtonBuilder.NonDefaultEdit();

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInEnglishByDefault()
		{
			var button = JQGridToolBarButtonBuilder.NonDefaultEdit();

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInEnglishByParameter()
		{
			var button = JQGridToolBarButtonBuilder.NonDefaultEdit(jqGridBuildersLanguages.English);

			Assert.AreEqual("Edit selected row", button.ToolTip);
		}

		[TestMethod]
		public void NonDefaultEdit_TooltipInSpanishByParameter()
		{
			var button = JQGridToolBarButtonBuilder.NonDefaultEdit(jqGridBuildersLanguages.Spanish);

			Assert.AreEqual("Editar la fila seleccionada", button.ToolTip);
		}
	}
}
